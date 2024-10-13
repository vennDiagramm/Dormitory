using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry___Dormitory.openWindow
{
    public partial class LandingPage : Form
    {
        public Point mouseLocation;
        public LandingPage()
        {
            InitializeComponent();
        }

        // TO lead to admin part
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // If the password is correct, open the Main_Menu and hide the login form
            Login_Menu loginMenu = new Login_Menu();
            this.Hide();
            loginMenu.ShowDialog();
            this.Close();  // Close the login form once the Main Menu is closed
        }

        // TO lead to customer part
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerMenu customerMenu = new CustomerMenu();
            this.Hide();
            customerMenu.ShowDialog();
            this.Close();
        }

        // Mouse moving
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


        // EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
