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
    public partial class CompGuessForm : Form
    {
        // Use this property to set or read the computer's guess
        public int CompGuess
        {
            get { return int.Parse(compGuessLabel.Text); } 
            set { compGuessLabel.Text = value.ToString(); }
        }

        // This will be set to -1 if the computer's guess was too low,
        // to 0 if the computer's guess was right,
        // to 1 if the computer's guess was too high.
        public int LowHighRight { get; set; }

        public CompGuessForm()
        {
            InitializeComponent();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            LowHighRight = 0;
            this.Close();
        }

        private void tooLowButton_Click(object sender, EventArgs e)
        {
            LowHighRight = -1;
            this.Close();
        }

        private void tooHighButton_Click(object sender, EventArgs e)
        {
            LowHighRight = 1;
            this.Close();
        }
    }
}
