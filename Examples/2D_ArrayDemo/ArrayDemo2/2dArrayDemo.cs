// This program demonstrates the use of 2D Arrays
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

namespace ArrayDemo
{
    public partial class ArrayDemoForm : Form
    {
        public ArrayDemoForm()
        {
            InitializeComponent();
        }
        
        // 2D (Rectangular) array to hold student names and L numbers
        // It has 30 rows and 2 columns
        string[,] namesAndNumbers = new string[30, 2];
        int studentCount = 0;   // Number of rows that contain student info


        private void ArrayDemoForm_Load(object sender, EventArgs e)
        {
            // Pre-load the array with some names and L Numbers
            namesAndNumbers[0, 0] = "Brian";
            namesAndNumbers[0, 1] = "L00516163";
            namesAndNumbers[1, 0] = "Chris";
            namesAndNumbers[1, 1] = "L00123456";
            namesAndNumbers[2, 0] = "Jessica";
            namesAndNumbers[2, 1] = "L00234567";
            namesAndNumbers[3, 0] = "Russ";
            namesAndNumbers[3, 1] = "L00345678";
            namesAndNumbers[4, 0] = "Marti";
            namesAndNumbers[4, 1] = "L00456789";
            // We just added 5 students so update the count
            studentCount = 5;
        }


        // Put the name and number in the text boxes into the Array
        private void enterButton_Click(object sender, EventArgs e)
        {
            namesAndNumbers[studentCount, 0] = nameTextBox.Text;
            namesAndNumbers[studentCount++, 1] = lNumberTextBox.Text;
        }


        // Display all the names and the L numbers that go with them
        private void displayButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = "";    // Clear the display

            for (int r = 0; r < studentCount; r++)  // loops through the rows
            {
                for (int c = 0; c < 2; c++)     // alternately puts name, then number in the text box
                {
                    outputTextBox.Text += namesAndNumbers[r, c] + ", ";
                }
                outputTextBox.Text += "\r\n";   // starts a new line after each L number
            }
        }


    }
}
