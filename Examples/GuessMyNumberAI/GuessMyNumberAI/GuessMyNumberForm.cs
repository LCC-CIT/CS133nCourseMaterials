using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMyNumberAI
{
    public partial class GuessMyNumberForm : Form
    {

        // In the "Human guesses" part of the game the computer will generate a "hidden" number
        Random rand = new Random();     // Used to generate the computer's hidden number
        int randNumber = 0;             // Used to hold the hidden number
        int humanGuessCount = 0;        // Keep track of the human's guesses


        public GuessMyNumberForm()
        {
            InitializeComponent();
        }

        private void humanPlayButton_Click(object sender, EventArgs e)
        {
            randNumber = rand.Next(1, 101);
            humanGuessTextBox.Enabled = true;
            humanGuessTextBox.Clear();
        }

        private void humanGuessButton_Click(object sender, EventArgs e)
        {
            int humanGuess = int.Parse(humanGuessTextBox.Text);

            humanGuessCount++;

            if (humanGuess < randNumber)
            {
                compAnswerLabel.Text = "Too low";
            }
            else if (humanGuess > randNumber)
            {
                compAnswerLabel.Text = "Too high";
            }
            else
            {
                compAnswerLabel.Text = "You guessed it!";
                humanGuessTextBox.Enabled = false;
            }

            humanGuessCountLabel.Text = humanGuessCount.ToString();
        }

        private void compPlayButton_Click(object sender, EventArgs e)
        {
            CompGuessForm compGuessForm = new CompGuessForm();

            compGuessForm.CompGuess = 50;
            compGuessForm.ShowDialog();

            if (compGuessForm.LowHighRight == 0)
                MessageBox.Show("Whoo hoo! I won!");

            compGuessForm.Dispose();
        }

 


    }
}
