// Charles Carper
// 3.31.15
// MyTunesGUI
// Chapter 12 – Programming Exercise 4
// Select and purchase songs from a list box

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTunesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //terminate Application
            Close();
        }

        private void itemListBox_Click(object sender, EventArgs e)
        {
            //Declare Variables
            string                      thriller,rocket,atomic,highway,bad,born,god,beast;
            int count                 = itemListBox.SelectedItems.Count;
            const double price        = .99;
            double total              = 0.0;

            // clear if zero selections
            if (count == 0)
            {
                displayLabel.Text = string.Empty;
            }

            // Print message if one selected and print the price of one download
            if (count == 1)
            {
                displayLabel.Text = count + " song selected - Download cost is $" + price;
            }

            // calculates total by multiplaying the price by the count and will display number of songs selected and make "songs" plural 
            // and will display the total to the user.
            if (count >= 2)
            {
                total = count * price;
                displayLabel.Text = count + " songs selected - Download cost is $" + total;
            }
        }
    }
}
