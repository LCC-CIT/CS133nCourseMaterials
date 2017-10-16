// This program demonstrates the use of Lists
// Written by Brian Bird, 5/30/13

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListDemo
{
    public partial class ListDemo : Form
    {
        public ListDemo()
        {
            InitializeComponent();
        }
        
        // Parallel lists to hold student names and L numbers
        List<string> names = new List<string>();    // Holds names
        List<int> lNumbers = new List<int>();       // Holds the numeric part of L numbers

        // Put the name and number in the text boxes into the lists
        private void enterButton_Click(object sender, EventArgs e)
        {
            names.Add(nameTextBox.Text);
            lNumbers.Add(int.Parse(lNumberTextBox.Text));

        }

        // Display all the names and the numbers that go with them
        private void displayButton_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < names.Count; r++)
            {
               outputTextBox.Text += names[r] + ", " + lNumbers[r];
               outputTextBox.Text += "\r\n";
            }
        }

    }
}
