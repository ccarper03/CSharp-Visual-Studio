// Charles Carper
// 2-19-15
// Chapter 7 – Programming Exercise 3b
// Calculate cost of vinyl siding 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidingEstimateGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static double areaCost(double length, double width, double yardCost)
        {
            // calculations
            double area = 0.0;
            double total = 0.0;
            area = length * width;
            return total = area * yardCost;
        }
        private void displayButton_Click(object sender, EventArgs e)
        {
            // declare variables
            double length = 0.0;
            double width = 0.0;
            double yardCost = 0.0;
            double total = 0.0;
           
            // assign variables
            length = Convert.ToDouble(lengthTextBox.Text);
            width = Convert.ToDouble(depthTextBox.Text);
            yardCost = Convert.ToDouble(yardCostTextBox2.Text);         
            
            // call method and store result in total
            total = areaCost(length,  width, yardCost);
            
            // display results
            displayLabel.Text = "Cost of Siding is $" + string.Format("{0:0,000.00}", total);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();      // Terminate
        }
    }
}
