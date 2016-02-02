using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();

        private void rollButton_Click(object sender, EventArgs e)
        {
            dieLabel.Text = rand.Next(1, 7).ToString() + ", " + 
                rand.Next(1, 7).ToString();
        }
    }
}
