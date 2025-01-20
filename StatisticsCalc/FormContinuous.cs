using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticsCalc
{
    public partial class FormContinuous : Form
    {
        public FormContinuous()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Owner?.Show();
            this.Hide();
        }

        private void FormContinuous_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string input = e.FormattedValue.ToString();
            if (e.ColumnIndex == 0)
            {
                List<string> classIntervals = new List<string>();
                for (int i=0; i < dataGridView1.Rows.Count; i++)
                {
                    if(dataGridView1.CurrentRow == dataGridView1.Rows[i]) continue;
                    string value = dataGridView1.Rows[i].Cells[0].Value?.ToString();
                    if (!string.IsNullOrWhiteSpace(value) &&
                        !value.Trim().Equals("???"))
                        classIntervals.Add(value);
                }
                if (!ClassIntervalTools.IsClassIntervalAllowed(input, classIntervals))
                {
                    if(string.IsNullOrWhiteSpace(input)) return;
                    e.Cancel = true;
                    MessageBox.Show("Invalid format or interval overlaps with an existing one.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.ColumnIndex == 1)
            {
                if (!int.TryParse(input, out int frequency) || frequency < 1)
                {
                    if (string.IsNullOrWhiteSpace(input)) return;

                    e.Cancel = true;
                    MessageBox.Show("Only positive integers are allowed.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var cellValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[1].Value == null ||
                        string.IsNullOrWhiteSpace(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()))
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[1].Value = "1";
                    }
                }
            }

            if (e.ColumnIndex == 1)
            {
                var cellValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[0].Value == null ||
                        string.IsNullOrWhiteSpace(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[0].Value = "???";
                    }
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                dataGridView1.CancelEdit();
                e.Handled = true;
            }
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            ShowResults();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ShowResults();
        }

        private void ShowResults()
        {
            bool isDataPresent = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null &&
                    !string.IsNullOrWhiteSpace(dataGridView1.Rows[i].Cells[0].Value.ToString()) &&
                    dataGridView1.Rows[i].Cells[0].Value.ToString().Trim() != "???")
                {
                    isDataPresent = true;
                    break;
                }
            }

            if (!isDataPresent)
            {
                MessageBox.Show("Please enter the data first.", "No data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetResults();
                return;
            }

            List<string> classIntervals = new List<string>();
            List<int> frequencies = new List<int>();

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null &&
                    !string.IsNullOrWhiteSpace(dataGridView1.Rows[i].Cells[0].Value.ToString()) &&
                    dataGridView1.Rows[i].Cells[0].Value.ToString().Trim() != "???")
                {
                    string classInterval = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    classIntervals.Add(classInterval);

                    int frequency = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    frequencies.Add(frequency);
                }
            }

            List<StatisticsData> statisticsData = new List<StatisticsData>();
            try
            {
                statisticsData = ContinuousSeriesCalculator.GetStatisticsData(classIntervals, frequencies);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "InternalError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetResults();
                return;
            }

            StatisticsResult statisticsResult = ContinuousSeriesCalculator.GetStatisticsResult(statisticsData);

            UpdateLabel(statisticsResult);
        }

        private void ResetResults()
        {
            ResultMean.Text = ResultMedian.Text = ResultMode.Text = ResultUpperQuartile.Text = ResultLowerQuartile.Text =
            ResultMeanDeviationFromMean.Text = ResultMeanDeviationFromMedian.Text =
            ResultCoefficientOfMeanDeviationFromMean.Text = ResultCoefficientOfMeanDeviationFromMedian.Text =
            ResultStandardDeviation.Text = ResultCoefficientOfStandardDeviation.Text = ResultVariance.Text =
            ResultCoefficientOfVariance.Text = ResultDataCount.Text = "-";
        }

        private void UpdateLabel(StatisticsResult statisticsResult)
        {
            ResultMean.Text = statisticsResult.mean.ToString();
            ResultMedian.Text = statisticsResult.median.ToString();
            ResultMode.Text = statisticsResult.mode.ToString();
            ResultUpperQuartile.Text = statisticsResult.upperQuartile.ToString();
            ResultLowerQuartile.Text = statisticsResult.lowerQuartile.ToString();
            ResultMeanDeviationFromMean.Text = statisticsResult.meanDeviationFromMean.ToString();
            ResultMeanDeviationFromMedian.Text = statisticsResult.meanDeviationFromMedian.ToString();
            ResultCoefficientOfMeanDeviationFromMean.Text = statisticsResult.coefficientOfMeanDeviationFromMean.ToString() + "%";
            ResultCoefficientOfMeanDeviationFromMedian.Text = statisticsResult.coefficientOfMeanDeviationFromMedian.ToString() + "%";
            ResultStandardDeviation.Text = statisticsResult.standardDeviation.ToString();
            ResultCoefficientOfStandardDeviation.Text = statisticsResult.coefficientOfStandardDeviation.ToString();
            ResultVariance.Text = statisticsResult.variance.ToString();
            ResultCoefficientOfVariance.Text = statisticsResult.coefficientOfVariance.ToString() + "%";
            ResultDataCount.Text = statisticsResult.totalNumberOfData.ToString();
        }

        private void CopyResult(object sender)
        {
            string text = (sender as Label).Text.Trim();
            if (!string.IsNullOrWhiteSpace(text) && text != "-")
                Clipboard.SetText(text);
        }

        private void ResultMean_Click(object sender, EventArgs e)
        {
            CopyResult(sender);
        }

        private void ResultMedian_Click(object sender, EventArgs e)
        {
            CopyResult(sender);
        }

        private void ResultMode_Click(object sender, EventArgs e)
        {
            CopyResult(sender);
        }

        private void ResultLowerQuartile_Click(object sender, EventArgs e)
        {
            CopyResult(sender);
        }

        private void ResultUpperQuartile_Click(object sender, EventArgs e)
        {
            CopyResult(sender);
        }

        private void ResultMeanDeviationFromMean_Click(object sender, EventArgs e)
        {
            CopyResult(sender);
        }

        private void ResultCoefficientOfMeanDeviationFromMean_Click(object sender, EventArgs e)
        {
            CopyResult(sender);
        }

        private void ResultMeanDeviationFromMedian_Click(object sender, EventArgs e)
        {
            CopyResult(sender);
        }

        private void ResultCoefficientOfMeanDeviationFromMedian_Click(object sender, EventArgs e)
        {
            CopyResult(sender);
        }

        private void ResultStandardDeviation_Click(object sender, EventArgs e)
        {
            CopyResult(sender);
        }

        private void ResultCoefficientOfStandardDeviation_Click(object sender, EventArgs e)
        {
            CopyResult(sender);
        }

        private void ResultVariance_Click(object sender, EventArgs e)
        {
            CopyResult(sender);
        }

        private void ResultCoefficientOfVariance_Click(object sender, EventArgs e)
        {
            CopyResult(sender);
        }

        private void ResultDataCount_Click(object sender, EventArgs e)
        {
            CopyResult(sender);
        }
    }
}
