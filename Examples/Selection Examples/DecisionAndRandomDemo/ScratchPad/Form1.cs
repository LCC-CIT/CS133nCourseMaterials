using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScratchPad
{

    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
         //   decimal cash = 0.01m;
          //  outputLabel.Text = cash.ToString("n4");
            /*
            if (cash > 100.0m)
                outputLabel.Text = "You're rich (sort of)";
            else if (cash == 0.0m)
               outputLabel.Text = "You're broke";
             else
               outputLabel.Text = "You're poor";
            */
            /*
            bool hasCreditCard = true;
            bool isBusy = false;
            bool hasEnoughCash = cash > 12.0m;
            if((hasEnoughCash || hasCreditCard) && !isBusy)
                outputLabel.Text = "Go out for dinner";
           */
/*
            string name = "Brian";
            string entry = inputTextBox.Text;
            
            if (string.Compare(name, entry) < 0)
                outputLabel.Text = " Brian comes first";
            else
                outputLabel.Text = entry + " comes first";
            
            outputLabel.Text = string.Compare(name, entry).ToString(); 
 */
            // Calcualte amount based on gallons and type
            decimal gallons = decimal.Parse(inputTextBox.Text);
            /*
            const decimal REGULAR_PRICE = 3.899m;
            const decimal PLUS_PRICE = 3.999m;
            const decimal PREMIUM_PRICE = 4.099m;
             * */
            decimal regularPrice = rand.Next(100, 1000) / 100.0m;
            decimal plusPrice = regularPrice + 0.10m;
            decimal premiumPrice = plusPrice + 0.10m;
            decimal amount = 0.0m;
            if (regularRadioButton.Checked)
                amount = gallons * regularPrice;
            else if (plusRadioButton.Checked)
                amount = gallons * plusPrice;
            else if (premiumRadioButton.Checked)
                amount = gallons * premiumPrice;

            
            // Payment method, for credit card add 0.50
            if (creditRadioButton.Checked == true)
                amount += 0.50m;

            outputLabel.Text = amount.ToString("c");
        }
    }
}