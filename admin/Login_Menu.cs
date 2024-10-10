using Laundry___Dormitory.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry___Dormitory
{
   
    public partial class Login_Menu : Form
    {
        public Point mouseLocation;
        private const string Password = "admin123";
        public Login_Menu()
        {
            InitializeComponent();
            Passwordtxtbox.KeyDown += Passwordtxtbox_KeyDown;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            // Check if the entered password matches the predefined password
            if (Passwordtxtbox.Text == Password)
            {
                // If the password is correct, open the Main_Menu and hide the login form
                Main_Menu mainMenu = new Main_Menu();
                this.Hide();
                mainMenu.ShowDialog();
                this.Close();  // Close the login form once the Main Menu is closed
            }
            else
            {
                // If the password is incorrect, show a message
                MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Passwordtxtbox.Clear();  // Clear the password field for another attempt
            }
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void Passwordtxtbox_MouseClick(object sender, MouseEventArgs e)
        {
            Passwordtxtbox.Clear();
        }

        private void Passwordtxtbox_TextChanged(object sender, EventArgs e)
        {
            Passwordtxtbox.PasswordChar = '*';
        }

        private void Passwordtxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbtn_Click(this, new EventArgs());
            }
        }
    }
}
