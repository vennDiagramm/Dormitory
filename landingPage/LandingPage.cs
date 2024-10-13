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
        public LandingPage()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // If the password is correct, open the Main_Menu and hide the login form
            Login_Menu loginMenu = new Login_Menu();
            this.Hide();
            loginMenu.ShowDialog();
            this.Close();  // Close the login form once the Main Menu is closed
        }
    }
}
