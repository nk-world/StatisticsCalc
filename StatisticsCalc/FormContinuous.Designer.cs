namespace StatisticsCalc
{
    partial class FormContinuous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContinuous));
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultDataCount = new System.Windows.Forms.Label();
            this.labelTotalNum = new System.Windows.Forms.Label();
            this.ResultMeanDeviationFromMedian = new System.Windows.Forms.Label();
            this.ResultCoefficientOfMeanDeviationFromMedian = new System.Windows.Forms.Label();
            this.ResultStandardDeviation = new System.Windows.Forms.Label();
            this.ResultCoefficientOfStandardDeviation = new System.Windows.Forms.Label();
            this.ResultVariance = new System.Windows.Forms.Label();
            this.ResultCoefficientOfVariance = new System.Windows.Forms.Label();
            this.ResultCoefficientOfMeanDeviationFromMean = new System.Windows.Forms.Label();
            this.ResultMeanDeviationFromMean = new System.Windows.Forms.Label();
            this.ResultUpperQuartile = new System.Windows.Forms.Label();
            this.ResultLowerQuartile = new System.Windows.Forms.Label();
            this.ResultMode = new System.Windows.Forms.Label();
            this.ResultMedian = new System.Windows.Forms.Label();
            this.ResultMean = new System.Windows.Forms.Label();
            this.LabelVarianceCoefficient = new System.Windows.Forms.Label();
            this.LabelVariance = new System.Windows.Forms.Label();
            this.LabelStandardDeviationCoefficient = new System.Windows.Forms.Label();
            this.LabelStandardDeviation = new System.Windows.Forms.Label();
            this.LabelMDMedianCoefficient = new System.Windows.Forms.Label();
            this.LabelMDMedian = new System.Windows.Forms.Label();
            this.LabelMDMeanCoefficient = new System.Windows.Forms.Label();
            this.LabelMDMean = new System.Windows.Forms.Label();
            this.LabelThirdQuartile = new System.Windows.Forms.Label();
            this.LabelFirstQuartile = new System.Windows.Forms.Label();
            this.LabelMode = new System.Windows.Forms.Label();
            this.LabelMedian = new System.Windows.Forms.Label();
            this.LabelMean = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.IQRlabel = new System.Windows.Forms.Label();
            this.QDlabel = new System.Windows.Forms.Label();
            this.qdclabel = new System.Windows.Forms.Label();
            this.ResultInterQuartileRange = new System.Windows.Forms.Label();
            this.ResultQuartileDeviation = new System.Windows.Forms.Label();
            this.ResultCoefficientQD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(713, 415);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Main menu";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CI,
            this.Frequency});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 426);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // CI
            // 
            this.CI.HeaderText = "Class Intervals (C.I.)";
            this.CI.Name = "CI";
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency (f)";
            this.Frequency.Name = "Frequency";
            // 
            // ResultDataCount
            // 
            this.ResultDataCount.AutoSize = true;
            this.ResultDataCount.Location = new System.Drawing.Point(471, 372);
            this.ResultDataCount.Name = "ResultDataCount";
            this.ResultDataCount.Size = new System.Drawing.Size(10, 13);
            this.ResultDataCount.TabIndex = 73;
            this.ResultDataCount.Text = "-";
            this.ResultDataCount.Click += new System.EventHandler(this.ResultDataCount_Click);
            // 
            // labelTotalNum
            // 
            this.labelTotalNum.AutoSize = true;
            this.labelTotalNum.Location = new System.Drawing.Point(353, 372);
            this.labelTotalNum.Name = "labelTotalNum";
            this.labelTotalNum.Size = new System.Drawing.Size(112, 13);
            this.labelTotalNum.TabIndex = 72;
            this.labelTotalNum.Text = "Total Number of Data:";
            // 
            // ResultMeanDeviationFromMedian
            // 
            this.ResultMeanDeviationFromMedian.AutoSize = true;
            this.ResultMeanDeviationFromMedian.Location = new System.Drawing.Point(471, 266);
            this.ResultMeanDeviationFromMedian.Name = "ResultMeanDeviationFromMedian";
            this.ResultMeanDeviationFromMedian.Size = new System.Drawing.Size(10, 13);
            this.ResultMeanDeviationFromMedian.TabIndex = 70;
            this.ResultMeanDeviationFromMedian.Text = "-";
            this.ResultMeanDeviationFromMedian.Click += new System.EventHandler(this.ResultMeanDeviationFromMedian_Click);
            // 
            // ResultCoefficientOfMeanDeviationFromMedian
            // 
            this.ResultCoefficientOfMeanDeviationFromMedian.AutoSize = true;
            this.ResultCoefficientOfMeanDeviationFromMedian.Location = new System.Drawing.Point(471, 279);
            this.ResultCoefficientOfMeanDeviationFromMedian.Name = "ResultCoefficientOfMeanDeviationFromMedian";
            this.ResultCoefficientOfMeanDeviationFromMedian.Size = new System.Drawing.Size(10, 13);
            this.ResultCoefficientOfMeanDeviationFromMedian.TabIndex = 69;
            this.ResultCoefficientOfMeanDeviationFromMedian.Text = "-";
            this.ResultCoefficientOfMeanDeviationFromMedian.Click += new System.EventHandler(this.ResultCoefficientOfMeanDeviationFromMedian_Click);
            // 
            // ResultStandardDeviation
            // 
            this.ResultStandardDeviation.AutoSize = true;
            this.ResultStandardDeviation.Location = new System.Drawing.Point(471, 306);
            this.ResultStandardDeviation.Name = "ResultStandardDeviation";
            this.ResultStandardDeviation.Size = new System.Drawing.Size(10, 13);
            this.ResultStandardDeviation.TabIndex = 68;
            this.ResultStandardDeviation.Text = "-";
            this.ResultStandardDeviation.Click += new System.EventHandler(this.ResultStandardDeviation_Click);
            // 
            // ResultCoefficientOfStandardDeviation
            // 
            this.ResultCoefficientOfStandardDeviation.AutoSize = true;
            this.ResultCoefficientOfStandardDeviation.Location = new System.Drawing.Point(471, 319);
            this.ResultCoefficientOfStandardDeviation.Name = "ResultCoefficientOfStandardDeviation";
            this.ResultCoefficientOfStandardDeviation.Size = new System.Drawing.Size(10, 13);
            this.ResultCoefficientOfStandardDeviation.TabIndex = 67;
            this.ResultCoefficientOfStandardDeviation.Text = "-";
            this.ResultCoefficientOfStandardDeviation.Click += new System.EventHandler(this.ResultCoefficientOfStandardDeviation_Click);
            // 
            // ResultVariance
            // 
            this.ResultVariance.AutoSize = true;
            this.ResultVariance.Location = new System.Drawing.Point(471, 332);
            this.ResultVariance.Name = "ResultVariance";
            this.ResultVariance.Size = new System.Drawing.Size(10, 13);
            this.ResultVariance.TabIndex = 66;
            this.ResultVariance.Text = "-";
            this.ResultVariance.Click += new System.EventHandler(this.ResultVariance_Click);
            // 
            // ResultCoefficientOfVariance
            // 
            this.ResultCoefficientOfVariance.AutoSize = true;
            this.ResultCoefficientOfVariance.Location = new System.Drawing.Point(471, 345);
            this.ResultCoefficientOfVariance.Name = "ResultCoefficientOfVariance";
            this.ResultCoefficientOfVariance.Size = new System.Drawing.Size(10, 13);
            this.ResultCoefficientOfVariance.TabIndex = 65;
            this.ResultCoefficientOfVariance.Text = "-";
            this.ResultCoefficientOfVariance.Click += new System.EventHandler(this.ResultCoefficientOfVariance_Click);
            // 
            // ResultCoefficientOfMeanDeviationFromMean
            // 
            this.ResultCoefficientOfMeanDeviationFromMean.AutoSize = true;
            this.ResultCoefficientOfMeanDeviationFromMean.Location = new System.Drawing.Point(471, 242);
            this.ResultCoefficientOfMeanDeviationFromMean.Name = "ResultCoefficientOfMeanDeviationFromMean";
            this.ResultCoefficientOfMeanDeviationFromMean.Size = new System.Drawing.Size(10, 13);
            this.ResultCoefficientOfMeanDeviationFromMean.TabIndex = 64;
            this.ResultCoefficientOfMeanDeviationFromMean.Text = "-";
            this.ResultCoefficientOfMeanDeviationFromMean.Click += new System.EventHandler(this.ResultCoefficientOfMeanDeviationFromMean_Click);
            // 
            // ResultMeanDeviationFromMean
            // 
            this.ResultMeanDeviationFromMean.AutoSize = true;
            this.ResultMeanDeviationFromMean.Location = new System.Drawing.Point(471, 229);
            this.ResultMeanDeviationFromMean.Name = "ResultMeanDeviationFromMean";
            this.ResultMeanDeviationFromMean.Size = new System.Drawing.Size(10, 13);
            this.ResultMeanDeviationFromMean.TabIndex = 63;
            this.ResultMeanDeviationFromMean.Text = "-";
            this.ResultMeanDeviationFromMean.Click += new System.EventHandler(this.ResultMeanDeviationFromMean_Click);
            // 
            // ResultUpperQuartile
            // 
            this.ResultUpperQuartile.AutoSize = true;
            this.ResultUpperQuartile.Location = new System.Drawing.Point(471, 150);
            this.ResultUpperQuartile.Name = "ResultUpperQuartile";
            this.ResultUpperQuartile.Size = new System.Drawing.Size(10, 13);
            this.ResultUpperQuartile.TabIndex = 60;
            this.ResultUpperQuartile.Text = "-";
            this.ResultUpperQuartile.Click += new System.EventHandler(this.ResultUpperQuartile_Click);
            // 
            // ResultLowerQuartile
            // 
            this.ResultLowerQuartile.AutoSize = true;
            this.ResultLowerQuartile.Location = new System.Drawing.Point(471, 137);
            this.ResultLowerQuartile.Name = "ResultLowerQuartile";
            this.ResultLowerQuartile.Size = new System.Drawing.Size(10, 13);
            this.ResultLowerQuartile.TabIndex = 59;
            this.ResultLowerQuartile.Text = "-";
            this.ResultLowerQuartile.Click += new System.EventHandler(this.ResultLowerQuartile_Click);
            // 
            // ResultMode
            // 
            this.ResultMode.AutoSize = true;
            this.ResultMode.Location = new System.Drawing.Point(471, 113);
            this.ResultMode.Name = "ResultMode";
            this.ResultMode.Size = new System.Drawing.Size(10, 13);
            this.ResultMode.TabIndex = 71;
            this.ResultMode.Text = "-";
            this.ResultMode.Click += new System.EventHandler(this.ResultMode_Click);
            // 
            // ResultMedian
            // 
            this.ResultMedian.AutoSize = true;
            this.ResultMedian.Location = new System.Drawing.Point(471, 100);
            this.ResultMedian.Name = "ResultMedian";
            this.ResultMedian.Size = new System.Drawing.Size(10, 13);
            this.ResultMedian.TabIndex = 58;
            this.ResultMedian.Text = "-";
            this.ResultMedian.Click += new System.EventHandler(this.ResultMedian_Click);
            // 
            // ResultMean
            // 
            this.ResultMean.AutoSize = true;
            this.ResultMean.Location = new System.Drawing.Point(471, 87);
            this.ResultMean.Name = "ResultMean";
            this.ResultMean.Size = new System.Drawing.Size(10, 13);
            this.ResultMean.TabIndex = 57;
            this.ResultMean.Text = "-";
            this.ResultMean.Click += new System.EventHandler(this.ResultMean_Click);
            // 
            // LabelVarianceCoefficient
            // 
            this.LabelVarianceCoefficient.AutoSize = true;
            this.LabelVarianceCoefficient.Location = new System.Drawing.Point(348, 345);
            this.LabelVarianceCoefficient.Name = "LabelVarianceCoefficient";
            this.LabelVarianceCoefficient.Size = new System.Drawing.Size(117, 13);
            this.LabelVarianceCoefficient.TabIndex = 55;
            this.LabelVarianceCoefficient.Text = "Coefficient of Variance:";
            // 
            // LabelVariance
            // 
            this.LabelVariance.AutoSize = true;
            this.LabelVariance.Location = new System.Drawing.Point(413, 332);
            this.LabelVariance.Name = "LabelVariance";
            this.LabelVariance.Size = new System.Drawing.Size(52, 13);
            this.LabelVariance.TabIndex = 54;
            this.LabelVariance.Text = "Variance:";
            // 
            // LabelStandardDeviationCoefficient
            // 
            this.LabelStandardDeviationCoefficient.AutoSize = true;
            this.LabelStandardDeviationCoefficient.Location = new System.Drawing.Point(369, 319);
            this.LabelStandardDeviationCoefficient.Name = "LabelStandardDeviationCoefficient";
            this.LabelStandardDeviationCoefficient.Size = new System.Drawing.Size(96, 13);
            this.LabelStandardDeviationCoefficient.TabIndex = 53;
            this.LabelStandardDeviationCoefficient.Text = "Coefficient of S.D.:";
            // 
            // LabelStandardDeviation
            // 
            this.LabelStandardDeviation.AutoSize = true;
            this.LabelStandardDeviation.Location = new System.Drawing.Point(364, 306);
            this.LabelStandardDeviation.Name = "LabelStandardDeviation";
            this.LabelStandardDeviation.Size = new System.Drawing.Size(101, 13);
            this.LabelStandardDeviation.TabIndex = 52;
            this.LabelStandardDeviation.Text = "Standard Deviation:";
            // 
            // LabelMDMedianCoefficient
            // 
            this.LabelMDMedianCoefficient.AutoSize = true;
            this.LabelMDMedianCoefficient.Location = new System.Drawing.Point(306, 279);
            this.LabelMDMedianCoefficient.Name = "LabelMDMedianCoefficient";
            this.LabelMDMedianCoefficient.Size = new System.Drawing.Size(159, 13);
            this.LabelMDMedianCoefficient.TabIndex = 51;
            this.LabelMDMedianCoefficient.Text = "Coefficient of M.D. from Median:";
            // 
            // LabelMDMedian
            // 
            this.LabelMDMedian.AutoSize = true;
            this.LabelMDMedian.Location = new System.Drawing.Point(319, 266);
            this.LabelMDMedian.Name = "LabelMDMedian";
            this.LabelMDMedian.Size = new System.Drawing.Size(146, 13);
            this.LabelMDMedian.TabIndex = 50;
            this.LabelMDMedian.Text = "Mean Deviation from Median:";
            // 
            // LabelMDMeanCoefficient
            // 
            this.LabelMDMeanCoefficient.AutoSize = true;
            this.LabelMDMeanCoefficient.Location = new System.Drawing.Point(314, 242);
            this.LabelMDMeanCoefficient.Name = "LabelMDMeanCoefficient";
            this.LabelMDMeanCoefficient.Size = new System.Drawing.Size(151, 13);
            this.LabelMDMeanCoefficient.TabIndex = 49;
            this.LabelMDMeanCoefficient.Text = "Coefficient of M.D. from Mean:";
            // 
            // LabelMDMean
            // 
            this.LabelMDMean.AutoSize = true;
            this.LabelMDMean.Location = new System.Drawing.Point(327, 229);
            this.LabelMDMean.Name = "LabelMDMean";
            this.LabelMDMean.Size = new System.Drawing.Size(138, 13);
            this.LabelMDMean.TabIndex = 48;
            this.LabelMDMean.Text = "Mean Deviation from Mean:";
            // 
            // LabelThirdQuartile
            // 
            this.LabelThirdQuartile.AutoSize = true;
            this.LabelThirdQuartile.Location = new System.Drawing.Point(392, 150);
            this.LabelThirdQuartile.Name = "LabelThirdQuartile";
            this.LabelThirdQuartile.Size = new System.Drawing.Size(73, 13);
            this.LabelThirdQuartile.TabIndex = 45;
            this.LabelThirdQuartile.Text = "Third Quartile:";
            // 
            // LabelFirstQuartile
            // 
            this.LabelFirstQuartile.AutoSize = true;
            this.LabelFirstQuartile.Location = new System.Drawing.Point(397, 137);
            this.LabelFirstQuartile.Name = "LabelFirstQuartile";
            this.LabelFirstQuartile.Size = new System.Drawing.Size(68, 13);
            this.LabelFirstQuartile.TabIndex = 44;
            this.LabelFirstQuartile.Text = "First Quartile:";
            // 
            // LabelMode
            // 
            this.LabelMode.AutoSize = true;
            this.LabelMode.Location = new System.Drawing.Point(428, 113);
            this.LabelMode.Name = "LabelMode";
            this.LabelMode.Size = new System.Drawing.Size(37, 13);
            this.LabelMode.TabIndex = 43;
            this.LabelMode.Text = "Mode:";
            // 
            // LabelMedian
            // 
            this.LabelMedian.AutoSize = true;
            this.LabelMedian.Location = new System.Drawing.Point(420, 100);
            this.LabelMedian.Name = "LabelMedian";
            this.LabelMedian.Size = new System.Drawing.Size(45, 13);
            this.LabelMedian.TabIndex = 56;
            this.LabelMedian.Text = "Median:";
            // 
            // LabelMean
            // 
            this.LabelMean.AutoSize = true;
            this.LabelMean.Location = new System.Drawing.Point(428, 87);
            this.LabelMean.Name = "LabelMean";
            this.LabelMean.Size = new System.Drawing.Size(37, 13);
            this.LabelMean.TabIndex = 42;
            this.LabelMean.Text = "Mean:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(302, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(440, 42);
            this.labelTitle.TabIndex = 74;
            this.labelTitle.Text = "Continuous Series Result";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(294, 415);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 22);
            this.CalcButton.TabIndex = 75;
            this.CalcButton.Text = "Refresh";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // IQRlabel
            // 
            this.IQRlabel.AutoSize = true;
            this.IQRlabel.Location = new System.Drawing.Point(360, 173);
            this.IQRlabel.Name = "IQRlabel";
            this.IQRlabel.Size = new System.Drawing.Size(105, 13);
            this.IQRlabel.TabIndex = 76;
            this.IQRlabel.Text = "Inter Quartile Range:";
            this.IQRlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // QDlabel
            // 
            this.QDlabel.AutoSize = true;
            this.QDlabel.Location = new System.Drawing.Point(371, 186);
            this.QDlabel.Name = "QDlabel";
            this.QDlabel.Size = new System.Drawing.Size(94, 13);
            this.QDlabel.TabIndex = 77;
            this.QDlabel.Text = "Quartile Deviation:";
            this.QDlabel.Click += new System.EventHandler(this.QDlabel_Click);
            // 
            // qdclabel
            // 
            this.qdclabel.AutoSize = true;
            this.qdclabel.Location = new System.Drawing.Point(306, 199);
            this.qdclabel.Name = "qdclabel";
            this.qdclabel.Size = new System.Drawing.Size(159, 13);
            this.qdclabel.TabIndex = 78;
            this.qdclabel.Text = "Coefficient of Quartile Deviation:";
            // 
            // ResultInterQuartileRange
            // 
            this.ResultInterQuartileRange.AutoSize = true;
            this.ResultInterQuartileRange.Location = new System.Drawing.Point(471, 173);
            this.ResultInterQuartileRange.Name = "ResultInterQuartileRange";
            this.ResultInterQuartileRange.Size = new System.Drawing.Size(10, 13);
            this.ResultInterQuartileRange.TabIndex = 79;
            this.ResultInterQuartileRange.Text = "-";
            this.ResultInterQuartileRange.Click += new System.EventHandler(this.ResultInterQuartileRange_Click);
            // 
            // ResultQuartileDeviation
            // 
            this.ResultQuartileDeviation.AutoSize = true;
            this.ResultQuartileDeviation.Location = new System.Drawing.Point(471, 186);
            this.ResultQuartileDeviation.Name = "ResultQuartileDeviation";
            this.ResultQuartileDeviation.Size = new System.Drawing.Size(10, 13);
            this.ResultQuartileDeviation.TabIndex = 80;
            this.ResultQuartileDeviation.Text = "-";
            this.ResultQuartileDeviation.Click += new System.EventHandler(this.ResultQuartileDeviation_Click);
            // 
            // ResultCoefficientQD
            // 
            this.ResultCoefficientQD.AutoSize = true;
            this.ResultCoefficientQD.Location = new System.Drawing.Point(471, 199);
            this.ResultCoefficientQD.Name = "ResultCoefficientQD";
            this.ResultCoefficientQD.Size = new System.Drawing.Size(10, 13);
            this.ResultCoefficientQD.TabIndex = 81;
            this.ResultCoefficientQD.Text = "-";
            this.ResultCoefficientQD.Click += new System.EventHandler(this.ResultCoefficientQD_Click);
            // 
            // FormContinuous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultCoefficientQD);
            this.Controls.Add(this.ResultQuartileDeviation);
            this.Controls.Add(this.ResultInterQuartileRange);
            this.Controls.Add(this.qdclabel);
            this.Controls.Add(this.QDlabel);
            this.Controls.Add(this.IQRlabel);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.ResultDataCount);
            this.Controls.Add(this.labelTotalNum);
            this.Controls.Add(this.ResultMeanDeviationFromMedian);
            this.Controls.Add(this.ResultCoefficientOfMeanDeviationFromMedian);
            this.Controls.Add(this.ResultStandardDeviation);
            this.Controls.Add(this.ResultCoefficientOfStandardDeviation);
            this.Controls.Add(this.ResultVariance);
            this.Controls.Add(this.ResultCoefficientOfVariance);
            this.Controls.Add(this.ResultCoefficientOfMeanDeviationFromMean);
            this.Controls.Add(this.ResultMeanDeviationFromMean);
            this.Controls.Add(this.ResultUpperQuartile);
            this.Controls.Add(this.ResultLowerQuartile);
            this.Controls.Add(this.ResultMode);
            this.Controls.Add(this.ResultMedian);
            this.Controls.Add(this.ResultMean);
            this.Controls.Add(this.LabelVarianceCoefficient);
            this.Controls.Add(this.LabelVariance);
            this.Controls.Add(this.LabelStandardDeviationCoefficient);
            this.Controls.Add(this.LabelStandardDeviation);
            this.Controls.Add(this.LabelMDMedianCoefficient);
            this.Controls.Add(this.LabelMDMedian);
            this.Controls.Add(this.LabelMDMeanCoefficient);
            this.Controls.Add(this.LabelMDMean);
            this.Controls.Add(this.LabelThirdQuartile);
            this.Controls.Add(this.LabelFirstQuartile);
            this.Controls.Add(this.LabelMode);
            this.Controls.Add(this.LabelMedian);
            this.Controls.Add(this.LabelMean);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormContinuous";
            this.Text = "Continuous Series";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormContinuous_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.Label ResultDataCount;
        private System.Windows.Forms.Label labelTotalNum;
        private System.Windows.Forms.Label ResultMeanDeviationFromMedian;
        private System.Windows.Forms.Label ResultCoefficientOfMeanDeviationFromMedian;
        private System.Windows.Forms.Label ResultStandardDeviation;
        private System.Windows.Forms.Label ResultCoefficientOfStandardDeviation;
        private System.Windows.Forms.Label ResultVariance;
        private System.Windows.Forms.Label ResultCoefficientOfVariance;
        private System.Windows.Forms.Label ResultCoefficientOfMeanDeviationFromMean;
        private System.Windows.Forms.Label ResultMeanDeviationFromMean;
        private System.Windows.Forms.Label ResultUpperQuartile;
        private System.Windows.Forms.Label ResultLowerQuartile;
        private System.Windows.Forms.Label ResultMode;
        private System.Windows.Forms.Label ResultMedian;
        private System.Windows.Forms.Label ResultMean;
        private System.Windows.Forms.Label LabelVarianceCoefficient;
        private System.Windows.Forms.Label LabelVariance;
        private System.Windows.Forms.Label LabelStandardDeviationCoefficient;
        private System.Windows.Forms.Label LabelStandardDeviation;
        private System.Windows.Forms.Label LabelMDMedianCoefficient;
        private System.Windows.Forms.Label LabelMDMedian;
        private System.Windows.Forms.Label LabelMDMeanCoefficient;
        private System.Windows.Forms.Label LabelMDMean;
        private System.Windows.Forms.Label LabelThirdQuartile;
        private System.Windows.Forms.Label LabelFirstQuartile;
        private System.Windows.Forms.Label LabelMode;
        private System.Windows.Forms.Label LabelMedian;
        private System.Windows.Forms.Label LabelMean;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label IQRlabel;
        private System.Windows.Forms.Label QDlabel;
        private System.Windows.Forms.Label qdclabel;
        private System.Windows.Forms.Label ResultInterQuartileRange;
        private System.Windows.Forms.Label ResultQuartileDeviation;
        private System.Windows.Forms.Label ResultCoefficientQD;
    }
}