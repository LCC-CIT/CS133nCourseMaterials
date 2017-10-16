using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefParamDemo
{
    public partial class Form1 : Form
    {
        int highScore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void doButton_Click(object sender, EventArgs e)
        {
            if (Validate(inputTextBox))
            {
                int score = int.Parse(inputTextBox.Text);
                CalcHighScore(ref highScore, score);
                outTextBox.Text = highScore.ToString();
            }
        }

        private void CalcHighScore(ref int high, int score)
        {
            if (score > high)
                high = score;
           // return high;
        }

        private bool Validate(TextBox tbox)
        {
            int num = int.Parse(tbox.Text);
            bool valid = true;
            if (num < 0 || num > 100)
            {
                tbox.Text = "invalid";
                valid = false;
            }
            return valid;
        }
    }
}
