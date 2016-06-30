using System;
using System.Windows.Forms;

namespace HurricaneGUI
{
    public partial class hurricaneCategories : Form
    {
        public hurricaneCategories()
        {
            InitializeComponent();
        }
        private void findButton_Click(object sender, EventArgs e)
        {
            int speed = 0;
            speed = Convert.ToInt32(inputTextBox.Text);   // converts string to int and stored in speed variable

            //process
            if (speed >= 157)   // 157 and up = Cat 5 hurricane
            {
                output.Text = "Category 5 hurricane";   // prompt user
            }
            else 
            {
                if (speed >= 130)   // 130 and up = Cat 4 hurricane
                {
                    output.Text = "Category 4 hurricane";   // prompt user
                }
                else
                {
                    if (speed >= 111)   // 111 and up = Cat 3 hurricane
                    {
                        output.Text = "Category 3 hurricane";   // prompt user
                    }
                    else
                    {
                        if (speed >= 96)    // 96 and up = Cat 2 hurricane
                        {
                            output.Text = "Category 2 hurricane";   // prompt user
                        }
                        else
                        {
                            if (speed >= 74)    // 74 and up = Cat 1 hurricane
                            {
                                output.Text = "Category 1 hurricane";   // prompt user
                            }
                            else   // anything else is not considered a huricane.
                            {
                                output.Text = "Not a Hurricane";   // prompt user
                            }
                        }
                    }
                }
            }
            //
            inputTextBox.Focus();   // focuses on text
            inputTextBox.SelectAll();   // highlights all text
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();      // Terminate
        }
        private void output_Click(object sender, EventArgs e)  
        {
            output.Text = String.Empty;     // clears out the label named output when new text is entered
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
   }   
}

