using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConvMod
{
    //programming challenge 02 TemperatureConverter  //@github/simonl94
    
    public partial class Form1 : Form
    {

        Boolean updated = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxLeft_TextChanged(object sender, EventArgs e)
        {
            var input = txtBoxLeft.Text;
            double n;

            updated = false;

            if (!updated)
            {
                if (Double.TryParse(input, out n))
                {
                    updated = true;
                    txtBoxRight.Text = convertToFarenheight(n).ToString();
                }
            }
            else
            {
                updated = false;
            }
        }

        private void txtBoxRight_TextChanged(object sender, EventArgs e)
        {
            var input = txtBoxRight.Text;
            double n;

            updated = false;

            if (!updated)
            {
                if (Double.TryParse(input, out n))
                {
                    updated = true;
                    txtBoxLeft.Text = convertToCelcius(n).ToString();
                }
            }
            else
            {
                updated = false;
            }
        }

        private double convertToFarenheight(double pCelcius)
        {
            return Math.Round((pCelcius * 9 / 5) + 32, 2);
        }

        private double convertToCelcius(double pFar)
        {
            return Math.Round((pFar - 32) * 5 / 9, 2);
        }
    }
}

