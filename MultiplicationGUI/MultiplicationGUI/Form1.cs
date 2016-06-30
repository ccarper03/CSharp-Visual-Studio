// Charles Carper
// 2.24.15
// Chapter 7 – Programming Exercise 6b
// Generate a multiplication table
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationGUI
{
    public partial class multiplicationTable : Form
    {
        void productTbl(int x)
        {
            int sum, y=2;
            for(int c = 1; c < 10; ++c)
            {
                sum = x * y;
                displayLabel.Text += x + " * " + y + " = " + sum + "\n";
                y++;
            }
        }

        public multiplicationTable()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close(); // Terminate
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            int input;
            input = Convert.ToInt32(inputTextBox.Text);
            productTbl(input); //call multiplying and printing function
            inputTextBox.Focus();
            inputTextBox.SelectAll();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            displayLabel.Text = String.Empty;
        }
    }
}
