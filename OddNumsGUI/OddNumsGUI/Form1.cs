using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OddNumsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            for (int num = 0; num <= 100; num++)
            {
                if (odd(num))
                {
                    displayLabel.Text += num.ToString() + " ";
                }
            }
        }
        public static bool odd(int value)
        {
            return value % 2 != 0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();    // Terminate
        }
       
    }
}
