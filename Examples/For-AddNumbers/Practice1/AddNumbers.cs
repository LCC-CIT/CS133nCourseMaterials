using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    public partial class AddNumbersForm : Form
    {
        public AddNumbersForm()
        {
            InitializeComponent();
        }



        private void numberComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            numberComboBox.Items.Add(int.Parse(numberComboBox.Text));
            numberComboBox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < numberComboBox.Items.Count; i++)
                sum += (int)numberComboBox.Items[i];
                //resultLabel.Text += numberComboBox.Items[i] += ", ";
            resultLabel.Text = sum.ToString();
        }
        
    }
}
