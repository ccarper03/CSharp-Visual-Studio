using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Unchecks the radio buttons initially
            radioButton1.TabStop = false;
            radioButton2.TabStop = false;
            radioButton3.TabStop = false;
            radioButton4.TabStop = false;
            radioButton5.TabStop = false;
            radioButton6.TabStop = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close(); // Terminate
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form2 myForm2 = new Form2();                                     // Instantiate Form2 object
                myForm2.ShowDialog();    
            }  
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Form3 myForm3 = new Form3();                                     // Instantiate Form3 object
                myForm3.ShowDialog();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Form4 myForm4 = new Form4();                                     // Instantiate Form4 object
                myForm4.ShowDialog();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Form5 myForm5 = new Form5();                                     // Instantiate Form5 object
                myForm5.ShowDialog();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                Form6 myForm6 = new Form6();                                     // Instantiate Form6 object
                myForm6.ShowDialog();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                Form7 myForm7 = new Form7();                                    // Instantiate Form7 object
                myForm7.ShowDialog();
            }
        }

    }
}
