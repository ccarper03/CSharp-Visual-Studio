﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamGUI
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void diffBtn_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(inputTextBox1.Text);
            double input2 = Convert.ToDouble(inputTextBox2.Text);
            double total;

            total = input - input2;

            diffDisplayLabel.Text = input + " subtracted is " + total.ToString("N3");

            inputTextBox1.Focus();
            inputTextBox1.SelectAll();
            inputTextBox2.Focus();
            inputTextBox2.SelectAll();
        }

        private void inputTextBox1_TextChanged(object sender, EventArgs e)
        {
            diffDisplayLabel.Text = string.Empty;
        }
    }
}
