/* Charles Carper
 * 2/26/2015
 * Midterm Exam Application
 * Calculate the cost of a custom desk
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

namespace MidTermExamGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int getNumOfDrawers()
        {
            int x = Convert.ToInt32(numDrawersTextBox.Text); // get the number of drawers
            return x;
        }//end getNumOfDrawers
        private char getWoodType()
        {
            char x = Convert.ToChar(woodTypeTextBox.Text); // get input convert to char type assign to x

            if ((x ==  'p') ||(x == 'P')) 
            {
                return 'P'; // return capital P char type
            }   
            else if ((x == 'o') || (x == 'O'))
            {
                return 'O'; // return capital O char type
            }
            else if ((x == 'm') || (x == 'M'))
            {
                return 'P'; // return capital M char Type
            }
            else
            {
                return x;
            }
        }//end getWoodType
        private double calcCost(int q, char w)
        {
            const int s = 30;    // surcharge $30 per item
            const int p = 100;   // cost of pine
            const int O = 140;   // cost of Osk
            const int M = 180;   // cost of Mahogany
            double total = 0;

            // calculating total by multiplying quantity by the surcharge then adding the 
            // cost of the wood type
            if (w == 'P')
            {
                return total = (q * s) + p; 
            }else if (w == 'O')
            {
                return total = (q * s) + O; 
            }
            else if (w == 'M')
            {
                return total = (q * s) + M; 
            }
            else 
            {
                return total;
            }
        }//end calcCost
        //////////////////////////////////////////////////////////////////
        //displayInfo converts char to string of full name of wood type //
        //displays results to the user                                  //
        //////////////////////////////////////////////////////////////////
        private void displayInfo(int q, char w, double t)
        {
            string pine = "PINE";
            string oak = "OAK";
            string mahogany = "MAHOGANY";
            string woodType = "";
            if (w == 'P')
            {
                woodType = pine;
            }
            else if (w == 'O')
            {
                woodType = oak;
            }
            else if (w == 'M')
            {
                woodType = mahogany;
            }
            displayLabel.Text = woodType + " desk with " + q.ToString() + " drawers.\n\n" 
            + "Price Quote is " + t.ToString("C") + ".";
        }//end displayInfo
        private void getQuoteButton_Click(object sender, EventArgs e)
        {
            int qty = getNumOfDrawers();               // call getNumOfDrawers, assign results to qty
            char woodType = getWoodType();             // call woodType, assign results to woodType
            double totalCost = calcCost(qty, woodType);// call calcCost, pass qty, woodType, assign results to totalCost
            displayInfo(qty, woodType, totalCost);     // call displayInfo (to display message), pass qty, woodType, totalCost
        }//end getQuoteButton_Click
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close(); // Terminate
        }//end exitButton_Click
        // woodTypeTextBox_TextChanged converts display to uppercase for valid entries.
        private void woodTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            string p = "P";
            string o = "O";
            string m = "M";
            if (woodTypeTextBox.Text == "p")
            {
                woodTypeTextBox.Text = Convert.ToString(p);
            }
            if (woodTypeTextBox.Text == "o")
            {
                woodTypeTextBox.Text = Convert.ToString(o);
            }
            if (woodTypeTextBox.Text == "m")
            {
                woodTypeTextBox.Text = Convert.ToString(m);
            }
            
        }//end woodTypeTextBox_TextChanged
        private void numDrawersTextBox_TextChanged(object sender, EventArgs e)
        {
            numDrawersTextBox.Focus();       // focuses on text
            numDrawersTextBox.SelectAll();   // highlights all text
        }//end numDrawersTextBox_TextChanged

    }
}
