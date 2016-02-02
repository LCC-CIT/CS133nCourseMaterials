using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSeatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Algorithm
            GET age
            GET height
            GET weight
            IF age >= 8 AND height >= 57 THEN
   	            DISPLAY No special seat required!
            ELSE IF weight >= 40 THEN
	            DISPLAY Use a booster seat
            ELSE IF weight >= 20 AND age >= 1 THEN 
	            DISPLAY Use a front-facing car seat
            ELSE
	            DISPLAY Use a rear-facing car seat
            END IF
         */

        private void getAnswerButton_Click(object sender, EventArgs e)
        {
            const int NO_SEAT_AGE = 8;    // years
            const int NO_SEAT_HEIGHT = 57; // inches
            const int FRONT_FACING = 20;

            int age = int.Parse(ageTextBox.Text);
            int height = int.Parse(heightTextBox.Text);
            int weight = int.Parse(weightTextBox.Text);

            if (age >= NO_SEAT_AGE && height >= NO_SEAT_HEIGHT)
                displayLabel.Text = "No special seat required!";
            else if (weight >= 40)
                displayLabel.Text = "Use a booster seat";
            else if (age >= 1 && weight >=FRONT_FACING)
                displayLabel.Text = "Use a front-facing car seat";
            else
                displayLabel.Text = "Use a rear-facing car seat";

            MessageBox.Show("Thanks for asking");
 
        }
    }
}
