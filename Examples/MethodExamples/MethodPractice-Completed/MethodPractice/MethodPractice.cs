// Framework for writing practice code
// using Methods
// Written by Brian Bird, 5/21/13

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodPractice
{
    public partial class MethodPracticeForm : Form
    {
        // Random rand = new Random();  // Use this for actual pseudo-random numbers
        MockRandom rand;   // Use this only for testing


        public MethodPracticeForm()
        {
            InitializeComponent();
        }


        // #1 A method with no return value and no parameters
        private void problem1Button_Click(object sender, EventArgs e)
        {
            /* TODO 1A: Write code to call the method */

            Welcome();
        }


        /* TODO 1B: Write a method definition
         * for a method with the following signature:
             * Return value: none
             * Name: Welcome
             * Parameters: None
             * 
         * The method should display a message box that says: Welcome to Method Practice!
         * The message box can use any button to close the message box.
         * Your method should also put the text "Done" in Result1TextBox.Text */

        private void Welcome()
        {
            MessageBox.Show("Welcome!");
            result1TextBox.Text = "Done";
        }


        // # 2 A method that returns a value but has no parameters
        private void problem2Button_Click(object sender, EventArgs e)
        {
            rand = new MockRandom();   // Use this only for testing
            /* TODO 2A: Write code to call the method in 2B twice
             * Use the return value to set Result2TextBox.Text */
            result2TextBox.Text = RollDie().ToString();
        }

        /* TODO 2B: Write a method definition
         * for a method with the following signature:
             * Return value: an integer between 1 and 6
             * Name: RollDie
             * Parameters: None
             * 
         * The method will simulate rolling a die
         * Use the rand object defined in this class to generate random numbers */
        private int RollDie()
        {
            return rand.Next(6) + 1;
        }


        // #3 calling a method in a loop
        private void problem3Button_Click(object sender, EventArgs e)
        {
            rand = new MockRandom();   // Use this only for testing
            /* TODO 3: Write a loop that will call RollDie 4 times.
             * Put each value rolled into result3TextBox.Text.
             * Do not put any commas or spaces between the numbers.
             */
            result3TextBox.Text = "";
            for (int i = 0; i < 4; i++)
                result3TextBox.Text += RollDie().ToString();
        }


        // #4 A method with 3 parameters and a return value
        private void problem4Button_Click(object sender, EventArgs e)
        {
            /* TODO 4A: Write code to call the method in 4B
             * Pass in: 1, 3, and 6
             * Use the return value to set result4TextBox.Text */

            result4TextBox.Text = Average(1, 3, 6).ToString();
        }

        /* TODO 4B: Define a method with the following signature:
             * Return value: a double 
             * Name: Average
             * Parameters: Three ints
             * 
         * The method will calculate the average of the three numbers passed in */
        private double Average(int a, int b, int c)
        {
            return (a + b + c) / 3.0;
        }


        // #5 A method with default parameter values
        private void problem5Button_Click(object sender, EventArgs e)
        {
            /* TODO 5A: Write code to call the method in 5B
             * Pass in: number of values, 2.5, 3.1, 1.5, and 2.9.
             * Use the return value to set result5TextBox.Text */
            result5TextBox.Text = AverageEx(4, 2.5, 3.1, 1.5, 2.9).ToString();
        }

        /* TODO 5B: Define a method with the following signature:
             * Return value: a double 
             * Name: AverageEx
             * First Parameter; an int that indicates how many numbers will be averaged
             * Parameters 2 through 6 are doubles and have default values of 0
         * The method will calculate the average of any numbers passed in 
         * the 2nd through 6th parameters */

        private double AverageEx(int n, double v1 = 0, double v2 = 0, double v3 = 0, double v4 = 0, double v5 = 0)
        {
            return (v1 + v2 + v3 + v4 + v5) / n;
        }

        // #6 An overloaded method
        private void problem6Button_Click(object sender, EventArgs e)
        {
            /* TODO 6A: Write code to call the method in 6B
             * Pass in: 3, 3, 4 and, 4.
             * Use the return value to set result6TextBox.Text */
            result6TextBox.Text = Average(3, 3, 4, 4).ToString();
        }

        /* TODO 6B: Duplicate the method from 4B, 
         * but add one more parameter and name the function: Average */
        private double Average(int v1, int v2, int v3, int v4)
        {
            return (v1 + v2 + v3 + v4) / 4.0;
        }


        // #7 Another overloaded method
        private void problem7Button_Click(object sender, EventArgs e)
        {
            /* TODO 7A: Write code to call the method in 7B
             * Pass in: 14.0, 1.5, 2.7 and, 1.6.
             * Use the return value to set result7TextBox.Text */
             result7TextBox.Text = Average(14.0, 1.5, 2.7, 1.6).ToString();

        }

        /* TODO 7B: Duplicate the method from 6B, 
         * but make the parameters doubles */
        private double Average(double v1, double v2, double v3, double v4)
        {
            return (v1 + v2 + v3 + v4) / 4.0;
        }


        // #8 Two overloaded methods
        private void problem8Button_Click(object sender, EventArgs e)
        {
            /* TODO 8A: Write code to call the two methods defined in 8B
             * Call method 1 with: 1000.0, 15
             * Use the return value of method 1 set result8TextBox.Text
             * Call method 2 with: 1000.0, 0.07F
             * Append the return value of method 2 to result8TextBox.Text */
            result8TextBox.Text = calcPercentage(1000.0, 15).ToString();
            result8TextBox.Text += calcPercentage(1000.0, 0.07F).ToString();

        }

        /* TODO 8B: Write two methods named calcPercent
         * For the first method:
         *   Parameter 1: a double value 
         *   Parameter 2: an int that represents a percentage
         *   Return value: a double that equals Paramenter1 * Parameter2 * 0.01
         *   
         * For the second method
         *   Parameter 1: a double value 
         *   Parameter 2: an double that represents a percentage
         *   Return value: a float that equals Paramenter1 * Parameter2 */
        private double calcPercentage(double amount, int percent)
        {
            return amount * percent * 0.01;
        }

        private double calcPercentage(double amount, float percent)
        {
            return amount * percent;
        }


        /*****************************/
        /* Code to check the results */
        /*****************************/

        private void checkResultsButton_Click(object sender, EventArgs e)
        {
            // Problem 1
            if (result1TextBox.Text != "Result 1")
                if( result1TextBox.Text == "Done")
                    result1TextBox.Text = 
                        MessageBox.Show("Was a welcome message displayed?",
                        "Checking Problem 1", MessageBoxButtons.YesNo).ToString();
            SetResult(result1TextBox, check1Label, "Yes");

            // Problem 2
            SetResult(result2TextBox, check2Label, "3");

            // Problem 3
            SetResult(result3TextBox, check3Label, "3612");

            // Problem 4
            SetResult(result4TextBox, check4Label, "3.33333333333333");

            // Problem 5
            SetResult(result5TextBox, check5Label, "2.5");

            // Problem 6
            SetResult(result6TextBox, check6Label, "3.5");

            // Problem 7
            SetResult(result7TextBox, check7Label, "4.95");

            // Problem 8
            SetResult(result8TextBox, check8Label, "15070.0000002980232");
        }

        private void SetResult(TextBox result, Label resultLabel, string answer)
        {
            if (!(result.Text.Length > 7 && result.Text.Substring(0, 7) == "Result "))
            {
                if (result.Text == answer)
                {
                    resultLabel.Text = "Yes!";
                    resultLabel.BackColor = Color.LightGreen;
                }
                else
                {
                    resultLabel.Text = "Oops";
                    resultLabel.BackColor = Color.Red;
                }
            }
        }


    }
}
