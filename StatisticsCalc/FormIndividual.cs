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
            Application.Exit();
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
            string[] values = textBox1.Text.Split(',');
            List<double> numbers = new List<double>(Array.ConvertAll(values, double.Parse));

            var result = Program.CalcResults(numbers);

            ResultMean.Text = result.Item1.Item1.ToString();
            ResultMedian.Text = result.Item1.Item2.ToString();
            ResultMode.Text = result.Item1.Item3.ToString();
        }
    }
}
