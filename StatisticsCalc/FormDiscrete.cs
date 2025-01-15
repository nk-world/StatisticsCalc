using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StatisticsCalc
{
    public partial class FormDiscrete : Form
    {
        public FormDiscrete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner?.Show();
            this.Hide();
        }

        private void FormDiscrete_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (!double.TryParse(e.FormattedValue.ToString(), out _))
                {
                    if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString())) return;

                    e.Cancel = true;
                    MessageBox.Show("Only numbers are allowed.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.ColumnIndex == 1)
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int temp) || temp < 1)
                {
                    if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString())) return;

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

            List<double> data = new List<double>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null ||
                    string.IsNullOrWhiteSpace(dataGridView1.Rows[i].Cells[0].Value.ToString()) ||
                    dataGridView1.Rows[i].Cells[0].Value.ToString() == "???") continue;

                if (double.TryParse(dataGridView1.Rows[i].Cells[0].Value.ToString(), out double datum))
                {
                    if (dataGridView1.Rows[i].Cells[1].Value == null ||
                        string.IsNullOrWhiteSpace(dataGridView1.Rows[i].Cells[1].Value.ToString())) data.Add(datum);
                    else
                        if (int.TryParse(dataGridView1.Rows[i].Cells[1].Value.ToString(), out int freq))
                        for (int j = 0; j < freq; j++)
                            data.Add(datum);
                }
            }

            var result = Program.CalcAll(data);
            (double mean, double median, List<double> modeList) = result.Item1;
            ((double q1, double q3), (double max, double min)) = result.Item2;
            ((double md1, double mdc1), (double md2, double mdc2)) = result.Item3;
            (double sd, double sdc, double variance, double varc) = result.Item4;

            string mode = modeList != null && modeList.Count > 0
                ? string.Join(", ", modeList)
                : "-";

            int dataCount = data.Count;

            UpdateResultLabel(mean, median, mode, q1, q3, max, min, md1, md2, mdc1, mdc2, sd, sdc, variance, varc, dataCount);
        }

        private void ResetResults()
        {
            ResultMean.Text = ResultMedian.Text = ResultMode.Text = ResultMax.Text = ResultMin.Text = ResultQ1.Text = ResultQ3.Text = "-";
            ResultMD1.Text = ResultMD2.Text = ResultMDC1.Text = ResultMDC2.Text = ResultSD.Text = ResultSDC.Text = ResultVar.Text =
                ResultVarC.Text = ResultN.Text = "-";
        }

        private void UpdateResultLabel(
            double mean, double median, string mode,
            double q1, double q3, double max, double min,
            double md1, double md2, double mdc1, double mdc2,
            double sd, double sdc, double variance, double varc,
            int dataCount)
        {
            ResultMean.Text = double.IsNaN(mean) ? "-" : mean.ToString();
            ResultMedian.Text = double.IsNaN(median) ? "-" : median.ToString();
            ResultMode.Text = mode;
            ResultMax.Text = double.IsNaN(max) ? "-" : max.ToString();
            ResultMin.Text = double.IsNaN(min) ? "-" : min.ToString();
            ResultQ1.Text = double.IsNaN(q1) ? "-" : q1.ToString();
            ResultQ3.Text = double.IsNaN(q3) ? "-" : q3.ToString();
            ResultMD1.Text = double.IsNaN(md1) ? "-" : md1.ToString();
            ResultMD2.Text = double.IsNaN(md2) ? "-" : md2.ToString();
            ResultMDC1.Text = double.IsNaN(mdc1) ? "-" : mdc1.ToString();
            ResultMDC2.Text = double.IsNaN(mdc2) ? "-" : mdc2.ToString();
            ResultSD.Text = double.IsNaN(sd) ? "-" : sd.ToString();
            ResultSDC.Text = double.IsNaN(sdc) ? "-" : sdc.ToString();
            ResultVar.Text = double.IsNaN(variance) ? "-" : variance.ToString();
            ResultVarC.Text = double.IsNaN(varc) ? "-" : (varc.ToString() + "%");
            ResultN.Text = dataCount.ToString();
        }

        private void ResultMean_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultMean.Text) && ResultMean.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultMean.Text);
            }
        }

        private void ResultMedian_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultMedian.Text) && ResultMedian.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultMedian.Text);
            }
        }

        private void ResultMode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultMode.Text) && ResultMode.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultMode.Text);
            }
        }

        private void ResultQ1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultQ1.Text) && ResultQ1.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultQ1.Text);
            }
        }

        private void ResultQ3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultQ3.Text) && ResultQ3.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultQ3.Text);
            }
        }

        private void ResultMin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultMin.Text) && ResultMin.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultMin.Text);
            }
        }

        private void ResultMax_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultMax.Text) && ResultMax.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultMax.Text);
            }
        }

        private void ResultMD1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultMD1.Text) && ResultMD1.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultMD1.Text);
            }
        }

        private void ResultMD2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultMD2.Text) && ResultMD2.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultMD2.Text);
            }
        }

        private void ResultMDC1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultMDC1.Text) && ResultMDC1.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultMDC1.Text);
            }
        }

        private void ResultMDC2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultMDC2.Text) && ResultMDC2.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultMDC2.Text);
            }
        }

        private void ResultSD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultSD.Text) && ResultSD.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultSD.Text);
            }
        }

        private void ResultSDC_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(ResultSDC.Text) && ResultSDC.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultSDC.Text);
            }
        }

        private void ResultVar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultVar.Text) && ResultVar.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultVar.Text);
            }
        }

        private void ResultVarC_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultVarC.Text) && ResultVarC.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultVarC.Text);
            }
        }
    }
}