namespace StatisticsCalc
{
    partial class FormDiscrete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiscrete));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrequencyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultMD2 = new System.Windows.Forms.Label();
            this.ResultMDC2 = new System.Windows.Forms.Label();
            this.ResultSD = new System.Windows.Forms.Label();
            this.ResultSDC = new System.Windows.Forms.Label();
            this.ResultVar = new System.Windows.Forms.Label();
            this.ResultVarC = new System.Windows.Forms.Label();
            this.ResultMDC1 = new System.Windows.Forms.Label();
            this.ResultMD1 = new System.Windows.Forms.Label();
            this.ResultMax = new System.Windows.Forms.Label();
            this.ResultMin = new System.Windows.Forms.Label();
            this.ResultQ3 = new System.Windows.Forms.Label();
            this.ResultQ1 = new System.Windows.Forms.Label();
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
            this.LabelMaximum = new System.Windows.Forms.Label();
            this.LabelMinimum = new System.Windows.Forms.Label();
            this.Label3Quartile = new System.Windows.Forms.Label();
            this.Label1Quartile = new System.Windows.Forms.Label();
            this.LabelMode = new System.Windows.Forms.Label();
            this.LabelMedian = new System.Windows.Forms.Label();
            this.LabelMean = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.labelTotalNum = new System.Windows.Forms.Label();
            this.ResultN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Main menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataColumn,
            this.FrequencyColumn});
            this.dataGridView1.Location = new System.Drawing.Point(9, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 428);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // DataColumn
            // 
            this.DataColumn.HeaderText = "Data (x)";
            this.DataColumn.Name = "DataColumn";
            // 
            // FrequencyColumn
            // 
            this.FrequencyColumn.HeaderText = "Frequency (f)";
            this.FrequencyColumn.Name = "FrequencyColumn";
            // 
            // ResultMD2
            // 
            this.ResultMD2.AutoSize = true;
            this.ResultMD2.Location = new System.Drawing.Point(503, 233);
            this.ResultMD2.Name = "ResultMD2";
            this.ResultMD2.Size = new System.Drawing.Size(10, 13);
            this.ResultMD2.TabIndex = 36;
            this.ResultMD2.Text = "-";
            this.ResultMD2.Click += new System.EventHandler(this.ResultMD2_Click);
            // 
            // ResultMDC2
            // 
            this.ResultMDC2.AutoSize = true;
            this.ResultMDC2.Location = new System.Drawing.Point(503, 246);
            this.ResultMDC2.Name = "ResultMDC2";
            this.ResultMDC2.Size = new System.Drawing.Size(10, 13);
            this.ResultMDC2.TabIndex = 35;
            this.ResultMDC2.Text = "-";
            this.ResultMDC2.Click += new System.EventHandler(this.ResultMDC2_Click);
            // 
            // ResultSD
            // 
            this.ResultSD.AutoSize = true;
            this.ResultSD.Location = new System.Drawing.Point(503, 273);
            this.ResultSD.Name = "ResultSD";
            this.ResultSD.Size = new System.Drawing.Size(10, 13);
            this.ResultSD.TabIndex = 34;
            this.ResultSD.Text = "-";
            this.ResultSD.Click += new System.EventHandler(this.ResultSD_Click);
            // 
            // ResultSDC
            // 
            this.ResultSDC.AutoSize = true;
            this.ResultSDC.Location = new System.Drawing.Point(503, 286);
            this.ResultSDC.Name = "ResultSDC";
            this.ResultSDC.Size = new System.Drawing.Size(10, 13);
            this.ResultSDC.TabIndex = 33;
            this.ResultSDC.Text = "-";
            this.ResultSDC.Click += new System.EventHandler(this.ResultSDC_Click);
            // 
            // ResultVar
            // 
            this.ResultVar.AutoSize = true;
            this.ResultVar.Location = new System.Drawing.Point(503, 299);
            this.ResultVar.Name = "ResultVar";
            this.ResultVar.Size = new System.Drawing.Size(10, 13);
            this.ResultVar.TabIndex = 32;
            this.ResultVar.Text = "-";
            this.ResultVar.Click += new System.EventHandler(this.ResultVar_Click);
            // 
            // ResultVarC
            // 
            this.ResultVarC.AutoSize = true;
            this.ResultVarC.Location = new System.Drawing.Point(503, 312);
            this.ResultVarC.Name = "ResultVarC";
            this.ResultVarC.Size = new System.Drawing.Size(10, 13);
            this.ResultVarC.TabIndex = 30;
            this.ResultVarC.Text = "-";
            this.ResultVarC.Click += new System.EventHandler(this.ResultVarC_Click);
            // 
            // ResultMDC1
            // 
            this.ResultMDC1.AutoSize = true;
            this.ResultMDC1.Location = new System.Drawing.Point(503, 209);
            this.ResultMDC1.Name = "ResultMDC1";
            this.ResultMDC1.Size = new System.Drawing.Size(10, 13);
            this.ResultMDC1.TabIndex = 29;
            this.ResultMDC1.Text = "-";
            this.ResultMDC1.Click += new System.EventHandler(this.ResultMDC1_Click);
            // 
            // ResultMD1
            // 
            this.ResultMD1.AutoSize = true;
            this.ResultMD1.Location = new System.Drawing.Point(503, 196);
            this.ResultMD1.Name = "ResultMD1";
            this.ResultMD1.Size = new System.Drawing.Size(10, 13);
            this.ResultMD1.TabIndex = 28;
            this.ResultMD1.Text = "-";
            this.ResultMD1.Click += new System.EventHandler(this.ResultMD1_Click);
            // 
            // ResultMax
            // 
            this.ResultMax.AutoSize = true;
            this.ResultMax.Location = new System.Drawing.Point(503, 172);
            this.ResultMax.Name = "ResultMax";
            this.ResultMax.Size = new System.Drawing.Size(10, 13);
            this.ResultMax.TabIndex = 27;
            this.ResultMax.Text = "-";
            this.ResultMax.Click += new System.EventHandler(this.ResultMax_Click);
            // 
            // ResultMin
            // 
            this.ResultMin.AutoSize = true;
            this.ResultMin.Location = new System.Drawing.Point(503, 159);
            this.ResultMin.Name = "ResultMin";
            this.ResultMin.Size = new System.Drawing.Size(10, 13);
            this.ResultMin.TabIndex = 26;
            this.ResultMin.Text = "-";
            this.ResultMin.Click += new System.EventHandler(this.ResultMin_Click);
            // 
            // ResultQ3
            // 
            this.ResultQ3.AutoSize = true;
            this.ResultQ3.Location = new System.Drawing.Point(503, 135);
            this.ResultQ3.Name = "ResultQ3";
            this.ResultQ3.Size = new System.Drawing.Size(10, 13);
            this.ResultQ3.TabIndex = 25;
            this.ResultQ3.Text = "-";
            this.ResultQ3.Click += new System.EventHandler(this.ResultQ3_Click);
            // 
            // ResultQ1
            // 
            this.ResultQ1.AutoSize = true;
            this.ResultQ1.Location = new System.Drawing.Point(503, 122);
            this.ResultQ1.Name = "ResultQ1";
            this.ResultQ1.Size = new System.Drawing.Size(10, 13);
            this.ResultQ1.TabIndex = 24;
            this.ResultQ1.Text = "-";
            this.ResultQ1.Click += new System.EventHandler(this.ResultQ1_Click);
            // 
            // ResultMode
            // 
            this.ResultMode.AutoSize = true;
            this.ResultMode.Location = new System.Drawing.Point(503, 98);
            this.ResultMode.Name = "ResultMode";
            this.ResultMode.Size = new System.Drawing.Size(10, 13);
            this.ResultMode.TabIndex = 37;
            this.ResultMode.Text = "-";
            this.ResultMode.Click += new System.EventHandler(this.ResultMode_Click);
            // 
            // ResultMedian
            // 
            this.ResultMedian.AutoSize = true;
            this.ResultMedian.Location = new System.Drawing.Point(503, 85);
            this.ResultMedian.Name = "ResultMedian";
            this.ResultMedian.Size = new System.Drawing.Size(10, 13);
            this.ResultMedian.TabIndex = 23;
            this.ResultMedian.Text = "-";
            this.ResultMedian.Click += new System.EventHandler(this.ResultMedian_Click);
            // 
            // ResultMean
            // 
            this.ResultMean.AutoSize = true;
            this.ResultMean.Location = new System.Drawing.Point(503, 72);
            this.ResultMean.Name = "ResultMean";
            this.ResultMean.Size = new System.Drawing.Size(10, 13);
            this.ResultMean.TabIndex = 22;
            this.ResultMean.Text = "-";
            this.ResultMean.Click += new System.EventHandler(this.ResultMean_Click);
            // 
            // LabelVarianceCoefficient
            // 
            this.LabelVarianceCoefficient.AutoSize = true;
            this.LabelVarianceCoefficient.Location = new System.Drawing.Point(380, 312);
            this.LabelVarianceCoefficient.Name = "LabelVarianceCoefficient";
            this.LabelVarianceCoefficient.Size = new System.Drawing.Size(117, 13);
            this.LabelVarianceCoefficient.TabIndex = 20;
            this.LabelVarianceCoefficient.Text = "Coefficient of Variance:";
            // 
            // LabelVariance
            // 
            this.LabelVariance.AutoSize = true;
            this.LabelVariance.Location = new System.Drawing.Point(445, 299);
            this.LabelVariance.Name = "LabelVariance";
            this.LabelVariance.Size = new System.Drawing.Size(52, 13);
            this.LabelVariance.TabIndex = 19;
            this.LabelVariance.Text = "Variance:";
            // 
            // LabelStandardDeviationCoefficient
            // 
            this.LabelStandardDeviationCoefficient.AutoSize = true;
            this.LabelStandardDeviationCoefficient.Location = new System.Drawing.Point(401, 286);
            this.LabelStandardDeviationCoefficient.Name = "LabelStandardDeviationCoefficient";
            this.LabelStandardDeviationCoefficient.Size = new System.Drawing.Size(96, 13);
            this.LabelStandardDeviationCoefficient.TabIndex = 18;
            this.LabelStandardDeviationCoefficient.Text = "Coefficient of S.D.:";
            // 
            // LabelStandardDeviation
            // 
            this.LabelStandardDeviation.AutoSize = true;
            this.LabelStandardDeviation.Location = new System.Drawing.Point(396, 273);
            this.LabelStandardDeviation.Name = "LabelStandardDeviation";
            this.LabelStandardDeviation.Size = new System.Drawing.Size(101, 13);
            this.LabelStandardDeviation.TabIndex = 17;
            this.LabelStandardDeviation.Text = "Standard Deviation:";
            // 
            // LabelMDMedianCoefficient
            // 
            this.LabelMDMedianCoefficient.AutoSize = true;
            this.LabelMDMedianCoefficient.Location = new System.Drawing.Point(338, 246);
            this.LabelMDMedianCoefficient.Name = "LabelMDMedianCoefficient";
            this.LabelMDMedianCoefficient.Size = new System.Drawing.Size(159, 13);
            this.LabelMDMedianCoefficient.TabIndex = 16;
            this.LabelMDMedianCoefficient.Text = "Coefficient of M.D. from Median:";
            // 
            // LabelMDMedian
            // 
            this.LabelMDMedian.AutoSize = true;
            this.LabelMDMedian.Location = new System.Drawing.Point(351, 233);
            this.LabelMDMedian.Name = "LabelMDMedian";
            this.LabelMDMedian.Size = new System.Drawing.Size(146, 13);
            this.LabelMDMedian.TabIndex = 15;
            this.LabelMDMedian.Text = "Mean Deviation from Median:";
            // 
            // LabelMDMeanCoefficient
            // 
            this.LabelMDMeanCoefficient.AutoSize = true;
            this.LabelMDMeanCoefficient.Location = new System.Drawing.Point(346, 209);
            this.LabelMDMeanCoefficient.Name = "LabelMDMeanCoefficient";
            this.LabelMDMeanCoefficient.Size = new System.Drawing.Size(151, 13);
            this.LabelMDMeanCoefficient.TabIndex = 14;
            this.LabelMDMeanCoefficient.Text = "Coefficient of M.D. from Mean:";
            // 
            // LabelMDMean
            // 
            this.LabelMDMean.AutoSize = true;
            this.LabelMDMean.Location = new System.Drawing.Point(359, 196);
            this.LabelMDMean.Name = "LabelMDMean";
            this.LabelMDMean.Size = new System.Drawing.Size(138, 13);
            this.LabelMDMean.TabIndex = 13;
            this.LabelMDMean.Text = "Mean Deviation from Mean:";
            // 
            // LabelMaximum
            // 
            this.LabelMaximum.AutoSize = true;
            this.LabelMaximum.Location = new System.Drawing.Point(467, 172);
            this.LabelMaximum.Name = "LabelMaximum";
            this.LabelMaximum.Size = new System.Drawing.Size(30, 13);
            this.LabelMaximum.TabIndex = 12;
            this.LabelMaximum.Text = "Max:";
            // 
            // LabelMinimum
            // 
            this.LabelMinimum.AutoSize = true;
            this.LabelMinimum.Location = new System.Drawing.Point(470, 159);
            this.LabelMinimum.Name = "LabelMinimum";
            this.LabelMinimum.Size = new System.Drawing.Size(27, 13);
            this.LabelMinimum.TabIndex = 11;
            this.LabelMinimum.Text = "Min:";
            // 
            // Label3Quartile
            // 
            this.Label3Quartile.AutoSize = true;
            this.Label3Quartile.Location = new System.Drawing.Point(424, 135);
            this.Label3Quartile.Name = "Label3Quartile";
            this.Label3Quartile.Size = new System.Drawing.Size(73, 13);
            this.Label3Quartile.TabIndex = 10;
            this.Label3Quartile.Text = "Third Quartile:";
            // 
            // Label1Quartile
            // 
            this.Label1Quartile.AutoSize = true;
            this.Label1Quartile.Location = new System.Drawing.Point(429, 122);
            this.Label1Quartile.Name = "Label1Quartile";
            this.Label1Quartile.Size = new System.Drawing.Size(68, 13);
            this.Label1Quartile.TabIndex = 9;
            this.Label1Quartile.Text = "First Quartile:";
            // 
            // LabelMode
            // 
            this.LabelMode.AutoSize = true;
            this.LabelMode.Location = new System.Drawing.Point(460, 98);
            this.LabelMode.Name = "LabelMode";
            this.LabelMode.Size = new System.Drawing.Size(37, 13);
            this.LabelMode.TabIndex = 8;
            this.LabelMode.Text = "Mode:";
            // 
            // LabelMedian
            // 
            this.LabelMedian.AutoSize = true;
            this.LabelMedian.Location = new System.Drawing.Point(452, 85);
            this.LabelMedian.Name = "LabelMedian";
            this.LabelMedian.Size = new System.Drawing.Size(45, 13);
            this.LabelMedian.TabIndex = 21;
            this.LabelMedian.Text = "Median:";
            // 
            // LabelMean
            // 
            this.LabelMean.AutoSize = true;
            this.LabelMean.Location = new System.Drawing.Point(460, 72);
            this.LabelMean.Name = "LabelMean";
            this.LabelMean.Size = new System.Drawing.Size(37, 13);
            this.LabelMean.TabIndex = 7;
            this.LabelMean.Text = "Mean:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(318, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(387, 42);
            this.labelTitle.TabIndex = 38;
            this.labelTitle.Text = "Discrete Series Result";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(276, 406);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 39;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // labelTotalNum
            // 
            this.labelTotalNum.AutoSize = true;
            this.labelTotalNum.Location = new System.Drawing.Point(385, 339);
            this.labelTotalNum.Name = "labelTotalNum";
            this.labelTotalNum.Size = new System.Drawing.Size(112, 13);
            this.labelTotalNum.TabIndex = 40;
            this.labelTotalNum.Text = "Total Number of Data:";
            // 
            // ResultN
            // 
            this.ResultN.AutoSize = true;
            this.ResultN.Location = new System.Drawing.Point(503, 339);
            this.ResultN.Name = "ResultN";
            this.ResultN.Size = new System.Drawing.Size(10, 13);
            this.ResultN.TabIndex = 41;
            this.ResultN.Text = "-";
            this.ResultN.Click += new System.EventHandler(this.ResultN_Click);
            // 
            // FormDiscrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultN);
            this.Controls.Add(this.labelTotalNum);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.ResultMD2);
            this.Controls.Add(this.ResultMDC2);
            this.Controls.Add(this.ResultSD);
            this.Controls.Add(this.ResultSDC);
            this.Controls.Add(this.ResultVar);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDiscrete";
            this.Text = "Discrete Series";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDiscrete_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrequencyColumn;
        private System.Windows.Forms.Label ResultMD2;
        private System.Windows.Forms.Label ResultMDC2;
        private System.Windows.Forms.Label ResultSD;
        private System.Windows.Forms.Label ResultSDC;
        private System.Windows.Forms.Label ResultVar;
        private System.Windows.Forms.Label ResultVarC;
        private System.Windows.Forms.Label ResultMDC1;
        private System.Windows.Forms.Label ResultMD1;
        private System.Windows.Forms.Label ResultMax;
        private System.Windows.Forms.Label ResultMin;
        private System.Windows.Forms.Label ResultQ3;
        private System.Windows.Forms.Label ResultQ1;
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
        private System.Windows.Forms.Label LabelMaximum;
        private System.Windows.Forms.Label LabelMinimum;
        private System.Windows.Forms.Label Label3Quartile;
        private System.Windows.Forms.Label Label1Quartile;
        private System.Windows.Forms.Label LabelMode;
        private System.Windows.Forms.Label LabelMedian;
        private System.Windows.Forms.Label LabelMean;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label labelTotalNum;
        private System.Windows.Forms.Label ResultN;
    }
}