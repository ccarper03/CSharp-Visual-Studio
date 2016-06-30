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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sqBtn_Click(object sender, EventArgs e)
        {
            double sqNum = 0.0;
            double total = 0.0;

            sqNum = Convert.ToDouble(squareTextBox.Text);
            total = sqNum * sqNum;
            sqDisplayLabel.Text = sqNum + " squared is " + total.ToString("N3");
            squareTextBox.Focus();
            squareTextBox.SelectAll();
        }

        private void squareTextBox_TextChanged(object sender, EventArgs e)
        {
            sqDisplayLabel.Text = string.Empty;
        }         
  }
}
