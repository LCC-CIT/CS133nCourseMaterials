using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeZone_Tutorial4_6
{
    public partial class TimeZoneForm : Form
    {
        public TimeZoneForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city;
            int relativeToUtc = 0;

            if (cityListBox.SelectedIndex != -1)
            {
                // Get the item that was selected
                city = cityListBox.SelectedItem.ToString();

                // Determine the time zone

                switch (city)
                {
                    case "Honolulu":
                        timeZoneLabel.Text = "Hawaii-Aleutian";
                        relativeToUtc = -10;
                        break;
                    case "San Francisco":
                        timeZoneLabel.Text = "Pacific";
                        relativeToUtc = -8;
                        break;
                    case "Denver":
                        timeZoneLabel.Text = "Mountain";
                        relativeToUtc = -7;
                        break;
                    case "Minneapolis":
                        timeZoneLabel.Text = "Central";
                        relativeToUtc = -6;
                        break;
                    case "New York":
                        timeZoneLabel.Text = "Eastern";
                        relativeToUtc = -5;
                        break;
                }
                offsetUtcLabel.Text = relativeToUtc.ToString();
            }
            else
            {
                MessageBox.Show("No city was selected");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
