// Charles Carper
// 3.24.15
// Chapter 10 – Programming Exercise 1
// View invoice information

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceGUI
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
            //instantiates objects
            Invoice Company1 = new Invoice();
            Invoice Company2 = new Invoice();
            OverdueInvoice Company3 = new OverdueInvoice();

            //if else statements
            if (inputTextBox.Text == "ELECTRIC COMPANY")
            {
                // Company1 name
                Company1.Name = "ELECTRIC COMPANY";
                // Amount due
                Company1.Amount = 125.25;
                // Display to user
                displayLabel.Text = Company1.ToString();
            }
            else if (inputTextBox.Text == "MORTGAGE COMPANY")
            {
                // Company2 name
                Company2.Name = "MORTGAGE COMPANY";
                // Amount due
                Company2.Amount = 750.50;
                // Display to user
                displayLabel.Text = Company2.ToString();
            }
            else if (inputTextBox.Text == "WATER COMPANY")
            {
                // Company3 name
                Company3.Name = "WATER COMPANY";
                // Amount due
                Company3.Amount = 175.75;
                // Days overdue
                Company3.DaysOverdue = 60;
                // Display info
                displayLabel.Text = Company3.ToString() + "         Days Overdue:" + Company3.DaysOverdue;
            }
            else
            {
                //declare string variable
                String userInput = inputTextBox.Text;
                //display incorrect input
                displayLabel.Text = "\n" + userInput + " \nINVALID ENTRY - Please Try Again.";
            }

        }
        //child class - Days the invoice is overdue
        class OverdueInvoice : Invoice
        {
            public int DaysOverdue { get; set; }
        } 
    } 
}

