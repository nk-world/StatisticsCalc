using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticsCalc
{
    public class StatisticsData
    {
        public double lowerLimit;
        public double upperLimit;
        public int frequency;
        public int cf;
        public double MidPoint => (lowerLimit + upperLimit) / 2;
        public double ClassWidth => upperLimit - lowerLimit;
        public double fm => frequency * MidPoint;

        public StatisticsData(double lowerLimit, double upperLimit, int frequency, int cf)
        {
            this.lowerLimit = lowerLimit;
            this.upperLimit = upperLimit;
            this.frequency = frequency;
            this.cf = cf;
        }
    }

    public class StatisticsResult
    {
        public double mean;
        public double median;
        public double mode;
        public double upperQuartile;
        public double lowerQuartile;
        public double meanDeviationFromMean;
        public double coefficientOfMeanDeviationFromMean;
        public double meanDeviationFromMedian;
        public double coefficientOfMeanDeviationFromMedian;
        public double standardDeviation;
        public double coefficientOfStandardDeviation;
        public double variance;
        public double coefficientOfVariance;
        public int totalNumberOfData;
    }

    internal class ClassIntervalTools
    {
        private static bool IsValidClassInterval(string classInterval)
        {
            string pattern = @"^\s*(-?\d+(?:\.\d+)?)\s*-\s*(-?\d+(?:\.\d+)?)\s*$";

            Match match = Regex.Match(classInterval, pattern);

            if(!match.Success)
                return false;

            double lowerLimit = double.Parse(match.Groups[1].Value);
            double upperLimit = double.Parse(match.Groups[2].Value);

            return lowerLimit < upperLimit;
        }

        public static (double, double) GetClassInterval(string classInterval)
        {
            string pattern = @"^\s*(-?\d+(?:\.\d+)?)\s*-\s*(-?\d+(?:\.\d+)?)\s*$";

            Match match = Regex.Match(classInterval, pattern);

            return (double.Parse(match.Groups[1].Value), double.Parse(match.Groups[2].Value));
        }

        public static bool IsClassIntervalAllowed(string classInterval, List<string> classIntervals)
        {
            if(!IsValidClassInterval(classInterval))
                return false;

            (double lowerLimit, double upperLimit) = GetClassInterval(classInterval);

            foreach (string ci in classIntervals)
            {
                (double l, double u) = GetClassInterval(ci);
                if (lowerLimit >= l && lowerLimit < u)
                    return false;
                if (upperLimit >= l && upperLimit <= u)
                    return false;
            }

            return true;
        }

        public static List<StatisticsData> Sort(List<StatisticsData> statisticsData)
        {
            return statisticsData.OrderBy(data => data.lowerLimit).ToList();
        }
    }

    internal class ContinuousSeriesCalculator
    {
        public static List<StatisticsData> GetStatisticsData(List<string> classIntervals, List<int> frequencies)
        {
            List<StatisticsData> statisticsData = new List<StatisticsData>();
            int cf = 0;
            if (classIntervals.Count == 0 || frequencies.Count == 0 || classIntervals.Count != frequencies.Count)
            {
                throw new ArgumentException("Class intervals and frequencies must be non-empty and of the same length.");
            }

            for (int i = 0; i < classIntervals.Count; i++)
            {
                (double lowerLimit, double upperLimit) = ClassIntervalTools.GetClassInterval(classIntervals[i]);
                int frequency = frequencies[i];
                cf = cf == 0 ? frequency : cf + frequency;
                statisticsData.Add(new StatisticsData(lowerLimit, upperLimit, frequency, cf));
            }

            return ClassIntervalTools.Sort(statisticsData);
        }

        private static double GetMean(List<StatisticsData> statisticsData)
        {
            double sumFm = statisticsData.Sum(data => data.fm);
            int sumF = statisticsData.Sum(data => data.frequency);
            return sumFm / sumF;
        }

        private static double GetMedian(List<StatisticsData> statisticsData)
        {
            int n = statisticsData.Sum(data => data.frequency);
            double l = 0, h = 0;
            int f = 0, cfPrev = 0;

            foreach (var data in statisticsData)
            {
                if (data.cf >= n / 2.0)
                {
                    l = data.lowerLimit;
                    f = data.frequency;
                    cfPrev = statisticsData.IndexOf(data) > 0 ? statisticsData[statisticsData.IndexOf(data) - 1].cf : 0;
                    h = data.ClassWidth;
                    break;
                }
            }

            return l + ((n / 2.0 - cfPrev) / f) * h;
        }

        private static double GetMode(List<StatisticsData> statisticsData)
        {
            int modeIndex = statisticsData.IndexOf(statisticsData.OrderByDescending(d => d.frequency).First());
            var modeData = statisticsData[modeIndex];
            double l = modeData.lowerLimit;
            double h = modeData.ClassWidth;
            double f1 = modeData.frequency;
            double f0 = modeIndex > 0 ? statisticsData[modeIndex - 1].frequency : 0;
            double f2 = modeIndex < statisticsData.Count - 1 ? statisticsData[modeIndex + 1].frequency : 0;

            return l + ((f1 - f0) / ((f1 - f0) + (f1 - f2))) * h;
        }

        private static double GetQuartile(List<StatisticsData> statisticsData, double fraction)
        {
            int n = statisticsData.Sum(data => data.frequency);
            double l, h;
            int f, cfPrev;
            double quartile = 0;

            foreach (var data in statisticsData)
            {
                if (data.cf >= n * fraction)
                {
                    l = data.lowerLimit;
                    f = data.frequency;
                    cfPrev = statisticsData.IndexOf(data) > 0 ? statisticsData[statisticsData.IndexOf(data) - 1].cf : 0;
                    h = data.ClassWidth;
                    quartile = l + ((n * fraction - cfPrev) / f) * h;
                    break;
                }
            }
            return quartile;
        }

        private static (double, double) GetMeanDeviation(List<StatisticsData> statisticsData, double centralValue)
        {
            double sumOfDeviations = statisticsData.Sum(data => data.frequency * Math.Abs(data.MidPoint - centralValue));
            int n = statisticsData.Sum(data => data.frequency);
            double meanDeviation = sumOfDeviations / n;
            double coefficientOfMeanDeviation = meanDeviation / centralValue * 100;
            return (meanDeviation, coefficientOfMeanDeviation);
        }

        private static (double, double) GetStandardDeviation(List<StatisticsData> statisticsData, double mean)
        {
            double sumOfSquares = statisticsData.Sum(data => data.frequency * Math.Pow(data.MidPoint - mean, 2));
            int n = statisticsData.Sum(data => data.frequency);
            double variance = sumOfSquares / n;
            double standardDeviation = Math.Sqrt(variance);
            double coefficientOfStandardDeviation = (standardDeviation / mean) * 100;
            return (standardDeviation, coefficientOfStandardDeviation);
        }

        public static StatisticsResult GetStatisticsResult(List<StatisticsData> statisticsData)
        {
            var result = new StatisticsResult();
            statisticsData = ClassIntervalTools.Sort(statisticsData);

            result.mean = GetMean(statisticsData);
            result.median = GetMedian(statisticsData);
            result.mode = GetMode(statisticsData);
            result.lowerQuartile = GetQuartile(statisticsData, 0.25);
            result.upperQuartile = GetQuartile(statisticsData, 0.75);

            (result.meanDeviationFromMean, result.coefficientOfMeanDeviationFromMean) =
                GetMeanDeviation(statisticsData, result.mean);

            (result.meanDeviationFromMedian, result.coefficientOfMeanDeviationFromMedian) =
                GetMeanDeviation(statisticsData, result.median);

            (result.standardDeviation, result.coefficientOfStandardDeviation) =
                GetStandardDeviation(statisticsData, result.mean);

            result.variance = Math.Pow(result.standardDeviation, 2);
            result.coefficientOfVariance = (result.standardDeviation / result.mean) * 100;
            result.totalNumberOfData = statisticsData.Sum(data => data.frequency);

            return result;
        }
    }

}
