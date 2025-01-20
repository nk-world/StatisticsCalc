using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticsCalc
{
    public partial class FormIndividual : Form
    {
        public FormIndividual()
        {
            InitializeComponent();
        }

        private void FormIndividual_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner?.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner?.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Allow control keys (e.g., Backspace, Delete, Arrow keys)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow digits, commas, decimal points, and negative signs
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-')
            {
                // Check if the minus sign is in the right place
                if (e.KeyChar == '-' && !IsMinusAllowed(textBox))
                {
                    e.Handled = true; // Block the keypress if minus is not allowed
                    return;
                }

                // Check if the decimal point is in the right place
                if (e.KeyChar == '.' && !IsDecimalAllowed(textBox))
                {
                    e.Handled = true; // Block the keypress if decimal is not allowed
                    return;
                }

                // Block comma after minus
                if (e.KeyChar == ',' && IsCommaAfterMinus(textBox))
                {
                    e.Handled = true; // Block the comma if it comes after a minus sign
                    return;
                }

                // Block comma immediately after a decimal point (without digits after it)
                if (e.KeyChar == ',' && IsCommaAfterDecimalWithoutDigits(textBox))
                {
                    e.Handled = true; // Block the comma if it comes after a decimal point without digits
                    return;
                }

                // Allow the keypress
                return;
            }

            // Block any invalid input
            e.Handled = true;
        }

        private bool IsMinusAllowed(TextBox textBox)
        {
            string text = textBox.Text;
            int cursorPos = textBox.SelectionStart;

            // The minus sign is allowed if it's at the start or follows a comma
            if (cursorPos == 0 || (cursorPos > 0 && text[cursorPos - 1] == ','))
            {
                return true;
            }

            return false;
        }

        private bool IsDecimalAllowed(TextBox textBox)
        {
            string text = textBox.Text;
            int cursorPos = textBox.SelectionStart;

            // Split the text by commas to check each number
            string[] parts = text.Split(',');

            // Find the part where the cursor is currently located
            int partIndex = 0;
            int cursorPositionInPart = cursorPos;
            foreach (string part in parts)
            {
                cursorPositionInPart -= part.Length + 1; // Account for the comma separator

                if (cursorPositionInPart < 0)
                {
                    break;
                }
                partIndex++;
            }

            // Get the part where the decimal point might be inserted
            string currentPart = parts[partIndex];

            // Check if there is already a decimal point in the current part
            if (currentPart.Contains("."))
            {
                return false; // Block additional decimal points in the same part
            }

            return true; // Allow decimal point if no decimal is present in the current part
        }

        private bool IsCommaAfterMinus(TextBox textBox)
        {
            string text = textBox.Text;
            int cursorPos = textBox.SelectionStart;

            // Check if the cursor is directly after a minus sign
            if (cursorPos > 0 && text[cursorPos - 1] == '-')
            {
                return true; // Comma is after minus, block it
            }

            return false; // Otherwise, allow comma
        }

        // Block comma immediately after a decimal point without digits following it
        private bool IsCommaAfterDecimalWithoutDigits(TextBox textBox)
        {
            string text = textBox.Text;
            int cursorPos = textBox.SelectionStart;

            // Check if the cursor is immediately after a decimal point, with no digits following
            if (cursorPos > 0 && text[cursorPos - 1] == '.' && (cursorPos == text.Length || !char.IsDigit(text[cursorPos])))
            {
                return true; // Comma after decimal without digits, block it
            }

            return false; // Otherwise, allow comma
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ShowResult();
        }


        private void ShowResult()
        {
            string input = textBox1.Text;

            // If input is empty, clear all results
            if (string.IsNullOrEmpty(input))
            {
                ResetResults();
                return;
            }

            // Remove any trailing commas or dashes that might have been entered
            input = input.TrimEnd(',', '-', '.');

            // Split the input by commas
            string[] values = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Create a list to store the numbers
            List<double> numbers = new List<double>();


            // Parse all values into doubles (assuming keypress validation handles most issues)
            foreach (var value in values)
            {
                if (double.TryParse(value, out double num))
                {
                    numbers.Add(num);
                }
            }


            // If no valid numbers were entered, reset and return
            if (numbers.Count == 0)
            {
                ResetResults();
                return;
            }

            // Calculate all results
            var result = Program.CalcAll(numbers);
            (double mean, double median, List<double> modeList) = result.Item1;
            ((double q1, double q3), (double max, double min)) = result.Item2;
            ((double md1, double mdc1), (double md2, double mdc2)) = result.Item3;
            (double sd, double sdc, double variance, double varc) = result.Item4;
            List<double> data = result.Item5;

            string mode = modeList != null && modeList.Count > 0
                ? string.Join(", ", modeList)
                : "-";

            int count = data.Count;

            UpdateResultLabel(mean, median, mode, q1, q3, max, min, md1, md2, mdc1, mdc2, sd, sdc, variance, varc, data, count);
        }

        private void ResetResults()
        {
            ResultMean.Text = ResultMedian.Text = ResultMode.Text = ResultMax.Text = ResultMin.Text = ResultQ1.Text = ResultQ3.Text = "-";
            ResultMD1.Text = ResultMD2.Text = ResultMDC1.Text = ResultMDC2.Text = ResultSD.Text = ResultSDC.Text = ResultVar.Text = 
                ResultVarC.Text = ResultData.Text = ResultN.Text =  "-";
        }

        private void UpdateResultLabel(
            double mean, double median, string mode,
            double q1, double q3, double max, double min,
            double md1, double md2, double mdc1, double mdc2,
            double sd, double sdc, double variance, double varc,
            List<double> data, int count)
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
            ResultData.Text = string.Join(", ", data);
            ResultN.Text = count.ToString();
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
            if (!string.IsNullOrEmpty(ResultVar.Text) &&  ResultVar.Text.Trim() != "-")
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

        private void ResultData_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultData.Text) && ResultData.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultData.Text);
            }
        }

        private void ResultN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultN.Text) && ResultN.Text.Trim() != "-")
            {
                Clipboard.SetText(ResultN.Text);
            }
        }
    }
}
