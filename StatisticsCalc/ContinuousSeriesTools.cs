using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
                if (lowerLimit >= l && lowerLimit <= u)
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
            for (int i = 0; i < classIntervals.Count; i++)
            {
                (double lowerLimit, double upperLimit) = ClassIntervalTools.GetClassInterval(classIntervals[i]);
                int frequency = frequencies[i];
                cf += frequency;
                statisticsData.Add(new StatisticsData(lowerLimit, upperLimit, frequency, cf));
            }
            statisticsData = ClassIntervalTools.Sort(statisticsData);
            return statisticsData;
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
            double medianClassMidPoint = 0;
            int medianClassIndex = 0;
            int medianClassFrequency = 0;
            int cf = 0;
            for (int i = 0; i < statisticsData.Count; i++)
            {
                cf = statisticsData[i].cf;
                if (cf >= n / 2)
                {
                    medianClassIndex = i;
                    medianClassFrequency = statisticsData[i].frequency;
                    break;
                }
            }
            medianClassMidPoint = statisticsData[medianClassIndex].MidPoint;
            double h = statisticsData[0].ClassWidth;
            double l = statisticsData[medianClassIndex].lowerLimit;
            int f = medianClassFrequency;
            return l + ((n / 2 - cf) / f) * h;
        }

        private static double GetMode(List<StatisticsData> statisticsData)
        {
            double h = statisticsData[0].ClassWidth;
            double l = statisticsData[0].lowerLimit;
            double f1 = statisticsData[1].frequency;
            double f0 = statisticsData[0].frequency;
            double f2 = statisticsData[2].frequency;
            return l + h * ((f1 - f0) / ((f1 - f0) + (f1 - f2)));
        }

        private static double GetUpperQuartile(List<StatisticsData> statisticsData)
        {
            int n = statisticsData.Sum(data => data.frequency);
            double upperQuartileClassMidPoint = 0;
            int upperQuartileClassIndex = 0;
            int upperQuartileClassFrequency = 0;
            int cf = 0;
            for (int i = 0; i < statisticsData.Count; i++)
            {
                cf = statisticsData[i].cf;
                if (cf >= 3 * n / 4)
                {
                    upperQuartileClassIndex = i;
                    upperQuartileClassFrequency = statisticsData[i].frequency;
                    break;
                }
            }
            upperQuartileClassMidPoint = statisticsData[upperQuartileClassIndex].MidPoint;
            double h = statisticsData[0].ClassWidth;
            double l = statisticsData[upperQuartileClassIndex].lowerLimit;
            int f = upperQuartileClassFrequency;
            return l + ((3 * n / 4 - cf) / f) * h;
        }

        private static double GetLowerQuartile(List<StatisticsData> statisticsData)
        {
            int n = statisticsData.Sum(data => data.frequency);
            double lowerQuartileClassMidPoint = 0;
            int lowerQuartileClassIndex = 0;
            int lowerQuartileClassFrequency = 0;
            int cf = 0;
            for (int i = 0; i < statisticsData.Count; i++)
            {
                cf = statisticsData[i].cf;
                if (cf >= n / 4)
                {
                    lowerQuartileClassIndex = i;
                    lowerQuartileClassFrequency = statisticsData[i].frequency;
                    break;
                }
            }
            lowerQuartileClassMidPoint = statisticsData[lowerQuartileClassIndex].MidPoint;
            double h = statisticsData[0].ClassWidth;
            double l = statisticsData[lowerQuartileClassIndex].lowerLimit;
            int f = lowerQuartileClassFrequency;
            return l + ((n / 4 - cf) / f) * h;
        }

        private static (double, double) GetMeanDeviationFromMean(List<StatisticsData> statisticsData)
        {
            double mean = GetMean(statisticsData);
            double sumOfDeviationsFromMean = statisticsData.Sum(data => Math.Abs(mean - data.MidPoint));
            int n = statisticsData.Sum(data => data.frequency);

            double meanDeviationFromMean = sumOfDeviationsFromMean / n;
            double coefficientOfMeanDeviationFromMean = meanDeviationFromMean / mean;
            return (meanDeviationFromMean, coefficientOfMeanDeviationFromMean);
        }

        private static (double, double) GetMeanDeviationFromMedian(List<StatisticsData> statisticsData)
        {
            double median = GetMedian(statisticsData);
            double sumOfDeviationsFromMedian = statisticsData.Sum(data => Math.Abs(median - data.MidPoint));
            int n = statisticsData.Sum(data => data.frequency);

            double meanDeviationFromMedian = sumOfDeviationsFromMedian / n;
            double coefficientOfMeanDeviationFromMedian = meanDeviationFromMedian / median;
            return (meanDeviationFromMedian, coefficientOfMeanDeviationFromMedian);
        }

        private static (double, double) GetStandardDeviation(List<StatisticsData> statisticsData)
        {
            double mean = GetMean(statisticsData);
            double sumOfSquaresOfDeviations = statisticsData.Sum(data => Math.Pow(data.MidPoint - mean, 2) * data.frequency);
            int n = statisticsData.Sum(data => data.frequency);
            double variance = sumOfSquaresOfDeviations / n;
            double standardDeviation = Math.Sqrt(variance);
            double coefficientOfStandardDeviation = standardDeviation / mean;
            return (standardDeviation, coefficientOfStandardDeviation);
        }

        private static (double, double) GetVariance(List<StatisticsData> statisticsData)
        {
            double mean = GetMean(statisticsData);
            double sumOfSquaresOfDeviations = statisticsData.Sum(data => Math.Pow(data.MidPoint - mean, 2) * data.frequency);
            int n = statisticsData.Sum(data => data.frequency);
            double variance = sumOfSquaresOfDeviations / n;
            double coefficientOfVariance = variance / mean;
            return (variance, coefficientOfVariance);
        }

        public static StatisticsResult GetStatisticsResult(List<StatisticsData> statisticsData)
        {
            statisticsData = ClassIntervalTools.Sort(statisticsData);
            StatisticsResult statisticsResult = new StatisticsResult
            {
                mean = GetMean(statisticsData),
                median = GetMedian(statisticsData),
                mode = GetMode(statisticsData),
                upperQuartile = GetUpperQuartile(statisticsData),
                lowerQuartile = GetLowerQuartile(statisticsData)
            };
            (statisticsResult.meanDeviationFromMean, statisticsResult.coefficientOfMeanDeviationFromMean) = GetMeanDeviationFromMean(statisticsData);
            (statisticsResult.meanDeviationFromMedian, statisticsResult.coefficientOfMeanDeviationFromMedian) = GetMeanDeviationFromMedian(statisticsData);
            (statisticsResult.standardDeviation, statisticsResult.coefficientOfStandardDeviation) = GetStandardDeviation(statisticsData);
            (statisticsResult.variance, statisticsResult.coefficientOfVariance) = GetVariance(statisticsData);
            statisticsResult.totalNumberOfData = statisticsData.Sum(data => data.frequency);
            return statisticsResult;
        }
    }
}
