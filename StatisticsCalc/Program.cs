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

        public static ((double, double, double), (double, double), (double, double), ((double, double), (double, double), (double, double, double, double))) CalcResults(List<double> data)
        {
            
            double mean = data.Average();
            
            data.Sort();
            double median;
            if (data.Count % 2 == 0)
            {
                median = (data[data.Count / 2 - 1] + data[data.Count / 2]) / 2;
            }
            else
            {
                median = data[data.Count / 2];
            }
            
            var mode = data.GroupBy(n => n)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();


            return ((mean, median, mode), (1, 1), (1, 1), ((1, 1), (1, 1), (1, 1, 1, 1)));
        }
    }
}
