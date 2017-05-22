using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00NameGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Random rand = new Random(DateTime.Now.Second);

        string[] maleNames = { "Simon", "Paul", "George", "Sam", "Pete", "John", "Daniel", "Ben" };
        string[] femaleNames = { "Sally", "Lucy", "Georgia", "Abby", "Candy", "Samantha", "Holly" };
        string[] lastNames = { "Hill", "Foreman", "Lee", "Adams", "Hall", "Shore", "Rogers" };
        string firstName;
        string lastName;
        string firstName2;
        string lastName2;
        Random rnd = new Random();

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void generate_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you a male?", "Gender", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                firstName = (maleNames[rnd.Next(8)]);
                lastName = (lastNames[rnd.Next(7)]);
                MessageBox.Show(firstName + " " + lastName);
                }
            
            else if (dialogResult == DialogResult.No)
            {
                DialogResult dialogResult2 = MessageBox.Show("Are you a female?", "Gender", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    firstName2 = (femaleNames[rnd.Next(7)]);
                    lastName2 = (lastNames[rnd.Next(7)]);
                    MessageBox.Show(firstName2 + " " + lastName2); 
                }
            }
        }
    }
}
