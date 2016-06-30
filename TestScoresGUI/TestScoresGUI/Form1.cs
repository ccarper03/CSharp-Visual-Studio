// Charles Carper
// 01.27.15
// Chapter 3 – Programming Exercise 4
// Average of Test Scores GUI


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScoresGUI
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

        private void button1_Click(object sender, EventArgs e)
        {
            // declare variables
            double score1, score2, score3, score4, score5, sum, avg;

            // convert string to double
            score1 = Convert.ToDouble(score1TextBox.Text);
            score2 = Convert.ToDouble(score2TextBox.Text);
            score3 = Convert.ToDouble(score3TextBox.Text);
            score4 = Convert.ToDouble(score4TextBox.Text);
            score5 = Convert.ToDouble(score5TextBox.Text);

            // Calculate 
            sum = score1 + score2 + score3 + score4 + score5;
            avg = sum / 5;

            // convert back to string and display to user
            avgLabel.Text = avg.ToString("F2");

        }

        private void score1TextBox_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
