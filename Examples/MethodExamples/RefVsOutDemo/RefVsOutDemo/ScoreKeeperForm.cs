using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace RefParamDemo
{
    public partial class ScoreKeeperForm : Form
    {
        int highScore;  // MUST be declared before calling CalcHighScore, used by ref param

        public ScoreKeeperForm()
        {
            InitializeComponent();
        }

        private void enterScoreButton_Click(object sender, EventArgs e)
        {
            string message;     // MUST be declared before calling Validate, used by out param

            if (Validate(inputTextBox, out message))
            {
                int score = int.Parse(inputTextBox.Text);
                CalcHighScore(ref highScore, score);
                outTextBox.Text = highScore.ToString();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        // Determines if score is a new high score
        // returns the high score in high
        private void CalcHighScore( ref int high, int score)
        {
            if (score > high)
                high = score;   // since this is a ref param, assigning a value is optional

           // return high;
        }

        // Validates that the score is within range
        private bool Validate(TextBox tbox, out string msg)
        {
            msg = "valid";      // since this is an out param, we MUST assign a value
            bool valid = true;
            int num;
            valid &= int.TryParse(tbox.Text, out num);
            if (num < 0 || num > 100)
            {
                valid &= false;
            }

            if (!valid)
                msg = "Invalid entry";

            return valid;
        }
    }
}
