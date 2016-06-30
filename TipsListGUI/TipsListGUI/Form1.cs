/* Charles Carper
 * 2/12/15
 * TipsListGUI
 * Chapter 6 – Programming Exercise 2
 * Calculate tip average and determine how far each tip is from the average
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

namespace TipsListGUI
{
    public partial class tipComparison : Form
    {
        public tipComparison()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            double sum = 0.0;
            double avg = 0.0;
            double[] diff = { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
            double[] tips = { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            tips[0] = Convert.ToDouble(day1TextBox.Text);
            tips[1] = Convert.ToDouble(day2TextBox.Text);
            tips[2] = Convert.ToDouble(day3TextBox.Text);
            tips[3] = Convert.ToDouble(day4TextBox.Text);
            tips[4] = Convert.ToDouble(day5TextBox.Text);
            tips[5] = Convert.ToDouble(day6TextBox.Text);
            tips[6] = Convert.ToDouble(day7TextBox.Text);
            // calculate the sum
            sum = tips[0] + tips[1] + tips[2] + tips[3] + tips[4] + tips[5] + tips[6];
            // display sum to the label
            totalDisplayLabel.Text = sum.ToString("C");
            //calculate avg dividing tips length by sum
            avg = sum / tips.Length;
            // display avg to the label
            avgDisplayLabel.Text = avg.ToString("C");
            // calculate the difference
            diff[0] = tips[0] - avg;
            diff[1] = tips[1] - avg;
            diff[2] = tips[2] - avg;
            diff[3] = tips[3] - avg;
            diff[4] = tips[4] - avg;
            diff[5] = tips[5] - avg;
            diff[6] = tips[6] - avg;
            
            // display the difference to the label, if it's less then zero color text red
            //---------------------------diff[0]--------------------------------//
            if (diff[0] > 0.0)
            {
                day1Label.Text = string.Format("{0:0.##}", diff[0]);
            }
            else
            {
                day1Label.ForeColor = Color.Red;
                day1Label.Text = string.Format("{0:0.##}", diff[0]);
            }
            //---------------------------diff[1]--------------------------------//
            if (diff[1] > 0.0)
            {
                day2Label.Text = string.Format("{0:0.##}", diff[1]);
            }
            else
            {
                day2Label.ForeColor = Color.Red;
                day2Label.Text = string.Format("{0:0.##}", diff[1]);
            }
            //---------------------------diff[2]--------------------------------//
            if (diff[2] > 0.0)
            {
                day3Label.Text = string.Format("{0:0.##}", diff[2]);
            }
            else
            {
                day3Label.ForeColor = Color.Red;
                day3Label.Text = string.Format("{0:0.##}", diff[2]);
            }
            //---------------------------diff[3]--------------------------------//
            if (diff[3] > 0.0)
            {
                day4Label.Text = string.Format("{0:0.##}", diff[3]);
            }
            else
            {
                day4Label.ForeColor = Color.Red;
                day4Label.Text = string.Format("{0:0.##}", diff[3]);
            }
            //---------------------------diff[4]--------------------------------//
            if (diff[4] > 0.0)
            {
                day5Label.Text = string.Format("{0:0.##}", diff[4]);
            }
            else
            {
                day5Label.ForeColor = Color.Red;
                day5Label.Text = string.Format("{0:0.##}", diff[4]);
            }
            //---------------------------diff[5]--------------------------------//
            if (diff[5] > 0.0)
            {
                day6Label.Text = string.Format("{0:0.##}", diff[5]);
            }
            else
            {
                day6Label.ForeColor = Color.Red;
                day6Label.Text = string.Format("{0:0.##}", diff[5]);
            }
            //---------------------------diff[6]--------------------------------//
            if (diff[6] > 0.0)
            {
                day7Label.Text = string.Format("{0:0.##}", diff[6]);
            }
            else
            {
                day7Label.ForeColor = Color.Red;
                day7Label.Text = string.Format("{0:0.##}", diff[6]);
            }
    }

        private void exitButton_Click(object sender, EventArgs e)
        {

            Close();      // Terminate
        }
    }
}