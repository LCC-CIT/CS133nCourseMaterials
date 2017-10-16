using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snowfall_outParam
{
    public partial class SnowfallForm : Form
    {
        public SnowfallForm()
        {
            InitializeComponent();
        }

        private void showSnowButton_Click(object sender, EventArgs e)
        {
            const double WEIGHT_PER_CU_FT = 10.0;
            const double SNOWFALL_RATE = 0.25;

            double snowWeight = 0.0;
            double snowDepth = 0.0;

            for (int hours = 1; hours <= 12; hours++)
            {
                snowDepth = snowCalc(hours, SNOWFALL_RATE, WEIGHT_PER_CU_FT, out snowWeight);
                string result = hours.ToString() + "\t" + snowDepth.ToString("N2") +
                        " in\t" + snowWeight.ToString("N3") + " lbs";
                snowListBox.Items.Add(result);
            }
        }

        double snowCalc(int elapsedHours, double snowfallRate, double weightPerCuFoot, 
                    out double calculatedWeight)
        {
            double depth = elapsedHours * snowfallRate;
            calculatedWeight = weightPerCuFoot * depth / 12.0; // the 12 is for inches in a foot
            return depth;
        }
    }
}
