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
    public partial class Edit_Tenant_Room : Form
    {
        public Point mouseLocation;
        public Edit_Tenant_Room()
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

        private void btnE_Back_Click_Click(object sender, EventArgs e)
        {
            Form Main_Menu = new Main_Menu();
            Main_Menu.Show(this);
            Visible = false;
        }

        Koneksyon cn = new Koneksyon();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        private void editButton_Click(object sender, EventArgs e)
        {
            con = cn.getConnection();
            con.Open();

            try
            {
                // Check if both RoomNumber and PhoneNumber are valid integers
                if (int.TryParse(txtET_RoomNumber.Text, out int roomNumber) && int.TryParse(txtET_PhoneNum.Text, out int phoneNumber))
                {
                    // Check if the text fields are not empty
                    if (!string.IsNullOrEmpty(txtET_TenantName.Text) && !string.IsNullOrEmpty(txtET_PhoneNum.Text) && !string.IsNullOrEmpty(txtET_RentStatus.Text) && !string.IsNullOrEmpty(txtET_RoomNumber.Text))
                    {
                        // Check if the RoomNumber exists in the database
                        SqlCommand checkRoomNumber = new SqlCommand("SELECT COUNT(*) FROM DormTable WHERE RoomNumber = @RoomNumber", con);
                        checkRoomNumber.Parameters.AddWithValue("@RoomNumber", roomNumber);

                        int roomExists = (int)checkRoomNumber.ExecuteScalar(); // Returns the count of records with the RoomNumber

                        if (roomExists > 0)
                        {
                            // Proceed to update if RoomNumber exists
                            cmd = new SqlCommand("UPDATE DormTable SET TenantName = @TenantName, PhoneNumber = @PhoneNumber, StartingDate = @StartingDate WHERE RoomNumber = @RoomNumber", con);
                            cmd.Parameters.AddWithValue("@TenantName", txtET_TenantName.Text);
                            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                            cmd.Parameters.AddWithValue("@StartingDate", txtET_RentStatus.Text);
                            cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Tenant Information has been successfully updated!");

                            // Clear text fields after successful update
                            txtET_TenantName.Text = "";
                            txtET_PhoneNum.Text = "";
                            txtET_RentStatus.Text = "";
                            txtET_RoomNumber.Text = "";
                        }
                        else
                        {
                            // Show error message if RoomNumber doesn't exist in the database
                            MessageBox.Show("Invalid Room Number. This Room Number does not exist.");
                        }
                    }
                    else
                    {
                        // Show error message if any of the fields are empty
                        MessageBox.Show("Please fill in all the fields.");
                    }
                }
                else
                {
                    // Show error message if RoomNumber or PhoneNumber are not valid integers
                    MessageBox.Show("Please enter valid numeric values for Room Number and Phone Number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }
    }
}
