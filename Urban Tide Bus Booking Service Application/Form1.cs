using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urban_Tide_Bus_Booking_Service_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2Password_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Get the username and password entered by the user
            string username = textBox1Username.Text;
            string password = textBox2Password.Text;

            // Check if the username and password are correct
            if (username == "user" && password == "12345")
            {
                // If correct, open the main menu form
                Form2MainMenu mainMenuForm = new Form2MainMenu();
                mainMenuForm.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                // Display an error message if the login fails
                MessageBox.Show("Incorrect username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonLoginGuest_Click(object sender, EventArgs e)
        {
            // Guest login functionality
            string username = textBox1Username.Text;
            string password = textBox2Password.Text;

            if (username == "name" && password == "password")
            {
                Form3 guestForm = new Form3();
                guestForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password for guest login. Please try again.", "Guest Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
   