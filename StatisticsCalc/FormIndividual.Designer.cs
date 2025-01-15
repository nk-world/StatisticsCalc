namespace StatisticsCalc
{
    partial class FormIndividual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndividual));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelMean = new System.Windows.Forms.Label();
            this.LabelMedian = new System.Windows.Forms.Label();
            this.LabelMode = new System.Windows.Forms.Label();
            this.Label1Quartile = new System.Windows.Forms.Label();
            this.Label3Quartile = new System.Windows.Forms.Label();
            this.LabelMinimum = new System.Windows.Forms.Label();
            this.LabelMaximum = new System.Windows.Forms.Label();
            this.LabelMDMean = new System.Windows.Forms.Label();
            this.LabelMDMeanCoefficient = new System.Windows.Forms.Label();
            this.LabelMDMedian = new System.Windows.Forms.Label();
            this.LabelMDMedianCoefficient = new System.Windows.Forms.Label();
            this.LabelStandardDeviation = new System.Windows.Forms.Label();
            this.LabelStandardDeviationCoefficient = new System.Windows.Forms.Label();
            this.LabelVariance = new System.Windows.Forms.Label();
            this.LabelVarianceCoefficient = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ResultMean = new System.Windows.Forms.Label();
            this.ResultMedian = new System.Windows.Forms.Label();
            this.ResultMode = new System.Windows.Forms.Label();
            this.ResultQ1 = new System.Windows.Forms.Label();
            this.ResultQ3 = new System.Windows.Forms.Label();
            this.ResultMin = new System.Windows.Forms.Label();
            this.ResultMax = new System.Windows.Forms.Label();
            this.ResultMD1 = new System.Windows.Forms.Label();
            this.ResultMDC1 = new System.Windows.Forms.Label();
            this.ResultVarC = new System.Windows.Forms.Label();
            this.ResultVar = new System.Windows.Forms.Label();
            this.ResultSDC = new System.Windows.Forms.Label();
            this.ResultSD = new System.Windows.Forms.Label();
            this.ResultMDC2 = new System.Windows.Forms.Label();
            this.ResultMD2 = new System.Windows.Forms.Label();
            this.LabelDataInAscendingOrder = new System.Windows.Forms.Label();
            this.ResultData = new System.Windows.Forms.Label();
            this.labelDataCount = new System.Windows.Forms.Label();
            this.ResultN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 365);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 42);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the data above, separate each of them using commas.";
            // 
            // LabelMean
            // 
            this.LabelMean.AutoSize = true;
            this.LabelMean.Location = new System.Drawing.Point(271, 55);
            this.LabelMean.Name = "LabelMean";
            this.LabelMean.Size = new System.Drawing.Size(37, 13);
            this.LabelMean.TabIndex = 3;
            this.LabelMean.Text = "Mean:";
            // 
            // LabelMedian
            // 
            this.LabelMedian.AutoSize = true;
            this.LabelMedian.Location = new System.Drawing.Point(263, 68);
            this.LabelMedian.Name = "LabelMedian";
            this.LabelMedian.Size = new System.Drawing.Size(45, 13);
            this.LabelMedian.TabIndex = 3;
            this.LabelMedian.Text = "Median:";
            // 
            // LabelMode
            // 
            this.LabelMode.AutoSize = true;
            this.LabelMode.Location = new System.Drawing.Point(271, 81);
            this.LabelMode.Name = "LabelMode";
            this.LabelMode.Size = new System.Drawing.Size(37, 13);
            this.LabelMode.TabIndex = 3;
            this.LabelMode.Text = "Mode:";
            // 
            // Label1Quartile
            // 
            this.Label1Quartile.AutoSize = true;
            this.Label1Quartile.Location = new System.Drawing.Point(240, 105);
            this.Label1Quartile.Name = "Label1Quartile";
            this.Label1Quartile.Size = new System.Drawing.Size(68, 13);
            this.Label1Quartile.TabIndex = 3;
            this.Label1Quartile.Text = "First Quartile:";
            // 
            // Label3Quartile
            // 
            this.Label3Quartile.AutoSize = true;
            this.Label3Quartile.Location = new System.Drawing.Point(235, 118);
            this.Label3Quartile.Name = "Label3Quartile";
            this.Label3Quartile.Size = new System.Drawing.Size(73, 13);
            this.Label3Quartile.TabIndex = 3;
            this.Label3Quartile.Text = "Third Quartile:";
            // 
            // LabelMinimum
            // 
            this.LabelMinimum.AutoSize = true;
            this.LabelMinimum.Location = new System.Drawing.Point(281, 142);
            this.LabelMinimum.Name = "LabelMinimum";
            this.LabelMinimum.Size = new System.Drawing.Size(27, 13);
            this.LabelMinimum.TabIndex = 3;
            this.LabelMinimum.Text = "Min:";
            // 
            // LabelMaximum
            // 
            this.LabelMaximum.AutoSize = true;
            this.LabelMaximum.Location = new System.Drawing.Point(278, 155);
            this.LabelMaximum.Name = "LabelMaximum";
            this.LabelMaximum.Size = new System.Drawing.Size(30, 13);
            this.LabelMaximum.TabIndex = 3;
            this.LabelMaximum.Text = "Max:";
            // 
            // LabelMDMean
            // 
            this.LabelMDMean.AutoSize = true;
            this.LabelMDMean.Location = new System.Drawing.Point(170, 179);
            this.LabelMDMean.Name = "LabelMDMean";
            this.LabelMDMean.Size = new System.Drawing.Size(138, 13);
            this.LabelMDMean.TabIndex = 3;
            this.LabelMDMean.Text = "Mean Deviation from Mean:";
            // 
            // LabelMDMeanCoefficient
            // 
            this.LabelMDMeanCoefficient.AutoSize = true;
            this.LabelMDMeanCoefficient.Location = new System.Drawing.Point(157, 192);
            this.LabelMDMeanCoefficient.Name = "LabelMDMeanCoefficient";
            this.LabelMDMeanCoefficient.Size = new System.Drawing.Size(151, 13);
            this.LabelMDMeanCoefficient.TabIndex = 3;
            this.LabelMDMeanCoefficient.Text = "Coefficient of M.D. from Mean:";
            // 
            // LabelMDMedian
            // 
            this.LabelMDMedian.AutoSize = true;
            this.LabelMDMedian.Location = new System.Drawing.Point(162, 216);
            this.LabelMDMedian.Name = "LabelMDMedian";
            this.LabelMDMedian.Size = new System.Drawing.Size(146, 13);
            this.LabelMDMedian.TabIndex = 3;
            this.LabelMDMedian.Text = "Mean Deviation from Median:";
            // 
            // LabelMDMedianCoefficient
            // 
            this.LabelMDMedianCoefficient.AutoSize = true;
            this.LabelMDMedianCoefficient.Location = new System.Drawing.Point(149, 229);
            this.LabelMDMedianCoefficient.Name = "LabelMDMedianCoefficient";
            this.LabelMDMedianCoefficient.Size = new System.Drawing.Size(159, 13);
            this.LabelMDMedianCoefficient.TabIndex = 3;
            this.LabelMDMedianCoefficient.Text = "Coefficient of M.D. from Median:";
            // 
            // LabelStandardDeviation
            // 
            this.LabelStandardDeviation.AutoSize = true;
            this.LabelStandardDeviation.Location = new System.Drawing.Point(207, 256);
            this.LabelStandardDeviation.Name = "LabelStandardDeviation";
            this.LabelStandardDeviation.Size = new System.Drawing.Size(101, 13);
            this.LabelStandardDeviation.TabIndex = 3;
            this.LabelStandardDeviation.Text = "Standard Deviation:";
            // 
            // LabelStandardDeviationCoefficient
            // 
            this.LabelStandardDeviationCoefficient.AutoSize = true;
            this.LabelStandardDeviationCoefficient.Location = new System.Drawing.Point(212, 269);
            this.LabelStandardDeviationCoefficient.Name = "LabelStandardDeviationCoefficient";
            this.LabelStandardDeviationCoefficient.Size = new System.Drawing.Size(96, 13);
            this.LabelStandardDeviationCoefficient.TabIndex = 3;
            this.LabelStandardDeviationCoefficient.Text = "Coefficient of S.D.:";
            // 
            // LabelVariance
            // 
            this.LabelVariance.AutoSize = true;
            this.LabelVariance.Location = new System.Drawing.Point(256, 282);
            this.LabelVariance.Name = "LabelVariance";
            this.LabelVariance.Size = new System.Drawing.Size(52, 13);
            this.LabelVariance.TabIndex = 3;
            this.LabelVariance.Text = "Variance:";
            // 
            // LabelVarianceCoefficient
            // 
            this.LabelVarianceCoefficient.AutoSize = true;
            this.LabelVarianceCoefficient.Location = new System.Drawing.Point(191, 295);
            this.LabelVarianceCoefficient.Name = "LabelVarianceCoefficient";
            this.LabelVarianceCoefficient.Size = new System.Drawing.Size(117, 13);
            this.LabelVarianceCoefficient.TabIndex = 3;
            this.LabelVarianceCoefficient.Text = "Coefficient of Variance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label6.Location = new System.Drawing.Point(165, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 46);
            this.label6.TabIndex = 4;
            this.label6.Text = "Individual Series Result";
            // 
            // ResultMean
            // 
            this.ResultMean.AutoSize = true;
            this.ResultMean.Location = new System.Drawing.Point(314, 55);
            this.ResultMean.Name = "ResultMean";
            this.ResultMean.Size = new System.Drawing.Size(10, 13);
            this.ResultMean.TabIndex = 5;
            this.ResultMean.Text = "-";
            this.ResultMean.Click += new System.EventHandler(this.ResultMean_Click);
            // 
            // ResultMedian
            // 
            this.ResultMedian.AutoSize = true;
            this.ResultMedian.Location = new System.Drawing.Point(314, 68);
            this.ResultMedian.Name = "ResultMedian";
            this.ResultMedian.Size = new System.Drawing.Size(10, 13);
            this.ResultMedian.TabIndex = 5;
            this.ResultMedian.Text = "-";
            this.ResultMedian.Click += new System.EventHandler(this.ResultMedian_Click);
            // 
            // ResultMode
            // 
            this.ResultMode.AutoSize = true;
            this.ResultMode.Location = new System.Drawing.Point(314, 81);
            this.ResultMode.Name = "ResultMode";
            this.ResultMode.Size = new System.Drawing.Size(10, 13);
            this.ResultMode.TabIndex = 5;
            this.ResultMode.Text = "-";
            this.ResultMode.Click += new System.EventHandler(this.ResultMode_Click);
            // 
            // ResultQ1
            // 
            this.ResultQ1.AutoSize = true;
            this.ResultQ1.Location = new System.Drawing.Point(314, 105);
            this.ResultQ1.Name = "ResultQ1";
            this.ResultQ1.Size = new System.Drawing.Size(10, 13);
            this.ResultQ1.TabIndex = 5;
            this.ResultQ1.Text = "-";
            this.ResultQ1.Click += new System.EventHandler(this.ResultQ1_Click);
            // 
            // ResultQ3
            // 
            this.ResultQ3.AutoSize = true;
            this.ResultQ3.Location = new System.Drawing.Point(314, 118);
            this.ResultQ3.Name = "ResultQ3";
            this.ResultQ3.Size = new System.Drawing.Size(10, 13);
            this.ResultQ3.TabIndex = 5;
            this.ResultQ3.Text = "-";
            this.ResultQ3.Click += new System.EventHandler(this.ResultQ3_Click);
            // 
            // ResultMin
            // 
            this.ResultMin.AutoSize = true;
            this.ResultMin.Location = new System.Drawing.Point(314, 142);
            this.ResultMin.Name = "ResultMin";
            this.ResultMin.Size = new System.Drawing.Size(10, 13);
            this.ResultMin.TabIndex = 5;
            this.ResultMin.Text = "-";
            this.ResultMin.Click += new System.EventHandler(this.ResultMin_Click);
            // 
            // ResultMax
            // 
            this.ResultMax.AutoSize = true;
            this.ResultMax.Location = new System.Drawing.Point(314, 155);
            this.ResultMax.Name = "ResultMax";
            this.ResultMax.Size = new System.Drawing.Size(10, 13);
            this.ResultMax.TabIndex = 5;
            this.ResultMax.Text = "-";
            this.ResultMax.Click += new System.EventHandler(this.ResultMax_Click);
            // 
            // ResultMD1
            // 
            this.ResultMD1.AutoSize = true;
            this.ResultMD1.Location = new System.Drawing.Point(314, 179);
            this.ResultMD1.Name = "ResultMD1";
            this.ResultMD1.Size = new System.Drawing.Size(10, 13);
            this.ResultMD1.TabIndex = 5;
            this.ResultMD1.Text = "-";
            this.ResultMD1.Click += new System.EventHandler(this.ResultMD1_Click);
            // 
            // ResultMDC1
            // 
            this.ResultMDC1.AutoSize = true;
            this.ResultMDC1.Location = new System.Drawing.Point(314, 192);
            this.ResultMDC1.Name = "ResultMDC1";
            this.ResultMDC1.Size = new System.Drawing.Size(10, 13);
            this.ResultMDC1.TabIndex = 5;
            this.ResultMDC1.Text = "-";
            this.ResultMDC1.Click += new System.EventHandler(this.ResultMDC1_Click);
            // 
            // ResultVarC
            // 
            this.ResultVarC.AutoSize = true;
            this.ResultVarC.Location = new System.Drawing.Point(314, 295);
            this.ResultVarC.Name = "ResultVarC";
            this.ResultVarC.Size = new System.Drawing.Size(10, 13);
            this.ResultVarC.TabIndex = 5;
            this.ResultVarC.Text = "-";
            this.ResultVarC.Click += new System.EventHandler(this.ResultVarC_Click);
            // 
            // ResultVar
            // 
            this.ResultVar.AutoSize = true;
            this.ResultVar.Location = new System.Drawing.Point(314, 282);
            this.ResultVar.Name = "ResultVar";
            this.ResultVar.Size = new System.Drawing.Size(10, 13);
            this.ResultVar.TabIndex = 5;
            this.ResultVar.Text = "-";
            this.ResultVar.Click += new System.EventHandler(this.ResultVar_Click);
            // 
            // ResultSDC
            // 
            this.ResultSDC.AutoSize = true;
            this.ResultSDC.Location = new System.Drawing.Point(314, 269);
            this.ResultSDC.Name = "ResultSDC";
            this.ResultSDC.Size = new System.Drawing.Size(10, 13);
            this.ResultSDC.TabIndex = 5;
            this.ResultSDC.Text = "-";
            this.ResultSDC.Click += new System.EventHandler(this.ResultSDC_Click);
            // 
            // ResultSD
            // 
            this.ResultSD.AutoSize = true;
            this.ResultSD.Location = new System.Drawing.Point(314, 256);
            this.ResultSD.Name = "ResultSD";
            this.ResultSD.Size = new System.Drawing.Size(10, 13);
            this.ResultSD.TabIndex = 5;
            this.ResultSD.Text = "-";
            this.ResultSD.Click += new System.EventHandler(this.ResultSD_Click);
            // 
            // ResultMDC2
            // 
            this.ResultMDC2.AutoSize = true;
            this.ResultMDC2.Location = new System.Drawing.Point(314, 229);
            this.ResultMDC2.Name = "ResultMDC2";
            this.ResultMDC2.Size = new System.Drawing.Size(10, 13);
            this.ResultMDC2.TabIndex = 5;
            this.ResultMDC2.Text = "-";
            this.ResultMDC2.Click += new System.EventHandler(this.ResultMDC2_Click);
            // 
            // ResultMD2
            // 
            this.ResultMD2.AutoSize = true;
            this.ResultMD2.Location = new System.Drawing.Point(314, 216);
            this.ResultMD2.Name = "ResultMD2";
            this.ResultMD2.Size = new System.Drawing.Size(10, 13);
            this.ResultMD2.TabIndex = 5;
            this.ResultMD2.Text = "-";
            this.ResultMD2.Click += new System.EventHandler(this.ResultMD2_Click);
            // 
            // LabelDataInAscendingOrder
            // 
            this.LabelDataInAscendingOrder.AutoSize = true;
            this.LabelDataInAscendingOrder.Location = new System.Drawing.Point(241, 317);
            this.LabelDataInAscendingOrder.Name = "LabelDataInAscendingOrder";
            this.LabelDataInAscendingOrder.Size = new System.Drawing.Size(67, 13);
            this.LabelDataInAscendingOrder.TabIndex = 6;
            this.LabelDataInAscendingOrder.Text = "Sorted Data:";
            // 
            // ResultData
            // 
            this.ResultData.AutoSize = true;
            this.ResultData.Location = new System.Drawing.Point(314, 317);
            this.ResultData.Name = "ResultData";
            this.ResultData.Size = new System.Drawing.Size(10, 13);
            this.ResultData.TabIndex = 5;
            this.ResultData.Text = "-";
            this.ResultData.Click += new System.EventHandler(this.ResultData_Click);
            // 
            // labelDataCount
            // 
            this.labelDataCount.AutoSize = true;
            this.labelDataCount.Location = new System.Drawing.Point(196, 339);
            this.labelDataCount.Name = "labelDataCount";
            this.labelDataCount.Size = new System.Drawing.Size(112, 13);
            this.labelDataCount.TabIndex = 7;
            this.labelDataCount.Text = "Total Number of Data:";
            // 
            // ResultN
            // 
            this.ResultN.AutoSize = true;
            this.ResultN.Location = new System.Drawing.Point(314, 339);
            this.ResultN.Name = "ResultN";
            this.ResultN.Size = new System.Drawing.Size(10, 13);
            this.ResultN.TabIndex = 8;
            this.ResultN.Text = "-";
            this.ResultN.Click += new System.EventHandler(this.ResultN_Click);
            // 
            // FormIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultN);
            this.Controls.Add(this.labelDataCount);
            this.Controls.Add(this.LabelDataInAscendingOrder);
            this.Controls.Add(this.ResultMD2);
            this.Controls.Add(this.ResultMDC2);
            this.Controls.Add(this.ResultSD);
            this.Controls.Add(this.ResultSDC);
            this.Controls.Add(this.ResultVar);
            this.Controls.Add(this.ResultData);
            this.Controls.Add(this.ResultVarC);
            this.Controls.Add(this.ResultMDC1);
            this.Controls.Add(this.ResultMD1);
            this.Controls.Add(this.ResultMax);
            this.Controls.Add(this.ResultMin);
            this.Controls.Add(this.ResultQ3);
            this.Controls.Add(this.ResultQ1);
            this.Controls.Add(this.ResultMode);
            this.Controls.Add(this.ResultMedian);
            this.Controls.Add(this.ResultMean);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelVarianceCoefficient);
            this.Controls.Add(this.LabelVariance);
            this.Controls.Add(this.LabelStandardDeviationCoefficient);
            this.Controls.Add(this.LabelStandardDeviation);
            this.Controls.Add(this.LabelMDMedianCoefficient);
            this.Controls.Add(this.LabelMDMedian);
            this.Controls.Add(this.LabelMDMeanCoefficient);
            this.Controls.Add(this.LabelMDMean);
            this.Controls.Add(this.LabelMaximum);
            this.Controls.Add(this.LabelMinimum);
            this.Controls.Add(this.Label3Quartile);
            this.Controls.Add(this.Label1Quartile);
            this.Controls.Add(this.LabelMode);
            this.Controls.Add(this.LabelMedian);
            this.Controls.Add(this.LabelMean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormIndividual";
            this.Text = "Individual Series";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormIndividual_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelMean;
        private System.Windows.Forms.Label LabelMedian;
        private System.Windows.Forms.Label LabelMode;
        private System.Windows.Forms.Label Label1Quartile;
        private System.Windows.Forms.Label Label3Quartile;
        private System.Windows.Forms.Label LabelMinimum;
        private System.Windows.Forms.Label LabelMaximum;
        private System.Windows.Forms.Label LabelMDMean;
        private System.Windows.Forms.Label LabelMDMeanCoefficient;
        private System.Windows.Forms.Label LabelMDMedian;
        private System.Windows.Forms.Label LabelMDMedianCoefficient;
        private System.Windows.Forms.Label LabelStandardDeviation;
        private System.Windows.Forms.Label LabelStandardDeviationCoefficient;
        private System.Windows.Forms.Label LabelVariance;
        private System.Windows.Forms.Label LabelVarianceCoefficient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ResultMean;
        private System.Windows.Forms.Label ResultMedian;
        private System.Windows.Forms.Label ResultMode;
        private System.Windows.Forms.Label ResultQ1;
        private System.Windows.Forms.Label ResultQ3;
        private System.Windows.Forms.Label ResultMin;
        private System.Windows.Forms.Label ResultMax;
        private System.Windows.Forms.Label ResultMD1;
        private System.Windows.Forms.Label ResultMDC1;
        private System.Windows.Forms.Label ResultVarC;
        private System.Windows.Forms.Label ResultVar;
        private System.Windows.Forms.Label ResultSDC;
        private System.Windows.Forms.Label ResultSD;
        private System.Windows.Forms.Label ResultMDC2;
        private System.Windows.Forms.Label ResultMD2;
        private System.Windows.Forms.Label LabelDataInAscendingOrder;
        private System.Windows.Forms.Label ResultData;
        private System.Windows.Forms.Label labelDataCount;
        private System.Windows.Forms.Label ResultN;
    }
}