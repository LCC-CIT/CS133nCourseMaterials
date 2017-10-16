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
        const decimal BASE_PRICE = 100.00m;     // Base price of a ticket

        public TicketPriceForm()
        {
            InitializeComponent();
        }

        private void departureUpDown_ValueChanged(object sender, EventArgs e)
        {
            // TODO: Call the method that calculates the ticket price
            decimal price = BASE_PRICE;

            if (departureUpDown.Value <= 5)
                price *= 1.4M;
            if (returnUpDown.Value - departureUpDown.Value < 7)
                price *= 1.2M;
            if (ageUpDown.Value >= 65)
                price *= 0.85M;

            priceLabel.Text = price.ToString("c");
        }

        private void returnUpDown_ValueChanged(object sender, EventArgs e)
        {
            // TODO: Call the method that calculates the ticket price
            decimal price = BASE_PRICE;

            if (departureUpDown.Value <= 5)
                price *= 1.4M;
            if (returnUpDown.Value - departureUpDown.Value < 7)
                price *= 1.2M;
            if (ageUpDown.Value >= 65)
                price *= 0.85M;

            priceLabel.Text = price.ToString("c");
        }

        private void ageUpDown_ValueChanged(object sender, EventArgs e)
        {
            // TODO: Call the method that calculates the ticket price
            decimal price = BASE_PRICE;

            if (departureUpDown.Value <= 5)
                price *= 1.4M;
            if (returnUpDown.Value - departureUpDown.Value < 7)
                price *= 1.2M;
            if (ageUpDown.Value >= 65)
                price *= 0.85M;

            priceLabel.Text = price.ToString("c");
        }

        void calcPrice()
        {
            // TODO: Write a body for the method
        }

        // TODO: Try to get a parameterless method to work without putting
        //       the price variable at class scope. Why won't it work? 
        //       Now add a paramter. Why won't it work now without a variable at class scope?
        //       Now add a return value.
       
    }
}
