using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoolDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void doSomethingButton_Click(object sender, EventArgs e)
        {
            const int MIN_NUM = 1;
            const int MAX_NUM = 9;
            int arabic = int.Parse(input1TextBox.Text);
            //if (arabic >= MIN_NUM && arabic <= MAX_NUM)
            if(arabic < MIN_NUM || arabic > MAX_NUM)
            {
                outputLabel.Text = "Please enter anumber from " +
                    MIN_NUM.ToString() + " to " + MAX_NUM.ToString();
            }
           else
            {
                string roman = "";

                switch (arabic)
                {
                    case 1: roman = "I";
                        break;
                    case 2: roman = "II";
                        break;
                    case 3: roman = "III";
                        break;
                    case 4: roman = "IV";
                        break;
                    case 5: roman = "V";
                        break;
                    case 6: roman = "VI";
                        break;
                }

                if (arabic == 7)
                    roman = "VII";
                else if (arabic == 8)
                    roman = "VIII";
                else if (arabic == 9)
                    roman = "IX";

                outputLabel.Text = roman.ToString();
            }
         }


    }
}
