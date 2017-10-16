using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool loop = true;

        private void doButton_Click(object sender, EventArgs e)
        {
         /*
            outputLabel.Text = "";
            loop = true;
            while (loop)   // pretest
            {
                outputLabel.Text += "*";
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
            }
            */
            /*
            \int num = 1;
           do     // postest
            {
                outputLabel.Text += num.ToString();
                num++;
            } while (num < 5);
             */
           
           int limit = int.Parse(inputTextBox.Text);

            for (int num = limit; num >= 5; num--)
            {
                outputLabel.Text += num.ToString();
            }
            
            outputLabel.Text += "Finished";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            loop = false;
        }
    }
}
