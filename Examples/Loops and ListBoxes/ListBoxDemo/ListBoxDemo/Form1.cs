using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxDemo
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void doButton_Click(object sender, EventArgs e)
        {
            int myNumber = int.Parse(inputTextBox.Text);
          //  outputListBox.Items.Add(myNumber);
            int index = 0;
            while (index < outputListBox.Items.Count && 
                          myNumber > int.Parse((string)outputListBox.Items[index])
                         )
            {
                index++;
            }
            if (index < outputListBox.Items.Count)
                outputListBox.Items.Insert(index, myNumber.ToString());
            else
                outputListBox.Items.Add(myNumber.ToString());
        }

        private void outputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputLabel.Text = outputListBox.SelectedIndex.ToString();
        }

        private void randomChoiceButton_Click(object sender, EventArgs e)
        {
                                  // min value, max value + 1
            int choice = rand.Next(0, outputListBox.Items.Count);
            outputListBox.SelectedIndex = choice;
        }
    }
}
