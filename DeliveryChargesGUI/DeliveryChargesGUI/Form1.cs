/*
 *Charles Carper
 *2/12/15
 *DeliveryChargesGUI
 *Chapter 6 – Programming Exercise 5
 *Determine if zip code is in delivery area and display associated delivery charge
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryChargesGUI
{
    public partial class deliveryCharges : Form
    {
        public deliveryCharges()
        {
            InitializeComponent();
        }
        private void displayButton_Click(object sender, EventArgs e)
        {
            int z = 0;
            int x = Convert.ToInt32(zipCodeTextBox.Text);
            int [] validId = new int[10] {19947,19963,19950,19933,19973,19968,19971,19953,19974,19955};
            double[] charge = new double[10] { 2.40, 3.00, 3.50, 4.00, 4.50, 5.00, 5.25, 5.75, 6.10, 10.00 };
            double zipCharge = 0.0;
            bool isValidItem = false;

            while (z != validId.Length && x != validId[z])
            ++z;

            if (z != validId.Length)
            {
                isValidItem = true;
                zipCharge = charge[z];
            }

            if (isValidItem)
            {
                displayLabel.Text = "OK to Deliver to" + x.ToString() + ".\nCost of Delivery is " + zipCharge.ToString("C") + ".";
            }
            else 
            {
                displayLabel.Text = "Sorry - No Delivery to "+ x.ToString() + ".";
            }
            zipCodeTextBox.Focus();   // focuses on text
            zipCodeTextBox.SelectAll();   // highlights all text
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();    // Terminate
        }

        private void displayLabel_Click(object sender, EventArgs e)
        {
            displayLabel.Text = String.Empty;     
        }
    }
}

