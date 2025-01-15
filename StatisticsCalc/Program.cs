using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticsCalc
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static (double mean, double median, List<double> mode) Calc3M(List<double> data)
        {
            double mean = data.Average();

            int middle = data.Count / 2;
            double median;
            if (data.Count % 2 == 0)
            {
                median = (data[middle - 1] + data[middle]) / 2;
            }
            else
            {
                median = data[middle];
            }

            // Group by number and select all modes
            var groupedData = data.GroupBy(n => n)
                                  .OrderByDescending(g => g.Count())
                                  .ToList();

            int maxCount = groupedData.First().Count();

            // Select all numbers with the same highest count (multiple modes)
            var mode = groupedData.Where(g => g.Count() == maxCount)
                                  .Select(g => g.Key)
                                  .ToList();

            return (mean, median, mode);
        }


        private static ((double, double), (double, double)) Calc2Q2M(List<double> data) 
        {
            if (data.Count == 1)
            {
                double it = data[0];
                return ((it, it), (it, it));
            }

            double max = data.Max();
            double min = data.Min();

            int mid = data.Count / 2;

            List<double> lowerHalf = data.GetRange(0, mid);
            List<double> upperHalf = data.GetRange((data.Count % 2 == 0) ? mid : mid + 1, mid);


            double q1 = Calc3M(lowerHalf).Item2;
            double q3 = Calc3M(upperHalf).Item2;

            return ((q1, q3), (max, min));
        }

        private static ((double, double), (double, double)) CalcMD(List<double> data)
        {
            if (data.Count == 1)
            {
                return ((0, 0), (0, 0));
            }

            double mean = Calc3M(data).Item1;
            double median = Calc3M(data).Item2;

            double md1 = data.Select(x => Math.Abs(x - mean)).Average();
            double md2 = data.Select(x => Math.Abs(x - median)).Average();

            double mdc1 = md1 / mean;
            double mdc2 = md2 / median;

            return ((md1, mdc1), (md2, mdc2));
        }

        private static (double, double, double, double) CalcSD(List<double> data)
        {
            if (data.Count == 1)
            {
                return (0, 0, 0, 0);
            }

            double mean = Calc3M(data).Item1;
            double variance = data.Select(x => Math.Pow(x - mean, 2)).Sum() / data.Count;
            double standardDeviation = Math.Sqrt(variance);
            double standardDeviationC = standardDeviation / mean;
            double varianceC = standardDeviationC * 100;
            
            return (standardDeviation, standardDeviationC, variance, varianceC);
        }

        public static
    ((double , double , List<double>),
    ((double, double), (double, double)),
    ((double, double), (double, double)),
    (double, double, double, double), List<double>)
    CalcAll(List<double> data)
        {
            data.Sort();
            var result1 = Calc3M(data);
            var result2 = Calc2Q2M(data);
            var result3 = CalcMD(data);
            var result4 = CalcSD(data);

            return (result1, result2, result3, result4, data);
        }

    }
}
