using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcAvgScore_foreach
{
    public partial class foreachDemoForm : Form
    {
        Random rand = new Random();

        public foreachDemoForm()
        {
            InitializeComponent();
        }

        private void foreachDemoForm_Load(object sender, EventArgs e)
        {
            // Put 10 random scores into the list box
            int score = 0;
            for (int i = 0; i < 10; i++)
            {
                    score = rand.Next(100);
                    valuesListBox.Items.Add(score);
            }

            /****** Calcualte the average of the scores *****/
            // First, add up the values
            int total = 0;
            foreach (int value in valuesListBox.Items)
            {
                total += value;
            }

            // Second, calculate the average and display it
            float average = (float)total / valuesListBox.Items.Count;
            averageLabel.Text = average.ToString();
        }
    }
}
