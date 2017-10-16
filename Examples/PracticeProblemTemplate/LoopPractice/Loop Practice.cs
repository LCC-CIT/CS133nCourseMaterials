using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopPractice
{
    public partial class LoopPracticeForm : Form
    {
        public LoopPracticeForm()
        {
            InitializeComponent();
        }

        private void problem1Button_Click(object sender, EventArgs e)
        {
            // Write a for loop that iterates 10 times and puts
            // the numbers 0 through 9 into the result label.
            // The numbers should not be spearated by spaces or commas

            result1Label.Text = "";
            for (int i = 0; i < 10; i++)
                result1Label.Text += i.ToString();
        }

        private void checkResultsButton_Click(object sender, EventArgs e)
        {
           // Problem 1
           if( result1Label.Text == "0123456789")
               check1Label.Text = "pass";
           else if (result1Label.Text != "Result 1")
               check1Label.Text = "fail";
            // Problem 2
           if (result2Label.Text == "0123456789")
               check2Label.Text = "pass";
           else if (result2Label.Text != "Result 2")
               check2Label.Text = "fail"; 
            // Problem 3
            if (result3Label.Text == "0123456789")
               check3Label.Text = "pass";
            else if (result3Label.Text != "Result 3")
               check3Label.Text = "fail";
            // Problem 4
            if (result4Label.Text == "0123456789")
               check4Label.Text = "pass";
            else if (result4Label.Text != "Result 4")
               check4Label.Text = "fail"; 
            // Problem 5
            if (result5Label.Text == "0123456789")
               check5Label.Text = "pass";
            else if (result5Label.Text != "Result 5")
               check5Label.Text = "fail"; 
            // Problem 6
            if (result6Label.Text == "0123456789")
               check6Label.Text = "pass";
            else if (result6Label.Text != "Result 6")
               check6Label.Text = "fail"; 
            // Problem 7
            if (result7Label.Text == "0123456789")
               check7Label.Text = "pass";
            else if (result7Label.Text != "Result 7")
               check7Label.Text = "fail";

        }
    }
}
