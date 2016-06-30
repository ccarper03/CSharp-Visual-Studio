using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sqBtn_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(sumTextBox1.Text);
            double input2 = Convert.ToDouble(sumTextBox2.Text);
            double total;

            total = input + input2;

            sumDisplayLabel.Text = input + " summed is " + total.ToString("N3");

            sumTextBox1.Focus();
            sumTextBox1.SelectAll();
            sumTextBox2.Focus();
            sumTextBox2.SelectAll();
        }

        private void sumTextBox1_TextChanged(object sender, EventArgs e)
        {
            sumDisplayLabel.Text = string.Empty;
        }
    }
}
