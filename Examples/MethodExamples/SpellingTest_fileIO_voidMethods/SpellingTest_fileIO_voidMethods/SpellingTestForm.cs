using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SpellingTest_fileIO_voidMethods
{
    public partial class SpellingTestForm : Form
    {
        public SpellingTestForm()
        {
            InitializeComponent();
        }

        private void check1Button_Click(object sender, EventArgs e)
        {

            // TODO: Put this code into a method so that it doesn't have to be 
            // duplicated for every button
            StreamReader inFile;
            inFile = File.OpenText(@"C:\ProgramData\WordList\wordsEn.txt");
            string word = "";
            while(!inFile.EndOfStream && word != word1TextBox.Text)
            {
                word = inFile.ReadLine();
            }

            if (inFile.EndOfStream)
                Result1Label.BackColor = Color.Red;
            else
                Result1Label.BackColor = Color.Green;
        }

        private void check2Button_Click(object sender, EventArgs e)
        {

        }

        private void check3Button_Click(object sender, EventArgs e)
        {

        }

        private void check4Button_Click(object sender, EventArgs e)
        {

        }

        private void check5Button_Click(object sender, EventArgs e)
        {

        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            // Todo: check the spelling of all the words
            // Todo: simplify the way the total correct is determined
            int numberCorrect = 0;

            if (Result1Label.BackColor == Color.Green)
                numberCorrect++;
            else if (Result2Label.BackColor == Color.Green)
                numberCorrect++;
            else if (Result3Label.BackColor == Color.Green)
                numberCorrect++;
            else if (Result4Label.BackColor == Color.Green)
                numberCorrect++;
            else if (Result5Label.BackColor == Color.Green)
                numberCorrect++;

            numberCorrectLabel.Text = numberCorrect.ToString();
        }
    }
}
