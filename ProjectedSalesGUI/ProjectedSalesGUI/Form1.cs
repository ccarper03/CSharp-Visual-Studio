using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedSalesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Terminate
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 
            const double INCREASE_PCT = .12;
            double northSales = 0.0;
            double southSales = 0.0;
            double projectedNorthSales = 0.0;
            double projectedSouthSales = 0.0;

            //
            northSales = Convert.ToDouble(northTextBox.Text);
            southSales = Convert.ToDouble(southTextBox.Text);

            //calculate projected north and south division sales
            projectedNorthSales = northSales + northSales * INCREASE_PCT;
            projectedSouthSales = southSales + southSales * INCREASE_PCT;

            //display results to user
            northLabel.Text = projectedNorthSales.ToString("C2");
            southLabel.Text = projectedSouthSales.ToString("C2");

            //set focus to north textbox
            northTextBox.Focus();

            // select all text in the north and south labels
            northTextBox.SelectAll();
            southTextBox.SelectAll();
        }

        private void northTextBox_TextChanged(object sender, EventArgs e)
        {
            // Clear contents of projected sales label
            northLabel.Text = String.Empty;
            southLabel.Text = String.Empty;
        }

        private void southTextBox_TextChanged(object sender, EventArgs e)
        {
            // Clear contents of projected sales label
            northLabel.Text = String.Empty;
            southLabel.Text = String.Empty;
        }
    }
}
