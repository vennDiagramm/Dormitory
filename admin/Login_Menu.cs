using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry___Dormitory
{
    public partial class Login_Form : Form
    {
        private const string Password = "admin123";

        public Login_Form()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {

            if (txtPassword.Text == Password)
            {
                Main_Menu mainMenu = new Main_Menu();
                this.Hide();
                mainMenu.ShowDialog();
                this.Close();
            }
            else
            {

                MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
            }
        }
    }
}
