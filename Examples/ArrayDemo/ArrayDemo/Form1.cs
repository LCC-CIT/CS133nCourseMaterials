// This program demonstrates the use of a 1D array
// Written by Brian Bird, 5/28/13

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

        const int SIZE = 10;        // Number of elements in the array
        int[] scores = new int[SIZE];   // define and create the array
        int index = 0;   // keep track of how many elements hold data


        // Add a score to the array
        private void button1_Click(object sender, EventArgs e)
        {
            scores[index++] = int.Parse(scoreTextBox.Text);
        }


        // Show all the scores in the array
        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < index; i++)
                displayTextBox.Text += scores[i].ToString() + ", ";
        }
    }
}
