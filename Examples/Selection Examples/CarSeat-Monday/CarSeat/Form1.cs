using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
GET age
GET weight
IF age < 8 THEN
	IF weight < 40 THEN
		IF weight < 20 THEN
			DISPLAY "Use a rear-facing car seat"
		ELSE
			DISPLAY "Use a front-facing car seat"
		END IF
	ELSE
		DISPLAY "Use a booster seat"
	END IF
ELSE
	DISPLAY "No car seat or booster seat required"
END IF
DISPLAY "Thanks for asking"
*/

namespace CarSeat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adviceButton_Click(object sender, EventArgs e)
        {
            int age = int.Parse(ageTextBox.Text);
            int weight = int.Parse(weightTextBox.Text);
            int height = 57; // 4' 9" temporary, for testing

            if(age < 8 && height < 57)                         
                if(weight < 40)
                    if(weight < 20 || age < 1)
                        adviceLabel.Text = "Use a rear-facing car seat";
                    else
                        adviceLabel.Text = "Use a front-facing car seat";
                else
                    adviceLabel.Text = "Use a booster seat";                   
            else
                adviceLabel.Text = "no special seat required";
            MessageBox.Show("Thanks for asking!");
        }
    }
}
