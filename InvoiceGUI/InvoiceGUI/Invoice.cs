// Charles Carper
// 3.24.15
// Chapter 10 – Programming Exercise 1
// View invoice information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGUI
{
    class Invoice
    {
        public string Name { get; set; }
        public double Amount { get; set; }

        public new string ToString()
        {
            return ("From: " + Name + "\n         Amount Due : " + Amount.ToString("C")) + "\n";
        }
    }
}
