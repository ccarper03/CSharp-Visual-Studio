using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableOfSquaresGUI
{
    public partial class tableOfSquares : Form
    {
        public tableOfSquares()
        {
            InitializeComponent();
        }
        private void displayButton_Click(object sender, EventArgs e)
        {
            for (int num = 1; num <= 20; num++)
            {
                int square = 0;
                square = num * num;
                displayLabel.Text += num.ToString() + " * " + num.ToString() + " = " + square.ToString() + "\n";
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();    // Terminate
        }
    }
}
