using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoolDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void doSomethingButton_Click(object sender, EventArgs e)
        {
            int baseNum = 0;
            int exponent = 0;
            
            bool valid = int.TryParse(input1TextBox.Text, out baseNum);
            valid = valid && int.TryParse(input2TextBox.Text, out exponent);
            
            /*
            bool valid = int.TryParse(input1TextBox.Text, out baseNum) &&
            int.TryParse(input2TextBox.Text, out exponent);  
            */

            if (valid)
                outputLabel.Text = Math.Pow(baseNum, exponent).ToString();
            else
                outputLabel.Text = "Please enter an integer";

        }
    }
}
