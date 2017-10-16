using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Written by Brian Bird, 1/4/2015
// C# Programming Demo
// Starter file for breaking a problem into smaller pieces using methods

namespace BirthdateCalculator
{
    public partial class BirthDateCalcForm : Form
    {
        public BirthDateCalcForm()
        {
            InitializeComponent();
        }

        private void calcYearButton_Click(object sender, EventArgs e)
        {
            // define constants for input validation
            const int MIN_AGE = 1;
            const int MAX_AGE = 125;
            const int MAX_YEAR = 3000;
            const int MIN_YEAR = 2014;

            // variables used for calculating the birth year
            int birthYear = 0;
            int currentYear = 0;
            int age = 0;
            
            // Clear the output label
            birthYearLabel.Text = "";

            // catch any errors cause by non-numeric user input
            if ( int.TryParse(currentYearTextBox.Text, out currentYear) &&
                int.TryParse(ageTextBox.Text, out age) )
            {
                // Validate the user input
                if ( (age > MIN_AGE && age < MAX_AGE) && 
                    (currentYear > MIN_YEAR && currentYear < MAX_YEAR) )
                {
                    // Now calculate the birth year
                    if (hadBirthdayCheckBox.Checked)
                    {
                        birthYear = currentYear - age;
                    }
                    else
                    {
                        birthYear = currentYear - age - 1;
                    }
                    birthYearLabel.Text = birthYear.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }
    }
}
