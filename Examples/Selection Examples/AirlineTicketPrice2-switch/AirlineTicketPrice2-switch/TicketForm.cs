using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineTicketPrice
{
    public partial class TicketPriceForm : Form
    {
        public TicketPriceForm()
        {
            InitializeComponent();
        }

        // Calculate and display the price of a ticket
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal price = 0;

            // Determine the base price of the ticket based on destination
            // Asssume all flights originate in Eugene
            switch (cityListBox.SelectedIndex)
            {
                case 1:
                    price = 125;    // price to Portland
                    break;
                case 2:
                    price = 150;    // price to Bend
                    break;
                case 3:
                    price = 250;    // price to Pendleton
                    break;
                case 4:
                    price = 225;    // price to Ashland
                    break;
                case 5:
                    price = 175;    // price to Klamath Falls
                    break;
                default:
                    price = 0;
                    break;
            }

            // Get the user's entries and convert them to numbers
            int departureDays = int.Parse(departureTextBox.Text);
            int returnDays  = int.Parse(returnTextBox.Text);
            int age = int.Parse(ageTextBox.Text);

            // Calculate % increase or decrease in price
            if (departureDays <= 5)
                price *= 1.4M;
            if (returnDays - departureDays < 7)
                price *= 1.2M;
            if (age >= 65)
                price *= 0.85M;

            // Display the price
            priceLabel.Text = price.ToString("C");
        }

    }
}
