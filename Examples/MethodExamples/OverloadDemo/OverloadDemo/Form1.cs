using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverloadDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int num1 = (int)GetInputFloat(input1TextBox.Text);
            int num2 = (int)GetInputFloat(input2TextBox.Text);
            resultLabel.Text = Average(num1, num2).ToString();
        }

        float GetInputFloat(string text)
        {
            float input;
            float.TryParse(text, out input);
            return input;
        }

        int GetInputInt(string text)
        {
            int input;
            int.TryParse(text, out input);
            return input;
        }
        float Average (float n1, float n2)
        {
            return (n1 + n2) / 2;
        }
        float Average(int n1, int n2)
        {
            return (n1 + n2) / 2;
        }
    }
}
