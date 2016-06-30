using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Terminate
            Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare variables
            double gpa = 0.0;
            int testScore = 0;

            //convert to apropriate data type
            gpa =  Convert.ToDouble(gpaTextBox.Text);
            testScore = Convert.ToInt32(testScoreTextBox.Text);

            //process
            if (gpa >= 3.0 && testScore >= 60)
            {
                label3.Text = "Application Accepted";
            }
            else 
            {
                if (gpa < 3.0 && testScore >= 80)
                {
                    label3.Text = "Application Accepted";
                }
                else 
                {
                    label3.Text = "Application Rejected";
                }
            }
        }
    }
}
