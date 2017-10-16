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
        Random rand = new Random();

        public LoopPracticeForm()
        {
            InitializeComponent();
        }

        // for loop
        private void problem1Button_Click(object sender, EventArgs e)
        {
            // Write a for loop that iterates 10 times and puts
            // the numbers 0 through 9 into the result label.
            // The numbers should not be spearated by spaces or commas

            result1Label.Text = "";
            for (int i = 0; i < 10; i++)
                result1Label.Text += i.ToString();
        }


        //while loop
        private void problem2Button_Click(object sender, EventArgs e)
        {
            // Write a while loop contains a statement to generate mock 
            // random numbers between 1 and 6 (simulating the roll of a die)
            // Put each number rolled into the result label without spaces or commas.
            // Exit the loop when a 1 is rolled.

            // This statement creates a mock random number generator for you to use.
            MockRandom rand = new MockRandom();
            
            // An example of using the mock random number generator is given
            // below. Replace this with your own code
            // result2Label.Text = (rand.Next(5) + 1).ToString(); 

            result2Label.Text = "";
            int roll = 0;
            while (roll != 1)
            {
                roll = (rand.Next(5) + 1);
                result2Label.Text += roll.ToString();
            }
            
        }


        // do while loop
        private void problem3Button_Click(object sender, EventArgs e)
        {
            /* Instructions:
             * Write a do while loop that simulates rolling a dice.
             * Each time the dice is rolled pop up a message box that
             * displays the value rolled and asks the player if they want
             * to roll again. Stop looping when they answer no.
             *    Put each value rolled, and each message box result into 
             * the result label. When you test this, stop after 6 rolls. 
             */

            MockRandom rand = new MockRandom();
            // Here's an example of code to simulate rolling a die
            // and putting the result in a message box. Replace this with your own code.
            /* int roll = rand.Next(5) + 1;
            result3Label.Text = roll.ToString();
            DialogResult messageResult;
            messageResult =MessageBox.Show(string.Format("You rolled {0}. Click OK to roll again", roll),
                "Your roll", MessageBoxButtons.OKCancel);
            result3Label.Text += messageResult.ToString();
            */
            result3Label.Text = "";
            DialogResult messageResult;
            int roll = 0;
            do
            {
                roll = rand.Next(5) + 1;
                messageResult = MessageBox.Show(string.Format("You rolled {0}. Click OK to roll again", roll),
                    "Your roll", MessageBoxButtons.OKCancel);
                result3Label.Text += roll.ToString() + messageResult.ToString();
            }
            while (messageResult != DialogResult.Cancel);
        }


        // foreach loop
        private void problem4Button_Click(object sender, EventArgs e)
        {
            /* Write a foreach loop that adds up the numbers in the 
             * MockRandom.Numbers collection. The Numbers collection is 
             * similar to the Items collection on a ListBox, except
             * the data type of Numbers is int. Put the total in the result
             * label
             */

            MockRandom rand = new MockRandom();
            // Here's an example of reading one number from MockRandom.Numbers
            //result4Label.Text = rand.Numbers[9].ToString();
            int total = 0;
            foreach (int value in rand.Numbers)
                total += value;

            result4Label.Text = total.ToString();
        }


        // Max and Min values
        private void problem5Button_Click(object sender, EventArgs e)
        {
            /* Use a loop (whichever you think is appropriate) to find
             * the largest and smallest values in the MockRandom.Numbers
             * collection. Put the smallest number followed by a comma and
             * space and the largest number in the result label.
             * Example: 8, 92
             */

            MockRandom rand = new MockRandom();
            int min = 1000, max = -1000;
            foreach (int value in rand.Numbers)
            {
                if (value < min)
                {
                    min = value;
                }
                if (value > max)
                {
                    max = value;
                }
            }
            result5Label.Text = min.ToString() + ", " + max.ToString();

        }


        // Count numbers in a range
        private void problem6Button_Click(object sender, EventArgs e)
        {
            /* Count the numbers in MockRandom.Numbers that are between
             * 50 and 100, inclusive. Put the total in the result label.
             */

            MockRandom rand = new MockRandom();
            int count = 0;
            foreach (int value in rand.Numbers)
                if (value >= 50 && value <= 100)
                    count++;

            result6Label.Text = count.ToString();
        }


        // Select every 5th number
        private void problem7Button_Click(object sender, EventArgs e)
        {
            /* Write a loop that goes through the numbers in MockRandom.Numbers
             * and copies every 5th number into the result label.
             */

            MockRandom rand = new MockRandom();

            result7Label.Text = "";

            for (int i = 0; i < rand.Numbers.Count; i++)
                if (i % 5 == 0)
                    result7Label.Text += rand.Numbers[i].ToString();
        }


        private void checkResultsButton_Click(object sender, EventArgs e)
        {
            // Problem 1
            if (result1Label.Text == "0123456789")
                check1Label.Text = "pass";
            else if (result1Label.Text != "Result 1")
                check1Label.Text = "fail";
            // Problem 2
            if (result2Label.Text == "361")
                check2Label.Text = "pass";
            else if (result2Label.Text != "Result 2")
                check2Label.Text = "fail";
            // Problem 3
            if (result3Label.Text == "3OK6OK1OK2OK5OK3OK4Cancel")
                check3Label.Text = "pass";
            else if (result3Label.Text != "Result 3")
                check3Label.Text = "fail";
            // Problem 4
            if (result4Label.Text == "2623")
                check4Label.Text = "pass";
            else if (result4Label.Text != "Result 4")
                check4Label.Text = "fail";
            // Problem 5
            if (result5Label.Text == "0, 198")
                check5Label.Text = "pass";
            else if (result5Label.Text != "Result 5")
                check5Label.Text = "fail";
            // Problem 6
            if (result6Label.Text == "12")
                check6Label.Text = "pass";
            else if (result6Label.Text != "Result 6")
                check6Label.Text = "fail";
            // Problem 7
            if (result7Label.Text == "574236991021232184")
                check7Label.Text = "pass";
            else if (result7Label.Text != "Result 7")
                check7Label.Text = "fail";
        }
    }
}
