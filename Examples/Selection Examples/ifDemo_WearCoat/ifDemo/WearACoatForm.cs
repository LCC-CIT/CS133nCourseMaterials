using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifDemo
{
    public partial class WearACoatForm : Form
    {
        public WearACoatForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int temperature = int.Parse(inputTextBox.Text);

            if (temperature < 32 || rainCheckBox.Checked)
                outputTextBox.Text = "Wear a coat";
            else
                outputTextBox.Text = "Enjoy the nice day";

        }
    }
}
