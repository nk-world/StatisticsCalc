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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
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
            this.textBox1.Location = new System.Drawing.Point(12, 352);
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
            this.label1.Location = new System.Drawing.Point(17, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the data above, separate each of them using commas.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mean:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Median:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "First Quartile:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Third Quartile:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Min:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Max:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Mean Deviation from Mean:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Coefficient of M.D. from Mean:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(163, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Mean Deviation from Median:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(150, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Coefficient of M.D. from Median:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(208, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Standard Deviation:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(213, 276);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Coefficient of S.D.:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(257, 289);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Variance:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(192, 302);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Coefficient of Variance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label6.Location = new System.Drawing.Point(166, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 46);
            this.label6.TabIndex = 4;
            this.label6.Text = "Individual Series Result";
            // 
            // ResultMean
            // 
            this.ResultMean.AutoSize = true;
            this.ResultMean.Location = new System.Drawing.Point(315, 62);
            this.ResultMean.Name = "ResultMean";
            this.ResultMean.Size = new System.Drawing.Size(10, 13);
            this.ResultMean.TabIndex = 5;
            this.ResultMean.Text = "-";
            // 
            // ResultMedian
            // 
            this.ResultMedian.AutoSize = true;
            this.ResultMedian.Location = new System.Drawing.Point(315, 75);
            this.ResultMedian.Name = "ResultMedian";
            this.ResultMedian.Size = new System.Drawing.Size(10, 13);
            this.ResultMedian.TabIndex = 5;
            this.ResultMedian.Text = "-";
            // 
            // ResultMode
            // 
            this.ResultMode.AutoSize = true;
            this.ResultMode.Location = new System.Drawing.Point(315, 88);
            this.ResultMode.Name = "ResultMode";
            this.ResultMode.Size = new System.Drawing.Size(10, 13);
            this.ResultMode.TabIndex = 5;
            this.ResultMode.Text = "-";
            // 
            // ResultQ1
            // 
            this.ResultQ1.AutoSize = true;
            this.ResultQ1.Location = new System.Drawing.Point(315, 112);
            this.ResultQ1.Name = "ResultQ1";
            this.ResultQ1.Size = new System.Drawing.Size(10, 13);
            this.ResultQ1.TabIndex = 5;
            this.ResultQ1.Text = "-";
            // 
            // ResultQ3
            // 
            this.ResultQ3.AutoSize = true;
            this.ResultQ3.Location = new System.Drawing.Point(315, 125);
            this.ResultQ3.Name = "ResultQ3";
            this.ResultQ3.Size = new System.Drawing.Size(10, 13);
            this.ResultQ3.TabIndex = 5;
            this.ResultQ3.Text = "-";
            // 
            // ResultMin
            // 
            this.ResultMin.AutoSize = true;
            this.ResultMin.Location = new System.Drawing.Point(315, 149);
            this.ResultMin.Name = "ResultMin";
            this.ResultMin.Size = new System.Drawing.Size(10, 13);
            this.ResultMin.TabIndex = 5;
            this.ResultMin.Text = "-";
            // 
            // ResultMax
            // 
            this.ResultMax.AutoSize = true;
            this.ResultMax.Location = new System.Drawing.Point(315, 162);
            this.ResultMax.Name = "ResultMax";
            this.ResultMax.Size = new System.Drawing.Size(10, 13);
            this.ResultMax.TabIndex = 5;
            this.ResultMax.Text = "-";
            // 
            // ResultMD1
            // 
            this.ResultMD1.AutoSize = true;
            this.ResultMD1.Location = new System.Drawing.Point(315, 186);
            this.ResultMD1.Name = "ResultMD1";
            this.ResultMD1.Size = new System.Drawing.Size(10, 13);
            this.ResultMD1.TabIndex = 5;
            this.ResultMD1.Text = "-";
            // 
            // ResultMDC1
            // 
            this.ResultMDC1.AutoSize = true;
            this.ResultMDC1.Location = new System.Drawing.Point(315, 199);
            this.ResultMDC1.Name = "ResultMDC1";
            this.ResultMDC1.Size = new System.Drawing.Size(10, 13);
            this.ResultMDC1.TabIndex = 5;
            this.ResultMDC1.Text = "-";
            // 
            // ResultVarC
            // 
            this.ResultVarC.AutoSize = true;
            this.ResultVarC.Location = new System.Drawing.Point(315, 302);
            this.ResultVarC.Name = "ResultVarC";
            this.ResultVarC.Size = new System.Drawing.Size(10, 13);
            this.ResultVarC.TabIndex = 5;
            this.ResultVarC.Text = "-";
            // 
            // ResultVar
            // 
            this.ResultVar.AutoSize = true;
            this.ResultVar.Location = new System.Drawing.Point(315, 289);
            this.ResultVar.Name = "ResultVar";
            this.ResultVar.Size = new System.Drawing.Size(10, 13);
            this.ResultVar.TabIndex = 5;
            this.ResultVar.Text = "-";
            // 
            // ResultSDC
            // 
            this.ResultSDC.AutoSize = true;
            this.ResultSDC.Location = new System.Drawing.Point(315, 276);
            this.ResultSDC.Name = "ResultSDC";
            this.ResultSDC.Size = new System.Drawing.Size(10, 13);
            this.ResultSDC.TabIndex = 5;
            this.ResultSDC.Text = "-";
            // 
            // ResultSD
            // 
            this.ResultSD.AutoSize = true;
            this.ResultSD.Location = new System.Drawing.Point(315, 263);
            this.ResultSD.Name = "ResultSD";
            this.ResultSD.Size = new System.Drawing.Size(10, 13);
            this.ResultSD.TabIndex = 5;
            this.ResultSD.Text = "-";
            // 
            // ResultMDC2
            // 
            this.ResultMDC2.AutoSize = true;
            this.ResultMDC2.Location = new System.Drawing.Point(315, 236);
            this.ResultMDC2.Name = "ResultMDC2";
            this.ResultMDC2.Size = new System.Drawing.Size(10, 13);
            this.ResultMDC2.TabIndex = 5;
            this.ResultMDC2.Text = "-";
            // 
            // ResultMD2
            // 
            this.ResultMD2.AutoSize = true;
            this.ResultMD2.Location = new System.Drawing.Point(315, 223);
            this.ResultMD2.Name = "ResultMD2";
            this.ResultMD2.Size = new System.Drawing.Size(10, 13);
            this.ResultMD2.TabIndex = 5;
            this.ResultMD2.Text = "-";
            // 
            // FormIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
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
    }
}