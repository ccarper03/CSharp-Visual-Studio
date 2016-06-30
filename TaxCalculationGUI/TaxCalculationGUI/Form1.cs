// Charles Carper
// 3/10/15
// Chapter 8 – Programming Exercise 5
// Tax amount calculations

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculationGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void percTax(double price, double taxDouble)
        {
            double tax;
            tax = price * taxDouble;
            displayLabel.Text += String.Format("\n{0}% tax on {1} is {2}", taxDouble, price.ToString("C"), tax.ToString("C"));
        }

        private void percTax(double price, int taxInt)
        {
            double taxAsPct, tax;
            taxAsPct = taxInt / 100.0;
            tax = price * taxAsPct;
            displayLabel.Text += String.Format("{0}% tax on {1} is {2}", taxInt, price.ToString("C"), tax.ToString("C"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close(); // Terminate
        }
        private void calcButton_Click(object sender, EventArgs e)
        {
            double price = 0.0;
            double taxDouble = .06;
            int taxInt = 6;

            displayLabel.Text = String.Empty;
            price = Convert.ToDouble(priceTextBox.Text);
            percTax(price,taxInt);
            percTax(price,taxDouble);

            priceTextBox.Focus();
            priceTextBox.SelectAll();
        }
    }
}
