using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodPracticeInClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void doButton_Click(object sender, EventArgs e)
        {
            bool result = false;
            double value = double.Parse(inputTextBox.Text);
            result = Validate(value, 1, 10);
            if (result == true)
                outputTextBox.Text = Power(value).ToString();
            else
                outputTextBox.Text = "Invalid";
        }

        private bool Validate(int input)
        {
            bool valid = false;
            if (input >= 0 && input <= 100)
                valid = true;
            return valid;
        }

        private bool Validate(int input, int min, int max)
        {
            bool valid = false;
            if (input >= min && input <= max)
                valid = true;
            return valid;
        }

        private bool Validate(double input, int min, int max)
        {
            bool valid = false;
            if (input >= min && input <= max)
                valid = true;
            return valid;
        }

        private int Power(int b, int exponent = 2)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
                result *= b;
            return result;
        }

        private double Power(double b, int exponent = 2)
        {
            double result = 1;
            for (int i = 0; i < exponent; i++)
                result *= b;
            return result;
        }
    }
}
