// Charles Carper
// 4.20.15
// Chapter 13 – Programming Exercise 3
// Select a movie and view starting and running times

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSelectorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            slctLabel.Enabled = true;     // enables label and makes invisible to user
            slctLabel.Visible = false;
            strtTimeLabel.Enabled = true; // enables label and makes invisible to user
            strtTimeLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();//Terminate the program 
        }
        private void movListBox_MouseHover(object sender, EventArgs e)
        {
            slctLabel.Enabled = true; // enables label and makes visible with mouse hover
            slctLabel.Visible = true;
            strtTimeLabel.Enabled = true; // enables label and makes visible with mouse hover
            strtTimeLabel.Visible = true;
        }

        private void movListBox_MouseLeave(object sender, EventArgs e)
        {
            slctLabel.Enabled = true;
            slctLabel.Visible = false; // makes label invisible when mouse leaves
            strtTimeLabel.Enabled = true;
            strtTimeLabel.Visible = false; // makes label invisible when mouse leaves
            movListBox.SelectedIndex = -1;
            displayLabel.Text = "";
        }

        // one item from listbox gets selected and prompts a message to the user.
        private void movListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (movListBox.GetSelected(0))
            {
                displayLabel.Text = ("Running time for seleted movie is 2 Hr. 22 Min.");
            }
            if (movListBox.GetSelected(1))
            {
                displayLabel.Text = ("Running time for seleted movie is 1 Hr. 50 Min.");
            }
            if (movListBox.GetSelected(2))
            {
                displayLabel.Text = ("Running time for seleted movie is 1 Hr. 30 Min.");
            }
            if (movListBox.GetSelected(3))
            {
                displayLabel.Text = ("Running time for seleted movie is 1 Hr. 40 Min.");
            }
            if (movListBox.GetSelected(4))
            {
                displayLabel.Text = ("Running time for seleted movie is 1 Hr. 45 Min.");
            }
        }
    }
}
