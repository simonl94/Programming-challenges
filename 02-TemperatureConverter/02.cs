using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_TempConv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void celToFah()
        {
            int x;
            int y = Convert.ToInt32(txtBox1.Text); //Converts textbot input to int from string    
            string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem); //Gets text from drop down list 1
            string selected2 = this.comboBox2.GetItemText(this.comboBox2.SelectedItem); //Gets text from drop down list 2        

            if (selected == "Celsius" && selected2 == "Fahrenheit")
            {
                x = y * 9 / 5 + 32; //calculates fahrenheit 
                MessageBox.Show(y + " degrees celsius is " + x.ToString() + " degrees farenheit");
            }

            else if (selected == "Fahrenheit" && selected2 == "Celsius")
            {
                x = (y - 32) * 5 / 9; //calculates celsius
                MessageBox.Show(y + " degrees farenheit is " + x.ToString() + " degrees celsius");
            }

             if (selected == selected2)
            {
                MessageBox.Show("Can not convert the same temperatures, dummy!"); //Throws a message if you convert same temperatures
            }
             
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            celToFah(); //Calls the calculation method
        }
    }
}
        

    
   
   

