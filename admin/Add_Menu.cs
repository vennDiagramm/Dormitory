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
using System.Xml.Linq;

namespace Laundry___Dormitory
{
    public partial class frmAddBoarder : Form
    {
        public Point mouseLocation;
        public frmAddBoarder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Main_Menu = new Main_Menu();
            Main_Menu.Show(this);
            Visible = false;
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

        Koneksyon cn = new Koneksyon();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;


        private void btnAdd_Tenant_Click(object sender, EventArgs e)
        {
            try
            {
                con = cn.getConnection();
                con.Open();

                // Validate if room and phone numbers are valid integers
                if (int.TryParse(txtAddRoom.Text, out int roomNumber))
                {
                    if (roomNumber > 0 && roomNumber <= 20 && txtAddPhone.TextLength == 11)
                    {
                        // Ensure fields are not empty
                        if (!string.IsNullOrEmpty(txtAddRoom.Text) && !string.IsNullOrEmpty(txtAddTenant.Text) &&
                            !string.IsNullOrEmpty(txtAddPhone.Text))
                        {
                            // Check if the room number exists
                            string checkQuery = "SELECT TenantName FROM DormTable WHERE RoomNumber = @roomNumber";
                            using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                            {
                                checkCmd.Parameters.AddWithValue("@roomNumber", roomNumber);

                                object tenantNameObj = checkCmd.ExecuteScalar();

                                // Update if Room Number exists and TenantName is not empty
                                if (tenantNameObj != null && tenantNameObj is string tenantName && string.IsNullOrWhiteSpace(tenantName))
                                {
                                    cmd = new SqlCommand("update DormTable set TenantName = '" + txtAddTenant.Text + "', PhoneNumber = '" + txtAddPhone.Text + "', RentStatus = '" + "Occupied" + "' where RoomNumber = '" + roomNumber + "'", con);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Tenant updated successfully.");
                                }
                                // Insert new record if RoomNumber does not exist
                                else if (tenantNameObj == null || tenantNameObj == DBNull.Value || string.IsNullOrWhiteSpace(tenantNameObj.ToString()))
                                {
                                    double rentPrice = (string.IsNullOrEmpty(txtRentPrice.Text) || !double.TryParse(txtRentPrice.Text, out rentPrice)) ? 3000.00 : rentPrice;

                                    cmd = new SqlCommand("insert into DormTable (RoomNumber, TenantName, PhoneNumber, RentPrice, RentStatus) values (@roomNumber,@tenantName,@phoneNumber,@rentPrice,@rentStatus)", con);
                                    cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                                    cmd.Parameters.AddWithValue("@tenantName", txtAddTenant.Text);
                                    cmd.Parameters.AddWithValue("@phoneNumber", txtAddPhone.Text);
                                    cmd.Parameters.AddWithValue("@rentPrice", rentPrice);
                                    cmd.Parameters.AddWithValue("@rentStatus", "Occupied");
                                    cmd.ExecuteNonQuery();
                                }
                                else
                                {
                                    MessageBox.Show("Cannot update. The room is already occupied!");
                                }
                            }

                            // Clear and increment for next input
                            int counter = roomNumber + 1;
                            txtAddRoom.Text = counter.ToString();
                            txtAddTenant.Text = "";
                            txtAddPhone.Text = "";
                            txtRentPrice.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("All fields must be filled out.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Room Number must be within the range of 1 and 20 and the Phone Number must have 11 digits.");
                    }
                }
                else
                {
                    // Show error message if room number or phone number are invalid
                    MessageBox.Show("Please enter valid numeric values for Room Number and Phone Number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Catch any errors that occur during execution
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close(); // Ensure the connection is closed after operation
                }
            }
        }

    }
}
