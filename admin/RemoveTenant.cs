using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Laundry___Dormitory.admin;

namespace Laundry___Dormitory
{
    public partial class RemoveTenant : Form
    {
        public Point mouseLocation;
        public RemoveTenant()
        {
            InitializeComponent();
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

        private void btnRM_Back_Click(object sender, EventArgs e)
        {
            Form Main_Menu = new Main_Menu();
            Main_Menu.Show(this);
            Visible = false;
        }

        Koneksyon cn = new Koneksyon();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        private void btnRM_Delete_Click(object sender, EventArgs e)
        {
            con = cn.getConnection();
            con.Open();

            try
            {
                // Ensure the RoomNumber field is not empty and is a valid integer
                if (int.TryParse(txtRM_RoomNumber.Text, out int roomNumber))
                {
                    if (!string.IsNullOrEmpty(txtRM_RoomNumber.Text))
                    {
                        // Check if the TenantName is not empty for the specified RoomNumber
                        SqlCommand checkTenantCmd = new SqlCommand("SELECT COUNT(*) FROM DormTable WHERE RoomNumber = @RoomNumber AND TenantName IS NOT NULL AND TenantName != ''", con);
                        checkTenantCmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

                        int tenantExists = (int)checkTenantCmd.ExecuteScalar(); // Returns the count of records with RoomNumber and a non-empty TenantName

                        if (tenantExists > 0)
                        {
                            // Proceed to delete if the TenantName exists
                            SqlCommand deleteCmd = new SqlCommand("UPDATE DormTable SET TenantName = @TenantName, PhoneNumber = @PhoneNumber, RentStatus = @RentStatus WHERE RoomNumber = @RoomNumber", con);
                            deleteCmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                            deleteCmd.Parameters.AddWithValue("@TenantName", "");
                            deleteCmd.Parameters.AddWithValue("@PhoneNumber", "00000000000");
                            deleteCmd.Parameters.AddWithValue("@RentStatus", "Available");

                            deleteCmd.ExecuteNonQuery();
                            MessageBox.Show("Tenant information has been successfully deleted!");

                            // Clear the textboxes after deletion                         
                            txtRM_RoomNumber.Text = "";

                            deleteCmd.Dispose();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("This tenant does not exist or has an empty Tenant Name. Please double-check.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Room Number field must be filled.");
                    }
                }
                else
                {
                    // Show error message if RoomNumber is not a valid number
                    MessageBox.Show("Please enter a valid numeric value for Room Number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Catch and show any exceptions
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close(); // Ensure the connection is closed
                }
            }
        }

    }
}

