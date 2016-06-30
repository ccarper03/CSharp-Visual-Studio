// Charles Carper
// 3/12/15
// Chapter 9 – Programming Exercise 4
// Instantiate an array of square objects to display the area of each square

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquaresGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // when button is clicked 
        private void displayButton_Click(object sender, EventArgs e)
        {
            Square[] sqArray = new Square[10];  // instantiate an array of 10 Square objects

            for(int index = 0; index < sqArray.Length; ++index)
            {
                sqArray[index]= new Square(index +1);
            }
            // displays the results
            for (int index = 0; index < 10; ++index)
            {
                displayLabel.Text += String.Format("The Area of a {0}  by {1} square is {2} \n"
                    , sqArray[index].Side, sqArray[index].Side, sqArray[index].Area);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();      // Terminate
        }
    }
    class Square
    {
        // instance variable declarations
        double side, area;

        // constructor with a parameter
        public Square(int squareSide)
        { 
            // assign parameter value to instance vaiable
            side = squareSide;
            // call compute area method
            ComputeArea();
        }

        // instance method to get and return side 
        public double Side
        {
            get
            {
                return side;
            }
        }
        // instance method to get and return area 
        public double Area
        {
            get 
            {
                return area;
            }
        }
        // instance method to calculate area
        private void ComputeArea()
        {
            area = side * side;
        }

    }

}
