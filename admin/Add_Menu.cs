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
                if (int.TryParse(txtAddRoom.Text, out int roomNumber))//Changed by gavin
                {
                    if (roomNumber > 0 && txtAddPhone.Text != null)//change by gavin
                    {
                        // Ensure fields are not empty
                        if (!string.IsNullOrEmpty(txtAddRoom.Text) && !string.IsNullOrEmpty(txtAddTenant.Text) &&
                            !string.IsNullOrEmpty(txtAddPhone.Text) && !string.IsNullOrEmpty(txtSD.Text))
                        {
                            // Check for duplicate Room Number and Tenant Name before inserting
                            string checkQuery = "SELECT COUNT(*) FROM DormTable WHERE RoomNumber = @roomNumber";
                            using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                            {
                                // Use parameters to prevent SQL injection
                                checkCmd.Parameters.AddWithValue("@roomNumber", roomNumber);                               

                                int count = (int)checkCmd.ExecuteScalar(); // Execute the query and get the result

                                if (count > 0) // If a duplicate exists
                                {
                                    MessageBox.Show("This Room is already occupied. Please double check.");
                                    return; // Stop further execution to prevent the insert
                                }
                            }

                            // If no duplicate, proceed with the insert || gi specify nko para insert into this table lang
                            cmd = new SqlCommand("insert into DormTable (RoomNumber, TenantName, PhoneNumber, RentStatus) values ('" 
                                + txtAddRoom.Text + "','" + txtAddTenant.Text + "','" + txtAddPhone.Text + "','" 
                                + txtSD.Text  + "')", con);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Tenant Added!");

                            txtAddRoom.Text = "";
                            txtAddTenant.Text = "";
                            txtAddPhone.Text = "";
                            txtSD.Text = "";

                            cmd.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("All fields must be filled out.");
                        }
                    } else
                    {
                        MessageBox.Show("Room Number and Phone Number must be greater than 0.");
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
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close(); // Ensure the connection is closed after operation
                }
            }
        }

    }
}
