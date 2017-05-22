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

        string[] maleNames = { "Simon", "Paul", "George", "Sam", "Pete", "John", "Daniel", "Ben" }; //Male names
        string[] femaleNames = { "Sally", "Lucy", "Georgia", "Abby", "Candy", "Samantha", "Holly" }; //Female names
        string[] lastNames = { "Hill", "Foreman", "Lee", "Adams", "Hall", "Shore", "Rogers" }; //Last names
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

            DialogResult dialogResult = MessageBox.Show("Are you a male?", "Gender", MessageBoxButtons.YesNo); //Prompts a yes or no window for male
            if (dialogResult == DialogResult.Yes) //If the user clicks 'yes'
            {
                firstName = (maleNames[rnd.Next(8)]); //Picks a random name from the 8 maleNames array
                lastName = (lastNames[rnd.Next(7)]); //Picks a random name from the 7 lastNames array
                MessageBox.Show(firstName + " " + lastName); //Shows a message box with the random firstName and lastName
                }
            
            else if (dialogResult == DialogResult.No) //If the user clicks 'no'
            {
                DialogResult dialogResult2 = MessageBox.Show("Are you a female?", "Gender", MessageBoxButtons.YesNo); //Prompts a yes or no window for female
                if (dialogResult2 == DialogResult.Yes) //If the user clicks 'yes'
                {
                    firstName2 = (femaleNames[rnd.Next(7)]); //Picks a random name from the 7 femaleNames array
                    lastName2 = (lastNames[rnd.Next(7)]); //Picks a random name from the 7 lastNames array
                    MessageBox.Show(firstName2 + " " + lastName2); //Shows a message box with the random firstName and lastName
                }
            } //Returns to the 'generate' button form
        }
    }
}
