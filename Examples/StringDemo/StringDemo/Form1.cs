using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringDemo
{
    public partial class StringDemoForm : Form
    {
        string demoString = "This is a 10 point test";

        public StringDemoForm()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = demoString.EndsWith("test").ToString() + "\r\n";
            outputTextBox.Text += demoString.IndexOf('a').ToString() +"\r\n";
            outputTextBox.Text += demoString.Replace("a", "the") + "\r\n";
            outputTextBox.Text += demoString.IndexOf(" is ") + "\r\n";
            outputTextBox.Text += demoString.Substring(13, 5) + "\r\n";
            outputTextBox.Text += char.IsDigit( demoString[11] ) + "\r\n";
            outputTextBox.Text += demoString.IndexOf("cat") + "\r\n";
        }
    }
}
