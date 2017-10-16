using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopulationGrowth
{
    public partial class PopulationForm : Form
    {

        public PopulationForm()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            const ulong POP_2014 = 7200000000;
            const uint START_YEAR = 2014;
            const double POP_GROWTH = 1.14 / 100;
            string outputLine = "";
            for (int years = 0; years < 10; years++)
            {
                outputLine = (START_YEAR + years).ToString() + "\t" + 
                                    (POP_2014 + POP_2014 * POP_GROWTH * years).ToString("n0");
                populationListBox.Items.Add(outputLine);
            }
        }

        
    }
}
