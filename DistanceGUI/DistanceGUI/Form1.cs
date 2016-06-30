

// Charles Carper
// 01.21.2015
// Chapter 3 - Programming Exercise 1
// Miles to feet conversion GUI

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close  the application
            Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // variable and constant declarations
            const int FEET_IN_MILES = 5280;
            double miles = 0.0;
            double feet = 0.0;

            // convert user input and assign to variable
            miles = Convert.ToDouble(milesTextBox.Text);

            // calculate distance in feet
            feet = miles * FEET_IN_MILES;

            // display calculated results to user
            feetLabel.Text = miles + " miles is " + feet + " feet.";

            // set focus to miles text box
            milesTextBox.Focus();

            // select all text in miles text box
            milesTextBox.SelectAll();
        }

       

        private void milesTextBox_TextChanged_1(object sender, EventArgs e)
        {
            // clear contents of feet label 
            feetLabel.Text = String.Empty;
        }
    }
}
