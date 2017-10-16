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

        private void departureUpDown_ValueChanged(object sender, EventArgs e)
        {
            priceLabel.Text = calcPrice();
        }

        private void returnUpDown_ValueChanged(object sender, EventArgs e)
        {
            priceLabel.Text = calcPrice();
        }

        private void ageUpDown_ValueChanged(object sender, EventArgs e)
        {
            priceLabel.Text = calcPrice();
        }

        string calcPrice()
        {
            const decimal basePrice = 1000;
            decimal price = basePrice;

            if (departureUpDown.Value <= 5)
                price *= 1.4M;
            if (returnUpDown.Value - departureUpDown.Value < 7)
                price *= 1.2M;
            if (ageUpDown.Value >= 65)
                price *= 0.85M;

            return price.ToString("C");
        }


    }
}
