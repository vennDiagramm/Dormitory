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
                string inputPhoneNum = txtET_PhoneNum.Text.Trim(); // malibat ko kung e diritso nko
                string inputRoomNum = txtET_RoomNumber.Text.Trim();

                // gi boolean nko kay cgeg error
                bool isPhoneNumValid = (inputPhoneNum.Length == 11 && inputPhoneNum.All(char.IsDigit));
                bool isRoomNumValid = (inputRoomNum.All(char.IsDigit) && !string.IsNullOrEmpty(inputRoomNum));
                
                if (!string.IsNullOrEmpty(txtET_TenantName.Text.Trim()) &&
                        !string.IsNullOrEmpty(txtET_RentStatus.Text.Trim())) // Check to see if fields are not empty
                {
                    // Check if other fields are not empty
                    if (isPhoneNumValid && isRoomNumValid)
                    {
                        // Check if the RoomNumber exists in the database
                        SqlCommand checkRoomNumber = new SqlCommand("SELECT COUNT(*) FROM DormTable WHERE RoomNumber = @RoomNumber", con);
                        checkRoomNumber.Parameters.AddWithValue("@RoomNumber", inputRoomNum);

                        int roomExists = (int)checkRoomNumber.ExecuteScalar(); // Check if the RoomNumber exists

                        if (roomExists > 0)
                        {
                            // Proceed to update if RoomNumber exists
                            SqlCommand cmd = new SqlCommand("UPDATE DormTable SET TenantName = @TenantName, PhoneNumber = @PhoneNumber, RentStatus = @RentStatus WHERE RoomNumber = @RoomNumber", con);
                            cmd.Parameters.AddWithValue("@TenantName", txtET_TenantName.Text.Trim());
                            cmd.Parameters.AddWithValue("@PhoneNumber", inputPhoneNum);
                            cmd.Parameters.AddWithValue("@RentStatus", txtET_RentStatus.Text.Trim());
                            cmd.Parameters.AddWithValue("@RoomNumber", inputRoomNum);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Tenant Information has been successfully updated!");

                            // Clear the text fields after the update
                            txtET_TenantName.Text = "";
                            txtET_PhoneNum.Text = "";
                            txtET_RentStatus.Text = "";
                            txtET_RoomNumber.Text = "";
                        }
                        else
                        { // checking if ga exist
                            MessageBox.Show("Please enter a valid Room Number and Phone Number.");
                        }
                    }
                    else
                    {   // Invalid PhoneNumber or RoomNumber
                        if (!isPhoneNumValid || !isRoomNumValid)
                        {
                            MessageBox.Show("Please enter a valid Room Number and Phone Number.");
                        }                     
                    }
                }
                else
                {   // One or more fields are empty
                    MessageBox.Show("Please fill in all the required fields.");
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

        // PANG MOVE SA WINDOW
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

        // Back to Menu
        private void btnE_Back_Click_Click(object sender, EventArgs e)
        {
            Form Main_Menu = new Main_Menu();
            Main_Menu.Show(this);
            Visible = false;
        }
    }
}
