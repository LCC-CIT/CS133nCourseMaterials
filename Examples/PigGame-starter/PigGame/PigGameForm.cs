using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigGame
{
    public partial class PigGameForm : Form
    {
        Random rand = new Random();

        public PigGameForm()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            int dieRoll = rand.Next(6) + 1;
            dieLabel.Text = dieRoll.ToString();
        }
    }
}
