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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cubeBtn_Click(object sender, EventArgs e)
        {
            double input;
            double cube;
            input = Convert.ToDouble(inputTextBox.Text);
            cube = input * input * input;
            cubeDisplayLabel.Text = input + " cubed is " + cube.ToString("N3");
            inputTextBox.Focus();
            inputTextBox.SelectAll();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            cubeDisplayLabel.Text = string.Empty;
        }
    }
}
