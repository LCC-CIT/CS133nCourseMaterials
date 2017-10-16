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
// Completed exercise of breaking a problem into smaller pieces using methods

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
            const int MIN_AGE = 1, MAX_AGE = 125;
            const int MAX_YEAR = 3000, MIN_YEAR = 2014;

            // variables used for calculating the birth year
            int birthYear = 0, currentYear = 0, age = 0;
            
            // Clear the output label
            birthYearLabel.Text = "";

            // Get inputs
            currentYear = GetInput(currentYearTextBox.Text);
            age = GetInput(ageTextBox.Text);

            // Validate inputs
            if ( ValidateInput(MIN_YEAR, MAX_YEAR, currentYear) &&
                 ValidateInput(MIN_AGE, MAX_AGE, age)
            {
                // Calculate the birth year
                birthYear = CalcBirthYear(currentYear, age, hadBirthdayCheckBox.Checked);
                birthYearLabel.Text = birthYear.ToString();
            }
        }


        /* Guidelines for writing mehtods:
         * 1) Each method should just do one thing
         * 2) Don't do IO in methods unless it is a special method for just that purpose
         * 3) Use parameters and return a value rather than directly accessing class scoped variables
         */

        int CalcBirthYear(int currentYear, int age, bool hadBirthday)
        {
            int birthYear = 0;

            if (hadBirthdayCheckBox.Checked)
            {
                birthYear = currentYear - age;
            }
            else
            {
                birthYear = currentYear - age - 1;
            }
            return birthYear;
        }


        int GetInput(string text)
        {
            int inputValue = 0;
            // Convert test to an int and 
            // catch any errors cause by non-numeric user input
            if (!int.TryParse(text, out inputValue)
                MessageBox.Show("Please enter a valid numeric value");
            
           return inputValue;
        }


        bool ValidateInput(int min, int max, int inputValue)
        {
            // return true if the input is within the valid range
            return inputValue > min && inputValue < max;
        }
    }
}
