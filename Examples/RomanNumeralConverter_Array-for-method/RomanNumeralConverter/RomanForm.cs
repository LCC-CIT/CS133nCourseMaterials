using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumeralConverter
{
    public partial class RomanForm : Form
    {
        string[] roman = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };

        public RomanForm()
        {
            InitializeComponent();
        }

        private void toRomanButton_Click(object sender, EventArgs e)
        {
            int decimalNumber = int.Parse(inputTextBox.Text) - 1;
            if (decimalNumber < 1)
                outputTextBox.Text = "Too small";
            else if (decimalNumber >= roman.Length)
                outputTextBox.Text = "Too big";
            else
                outputTextBox.Text = roman[decimalNumber];
        }

        private void toDecimalButton_Click(object sender, EventArgs e)
        {
            for (int decNum = 0; decNum < roman.Length; decNum++)
                // Since roman contains strings, we can use String.Equals(...)
                if (roman[decNum].Equals(inputTextBox.Text))
                    outputTextBox.Text = (decNum + 1).ToString();
        }
    }
}
