using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            int total = 0;
            /*
            int counter = 1;
            while (counter <= 5)
            {
                total += counter;
                counter++;
            }
            */

            /*
            for (int counter = 1; counter <= 5; counter++)
                total += counter;
            */
          //  resultLabel.Text = total.ToString();

            // Count by 2s (even numbers)
            resultLabel.Text = "";
            for (int i = 2; i <= 20; i = i + 2)
            {
                resultLabel.Text += i.ToString();
                if (i < 20)
                {
                    resultLabel.Text += ", ";
                }
            }

            
        }
    }
}
