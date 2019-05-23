using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalc
{
    //programming challenge 03 AgeCalculator  //@github/simonl94

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        public void btnCalc_Click(object sender, EventArgs e)
        {
            lblSeconds.Text = ""+calcAge();
        }

        public double calcAge()
        {
            DateTime thisDay = DateTime.Now;
            
            return thisDay.Subtract(dateTimePicker1.Value).TotalSeconds;

        }
    }
}
