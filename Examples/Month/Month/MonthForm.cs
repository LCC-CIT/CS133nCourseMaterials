using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Month
{
    public partial class MonthForm : Form
    {
        const int MONTHS_IN_YEAR = 12;
        const int DAYS_IN_WEEK = 7;

        // Days in each month. January is at index 0, Febuary at 1, etc.
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        // The day of the week that each month starts on. 
        int[] startingDayOfMonth = new int[12];

        public MonthForm()
        {
            InitializeComponent();
        }

        private void monthListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "\tSu\tM\tTu\tW\tTh\tF\tSa\r\n";    // Header text

            int month = monthListBox.SelectedIndex;     // Month selected by the user

            // Put tabs (empty sapaces) in the first row up to the starting day of the month
            for (int day = 0; day < startingDayOfMonth[month]; day++)
                textBox1.Text += "\t";

            // Put a number for each day in the month in the text box
            for (int day = 1; day <= daysInMonth[month]; day++)
            {
                textBox1.Text += "\t" + day;
                // Start a new row after every 7th day (except on the first row)
                if ((day + startingDayOfMonth[month]) % DAYS_IN_WEEK == 0)
                    textBox1.Text += "\r\n";
            }
        }

        private void MonthForm_Load(object sender, EventArgs e)
        {
            const int FIRST_DAY_OF_2013 = 2; // 0 = Sunday, 1 = Monday, 2 = Tuesday, etc.
            startingDayOfMonth[0] = FIRST_DAY_OF_2013;  // initalize the first element of the array
            // fill this array once when the program starts
            for (int month = 1; month < MONTHS_IN_YEAR; month++)
                startingDayOfMonth[month] = (startingDayOfMonth[month - 1] + daysInMonth[month - 1]) % DAYS_IN_WEEK;

            /* //Just for testing and debugging
            string startingDays = "";
            foreach(int month in startingDayOfMonth)
                startingDays += month + ", ";
            MessageBox.Show(startingDays);
            */
        }
    }
}
