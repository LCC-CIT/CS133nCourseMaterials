using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_void_paramless_methods
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO: Simplify this event handler by using a method
            Double num1 = 0.0, num2 = 0.0;
            if (!Double.TryParse(num1TextBox.Text, out num1))
                MessageBox.Show("Error: First Number may only contain digits and a decimal point");
            else if (!Double.TryParse(num2TextBox.Text, out num2))
                MessageBox.Show("Error: Second Number may only contain digits and a decimal point");
            else
                resultLabel.Text = (num1 + num2).ToString();


        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            // TODO: Simplify this event handler by using a method
            Double num1 = 0.0, num2 = 0.0;
            if (!Double.TryParse(num1TextBox.Text, out num1))
                MessageBox.Show("Error: First Number may only contain digits and a decimal point");
            else if (!Double.TryParse(num2TextBox.Text, out num2))
                MessageBox.Show("Error: Second Number may only contain digits and a decimal point");
            else
                resultLabel.Text = (num1 * num2).ToString();

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            // TODO: Simplify this event handler by using a method
            Double num1 = 0.0, num2 = 0.0;
            if (!Double.TryParse(num1TextBox.Text, out num1))
                MessageBox.Show("Error: First Number may only contain digits and a decimal point");
            else if (!Double.TryParse(num2TextBox.Text, out num2))
                MessageBox.Show("Error: Second Number may only contain digits and a decimal point");
            else
                resultLabel.Text = (num1 - num2).ToString();

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            // TODO: Simplify this event handler by using a method
            Double num1 = 0.0, num2 = 0.0;
            if (!Double.TryParse(num1TextBox.Text, out num1))
                MessageBox.Show("Error: First Number may only contain digits and a decimal point");
            else if (!Double.TryParse(num2TextBox.Text, out num2))
                MessageBox.Show("Error: Second Number may only contain digits and a decimal point");
            else
                resultLabel.Text = (num1 / num2).ToString();

        }
    }
}
