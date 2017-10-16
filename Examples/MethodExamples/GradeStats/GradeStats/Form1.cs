using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeStats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int scoreCount = 0;
        int scoreTotal = 0;

        private void calcStatsButton_Click(object sender, EventArgs e)
        {
            int score = int.Parse(scoreTextBox.Text);
            string message;
            if (!ValidateInput(ref score, MIN_SCORE, MAX_SCORE, out message))
            {
                scoreTextBox.Text = score.ToString();
                MessageBox.Show(message);
            }

            scoreTotal += score;
            scoreCount++;

            averageLabel.Text = CalcAverage(scoreTotal, scoreCount).ToString();

            FindMin(ref minScore, score);
            minLabel.Text = minScore.ToString();

            FindMax(ref maxScore, score);
            maxLabel.Text = maxScore.ToString();
        }

        float CalcAverage(int sum, int n)
        {
            return sum / n;
        }

        const int MAX_SCORE = 50, MIN_SCORE = 0;

        bool ValidateInput(ref int score, int min, int max, out string errorMessage)
        {
            errorMessage = "Everything is Awesome!";
            bool valid = true;
            // check the range, change score if it's outside the range
            if (score < min)
            {
                score = min;
                valid = false;
                errorMessage = "Score too low";
            }
            if (score > max)
            {
                score = max;
                valid = false;
                errorMessage = "Score too high";
            }

            // Return true if the score was within range
            return valid;
        }

        int minScore = MAX_SCORE, maxScore = MIN_SCORE;

        void FindMin(ref int currentMin, int score)
        {
            if (score < currentMin)
                currentMin = score;
        }

        void FindMax(ref int currentMax, int score)
        {
            if (score > currentMax)
                currentMax = score;
        }
    }
}
