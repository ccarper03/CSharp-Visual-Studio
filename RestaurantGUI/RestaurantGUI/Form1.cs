// Charles Carper
// 4.14.15
// RestaurantGUI
// Chapter 12 – Programming Exercise 7
// Select dinner items from various list boxes

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantGUI
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

        private void resetButton_Click(object sender, EventArgs e)
        {
            // clears out the display label
            displayLabel.Text = string.Empty;

            // clears out selections for each list box
            appListBox.SelectedIndex = -1;
            entreeListBox.SelectedIndex = -1;
            dsrtListBox.SelectedIndex = -1;
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ////////////    Declare variables    ///////////////
            // Appetizers
            const double APP1    =  6.99,  APP2    =  9.99,   APP3    =  7.99;
            // Entrees
            const double ENTREE1 = 22.00,  ENTREE2 = 20.00,   ENTREE3 = 19.00;
            // Desserts
            const double DSRT1   =  6.50,  DSRT2   =  8.50,   DSRT3   =  7.50;
            // Total cost 
            double       total   =  0.00;

            /*********************************************************************************************
             *This program will receive 3 selections from the user, one from each meal coarse. 
             *when the user clicks the view cost button the program will add up the total of all 
             *three selections and display the results in the center bottom mid box. if the user wishes
             *to adjust their selections they may at anytime and click the view cost button once again to 
             *get the updated results. once satisfied the user may exit the program by clicking the the 
             *exit button or the red X on the top right of the program.
             *********************************************************************************************/

            /*********************************************************************************************************************/
            // app1 variations - // for each variation possibility calculate the total and display the results
            if (appListBox.SelectedIndex == 0 && entreeListBox.SelectedIndex == 0 && dsrtListBox.SelectedIndex == 0)
            {
                total = APP1 + ENTREE1 + DSRT1;
                displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
            }
            else 
            {
                if (appListBox.SelectedIndex == 0 && entreeListBox.SelectedIndex == 0 && dsrtListBox.SelectedIndex == 1)
                {
                    total = APP1 + ENTREE1 + DSRT2;
                    displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                }
                else
                {
                    if (appListBox.SelectedIndex == 0 && entreeListBox.SelectedIndex == 0 && dsrtListBox.SelectedIndex == 2)
                    {
                        total = APP1 + ENTREE1 + DSRT3;
                        displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                    }
                }
            }
            if (appListBox.SelectedIndex == 0 && entreeListBox.SelectedIndex == 1 && dsrtListBox.SelectedIndex == 0)
            {
                total = APP1 + ENTREE2 + DSRT1;
                displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
            }
            else
            {
                if (appListBox.SelectedIndex == 0 && entreeListBox.SelectedIndex == 1 && dsrtListBox.SelectedIndex == 1)
                {
                    total = APP1 + ENTREE2 + DSRT2;
                    displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                }
                else
                {
                    if (appListBox.SelectedIndex == 0 && entreeListBox.SelectedIndex == 1 && dsrtListBox.SelectedIndex == 2)
                    {
                        total = APP1 + ENTREE1 + DSRT3;
                        displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                    }
                }
            }
            if (appListBox.SelectedIndex == 0 && entreeListBox.SelectedIndex == 2 && dsrtListBox.SelectedIndex == 0)
            {
                total = APP1 + ENTREE3 + DSRT1;
                displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
            }
            else
            {
                if (appListBox.SelectedIndex == 0 && entreeListBox.SelectedIndex == 2 && dsrtListBox.SelectedIndex == 1)
                {
                    total = APP1 + ENTREE1 + DSRT2;
                    displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                }
                else
                {
                    if (appListBox.SelectedIndex == 0 && entreeListBox.SelectedIndex == 2 && dsrtListBox.SelectedIndex == 2)
                    {
                        total = APP1 + ENTREE1 + DSRT3;
                        displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                    }
                }
            }


            /*********************************************************************************************************************/
            //app2 variation - // for each variation possibility calculate the total and display the results
            if (appListBox.SelectedIndex == 1 && entreeListBox.SelectedIndex == 0 && dsrtListBox.SelectedIndex == 0)
            {
                total = APP2 + ENTREE1 + DSRT1;
                displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
            }
            else
            {
                if (appListBox.SelectedIndex == 1 && entreeListBox.SelectedIndex == 0 && dsrtListBox.SelectedIndex == 1)
                {
                    total = APP2 + ENTREE1 + DSRT2;
                    displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                }
                else
                {
                    if (appListBox.SelectedIndex == 1 && entreeListBox.SelectedIndex == 0 && dsrtListBox.SelectedIndex == 2)
                    {
                        total = APP2 + ENTREE1 + DSRT3;
                        displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                    }
                }
            }
            if (appListBox.SelectedIndex == 1 && entreeListBox.SelectedIndex == 1 && dsrtListBox.SelectedIndex == 0)
            {
                total = APP2 + ENTREE2 + DSRT1;
                displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
            }
            else
            {
                if (appListBox.SelectedIndex == 1 && entreeListBox.SelectedIndex == 1 && dsrtListBox.SelectedIndex == 1)
                {
                    total = APP2 + ENTREE2 + DSRT2;
                    displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                }
                else
                {
                    if (appListBox.SelectedIndex == 1 && entreeListBox.SelectedIndex == 1 && dsrtListBox.SelectedIndex == 2)
                    {
                        total = APP2 + ENTREE2 + DSRT3;
                        displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                    }
                }
            }
            if (appListBox.SelectedIndex == 1 && entreeListBox.SelectedIndex == 2 && dsrtListBox.SelectedIndex == 0)
            {
                total = APP2 + ENTREE3 + DSRT1;
                displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
            }
            else
            {
                if (appListBox.SelectedIndex == 1 && entreeListBox.SelectedIndex == 2 && dsrtListBox.SelectedIndex == 1)
                {
                    total = APP2 + ENTREE3 + DSRT2;
                    displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                }
                else
                {
                    if (appListBox.SelectedIndex == 1 && entreeListBox.SelectedIndex == 2 && dsrtListBox.SelectedIndex == 2)
                    {
                        total = APP2 + ENTREE3 + DSRT3;
                        displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                    }
                }
            }


            /*********************************************************************************************************************/
            // app3 variations - // for each variation possibility calculate the total and display the results
            if (appListBox.SelectedIndex == 2 && entreeListBox.SelectedIndex == 0 && dsrtListBox.SelectedIndex == 0)
            {
                total = APP3 + ENTREE1 + DSRT1;
                displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
            }
            else
            {
                if (appListBox.SelectedIndex == 2 && entreeListBox.SelectedIndex == 0 && dsrtListBox.SelectedIndex == 1)
                {
                    total = APP3 + ENTREE1 + DSRT2;
                    displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                }
                else
                {
                    if (appListBox.SelectedIndex == 2 && entreeListBox.SelectedIndex == 0 && dsrtListBox.SelectedIndex == 2)
                    {
                        total = APP3 + ENTREE1 + DSRT3;
                        displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                    }
                }
            }
            if (appListBox.SelectedIndex == 2 && entreeListBox.SelectedIndex == 1 && dsrtListBox.SelectedIndex == 0)
            {
                total = APP3 + ENTREE2 + DSRT1;
                displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
            }
            else
            {
                if (appListBox.SelectedIndex == 2 && entreeListBox.SelectedIndex == 1 && dsrtListBox.SelectedIndex == 1)
                {
                    total = APP3 + ENTREE2 + DSRT2;
                    displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                }
                else
                {
                    if (appListBox.SelectedIndex == 2 && entreeListBox.SelectedIndex == 1 && dsrtListBox.SelectedIndex == 2)
                    {
                        total = APP3 + ENTREE2 + DSRT3;
                        displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                    }
                }
            }
            if (appListBox.SelectedIndex == 2 && entreeListBox.SelectedIndex == 2 && dsrtListBox.SelectedIndex == 0)
            {
                total = APP3 + ENTREE3 + DSRT1;
                displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
            }
            else
            {
                if (appListBox.SelectedIndex == 2 && entreeListBox.SelectedIndex == 2 && dsrtListBox.SelectedIndex == 1)
                {
                    total = APP3 + ENTREE3 + DSRT2;
                    displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                }
                else
                {
                    if (appListBox.SelectedIndex == 2 && entreeListBox.SelectedIndex == 2 && dsrtListBox.SelectedIndex == 2)
                    {
                        total = APP3 + ENTREE3 + DSRT3;  
                        displayLabel.Text = "Total cost for selected items is " + total.ToString("C2");
                    }
                }
            }


            //reset and focus on reset button
            resetButton.Focus();  
        }
    }
}
