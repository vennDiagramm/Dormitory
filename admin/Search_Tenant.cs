using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Laundry___Dormitory.admin;

namespace Laundry___Dormitory
{
    public partial class Search_Tenant : Form
    {
        public Point mouseLocation;
        public string[] result = new string[4]; // Class-level array to hold search result

        Koneksyon cn = new Koneksyon();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public Search_Tenant()
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

        private void btnST_Back_Click(object sender, EventArgs e)
        {
            Form Main_Menu = new Main_Menu();
            Main_Menu.Show(this);
            Visible = false;
        }



        private void btnST_Search_Click(object sender, EventArgs e)
        {
            con = cn.getConnection();
            con.Open();

            try
            {
                // Check if txtST_RoomNumber is a valid integer
                if (int.TryParse(txtST_RoomNumber.Text, out int roomNumber))
                {
                    if (roomNumber > 0)
                    {
                        if (!string.IsNullOrEmpty(txtST_RoomNumber.Text))
                        {
                            cmd = new SqlCommand("SELECT * FROM DormTable WHERE RoomNumber = @RoomNumber", con);
                            cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

                            reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                // Read the data if the combination exists
                                while (reader.Read())
                                {
                                    // Check if TenantName is empty
                                    if (reader["TenantName"].ToString() == "")
                                    {
                                        MessageBox.Show("No tenant exists in the selected room.");
                                        return; // Stop further execution
                                    }

                                    result[0] = reader[0].ToString();
                                    result[1] = reader[1].ToString();
                                    result[2] = reader[2].ToString();
                                    result[3] = reader[3].ToString();
                                }

                                Form Main_Menu = new Main_Menu();
                                Main_Menu.Show(this);
                                Visible = false;
                            }
                            else
                            {
                                // If no rows are found, show an error message
                                MessageBox.Show("No tenant found with the given Room Number.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Room Number must be filled.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is no such thing as a negative room number. Please double check.");
                    }
                }
                else
                {
                    // Show an error if RoomNumber is not a valid integer
                    MessageBox.Show("Please enter a valid numeric value for Room Number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display any exception message
            }
            finally
            {
                // Ensure the connection and reader are closed properly
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }

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

