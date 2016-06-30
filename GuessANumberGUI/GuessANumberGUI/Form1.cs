// Charles Carper   
// 4.20.15
// Chapter 13 – Programming Exercise 7
// Guess a random number game using radio buttons

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessANumberGUI
{
    public partial class Form1 : Form
    {
        // declare variable and object
        int correctAnswer;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            // generates random number
            correctAnswer = random.Next(1, 6);
            // hides the exit button
            exitButton.Visible = false;
            dspHintLabel.Enabled = false;
            dspHintLabel.Visible = false;
            // Radio buttons are enabled
            radioButton1.Enabled = true;  
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            // Unchecks the radio buttons initially
            radioButton1.TabStop = false;
            radioButton2.TabStop = false;
            radioButton3.TabStop = false;
            radioButton4.TabStop = false;
            radioButton5.TabStop = false;

            // MessageBox.Show(correctAnswer.ToString());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close(); // Terminate Program
        }

        private void hvrHintLabel_MouseHover(object sender, EventArgs e)
        {
            if (correctAnswer == 1)  
            {
                // if the generated number is equal to one  display not radio button 3
                dspHintLabel.Enabled = true;
                dspHintLabel.Visible = true;
                dspHintLabel.Text = "It's not Radio Button 3";
            }
            else
            {
                // any other number other than one will display the message  with the generated answer - 1
                dspHintLabel.Enabled = true;
                dspHintLabel.Visible = true;
                dspHintLabel.Text = "It's not Radio Button " + (correctAnswer - 1);
            }
        }

        private void hvrHintLabel_MouseLeave(object sender, EventArgs e)
        {
            // hide the dspHintLabel label
            dspHintLabel.Enabled = false;
            dspHintLabel.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (correctAnswer == 1)
                {
                    // if radio button 1 is the right answer prompt this message 
                    // display and focus on the exit button
                    displayLabel.Text = "Congradulations - You Guessed Correctly!";
                    exitButton.Visible = true;
                    exitButton.Focus();
                }
                else
                {
                    displayLabel.Text = "Sorry - you guessed incorrectly.";
                    radioButton1.Enabled = false;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if(correctAnswer==2)
                {
                    // if radio button 2 is the right answer prompt this message 
                    // display and focus on the exit button
                    displayLabel.Text = "Congradulations - You Guessed Correctly!";
                    exitButton.Visible = true;
                    exitButton.Focus();
                }
                else
                {
                    displayLabel.Text = "Sorry - you guessed incorrectly.";
                    radioButton2.Enabled = false;
                }
            }
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                if (correctAnswer == 3)
                {
                    // if radio button 3 is the right answer prompt this message 
                    // display and focus on the exit button
                    displayLabel.Text = "Congradulations - You Guessed Correctly!";
                    exitButton.Visible = true;
                    exitButton.Focus();
                }
                else
                {
                    displayLabel.Text = "Sorry - you guessed incorrectly.";
                    radioButton3.Enabled = false;
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                if (correctAnswer == 4)
                {
                    // if radio button 4 is the right answer prompt this message 
                    // display and focus on the exit button
                    displayLabel.Text = "Congradulations - You Guessed Correctly!";
                    exitButton.Visible = true;
                    exitButton.Focus();
                }
                else
                {
                    displayLabel.Text = "Sorry - you guessed incorrectly.";
                    radioButton4.Enabled = false;
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                if (correctAnswer == 5)
                {
                    // if radio button 5 is the right answer prompt this message 
                    // display and focus on the exit button
                    displayLabel.Text = "Congradulations - You Guessed Correctly!";
                    exitButton.Visible = true;
                    exitButton.Focus();
                }
                else
                {
                    displayLabel.Text = "Sorry - you guessed incorrectly.";
                    radioButton5.Enabled = false;
                }
            }
        }

    }
}
