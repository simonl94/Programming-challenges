using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01HeadsAndTails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(System.IO.Directory.GetCurrentDirectory()); //Easy way to determine current directory
        }

        Random rnd = new Random(); //Creates the randomizer

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            int result = rnd.Next(0, 2); //If the number is between 0 and 1
            if (result == 1) //If the number is 1, do...
            {
                picCoin.Image = Image.FromFile(@"Images\heads.jpg"); //Puts the heads image onto the picture box from directory
                lblResult.Text = "Heads!"; //Change the label to say heads
            }
            else if (result == 0) //If the number is a 0, do...
            {
                picCoin.Image = Image.FromFile(@"Images\tails.jpg"); //Puts the tails image onto the picture box from directory
                lblResult.Text = "Tails!"; //Change the label to say heads
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void picCoin_Click(object sender, EventArgs e)
        {
        }
    }
}
