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
 GET diagnosis
IF diagnosis == "bacterial infection" THEN
	DISPLAY "Take an antibiotic"
ELSE IF diagnosis == "alergy" THEN
	DISPLAY "Take an antihistamine"
ELSE IF diagnosis == "viral infection" THEN
	DISPLAY "Take an decongestant"
END IF
*/

namespace RunnyNose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (diagnosisTextBox.Text == "Bacterial infection")
            {
                prescriptionLabel.Text = "Take an antibiotic";
            }
            else if (diagnosisTextBox.Text == "Allergy")
            {
                prescriptionLabel.Text = "Take an antihistamine";
            }
            else if (diagnosisTextBox.Text == "Viral infection")
            {
                prescriptionLabel.Text = "Take an decongestant";
            }
        }
    }
}
