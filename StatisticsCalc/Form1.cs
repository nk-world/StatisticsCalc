﻿using System;
using System.Windows.Forms;

namespace StatisticsCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormIndividual formIndividual = new FormIndividual();
            formIndividual.Show();
            formIndividual.Owner = this;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDiscrete formDiscrete = new FormDiscrete();
            formDiscrete.Show();
            formDiscrete.Owner = this;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormContinuous formContinuous = new FormContinuous();
            formContinuous.Show();
            formContinuous.Owner = this;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/nk-world/StatisticsCalc/");
        }
    }
}
