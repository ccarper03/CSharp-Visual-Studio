// Charles Carper  
// 3.26.2015
// Chapter 11 – Programming Exercise 3
// Find the square root of a number

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindSquareRootGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //terminate Application
            Close();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            double answerSqrt = 0.0;
            int num = 0;
            try
            {
                if (int.TryParse(inputTextBox.Text,out num)) //parse and see if number is an int
                {
                    // call squareroot pass num and display answer
                    answerSqrt = Math.Sqrt(num);
                    num = Convert.ToInt32(inputTextBox.Text);
                    displayLabel.Text = "The square root of " + num + " is " + answerSqrt.ToString("N4");
                    inputTextBox.Focus();
                    inputTextBox.SelectAll();
                }
                else
                {
                    // if not an int type
                    displayLabel.Text="Value entered is not a type int variable";
                    inputTextBox.Focus();
                    inputTextBox.SelectAll();
                    
                }

                if(num < 0 ) //check if the number is a negative number
                {
                    //throw the a new ApplicationException to which you pass the message shown
                    throw(new ApplicationException ("Value entered can't be negative."));
                } 
            }

            catch (ApplicationException errorMsg)
            {
                //display the error message in the label
                displayLabel.Text=String.Format(errorMsg.Message);
                inputTextBox.Focus();
                inputTextBox.SelectAll();
            }
        }
    }
}
    

