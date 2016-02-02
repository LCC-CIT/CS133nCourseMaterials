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
          //  bool test = false;

          //  test = input1TextBox.Text == input2TextBox.Text;

            int order = string.Compare(input1TextBox.Text,
                input2TextBox.Text);

            outputLabel.Text = order.ToString();
        }
    }
}
