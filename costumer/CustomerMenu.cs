using Laundry___Dormitory.admin;
using Laundry___Dormitory.openWindow;
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
    public partial class CustomerMenu : Form
    {
        Koneksyon cn = new Koneksyon();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            con = cn.getConnection();
            con.Open();

            int roomNumber = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);

            cmd = new SqlCommand("SELECT RentStatus FROM DormTable WHERE RoomNumber = @RoomNumber", con);
            cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
            string currentStatus = cmd.ExecuteScalar()?.ToString();

            if (currentStatus == "Occupied")
            {
                string updateStatusQuery = "UPDATE DormTable SET RentStatus = 'Available', TenantName = '', PhoneNumber = '' WHERE RoomNumber = @RoomNumber";
                using (SqlCommand updateCmd = new SqlCommand(updateStatusQuery, con))
                {
                    updateCmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Cancellation is complete, room will be available soon.");
                }

            }
            else if (currentStatus == "Pending")
            {
                string updateStatusQuery = "UPDATE Dormtable SET RentStatus = 'Available' WHERE RoomNumber = @RoomNumber";
                using (SqlCommand updateCmd = new SqlCommand(updateStatusQuery, con))
                {
                    updateCmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Cancellation is complete, room is now available.");
                }
            }
            else
            {
                MessageBox.Show("Room is already available");
            }
            cmd.Dispose();
            con.Close();
        }

        private void RentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con = cn.getConnection();
                con.Open();

                // Get the selected room number from the DataGridView
                int roomNumber = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);

                // Query to check the current status of the room
                cmd = new SqlCommand("SELECT RentStatus FROM DormTable WHERE RoomNumber = @RoomNumber", con);

                // Add parameter for the room number
                cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

                // Execute the query and get the current status
                string currentStatus = cmd.ExecuteScalar()?.ToString();

                if (currentStatus == "Available")
                {
                    if (!string.IsNullOrEmpty(txtCustomerName.Text) && !string.IsNullOrEmpty(txtPhoneNumber.Text) && txtPhoneNumber.TextLength == 11)
                    {
                        // Proceed to update the room status to "Occupied"
                        string updateStatusQuery = "UPDATE DormTable SET RentStatus = 'Pending', TenantName = @name, PhoneNumber = @phone  WHERE RoomNumber = @RoomNumber";

                        using (SqlCommand updateCmd = new SqlCommand(updateStatusQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                            updateCmd.Parameters.AddWithValue("@name", txtCustomerName.Text);
                            updateCmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);
                            updateCmd.ExecuteNonQuery();
                            MessageBox.Show("Room status updated to 'Pending'. \n Please wait until further notice");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill in your Name and Phone No. \n\n And Phone Number Must be 11 Digits long");
                    }
 

                }
                else if (currentStatus == "Occupied")
                {
                    MessageBox.Show("Room is already occupied, please select another.");
                }
                else
                {
                    MessageBox.Show("Room is Under Maintenance, please select another.");
                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a row in the table.");
            }
        }

        // Hello, gi change nako kasi mag error. Ga create din ng other column. Gi reader ra nko
        // Dili na siya ga duplicate ug columns, ga change sab kos variable names kunti. Ang old code naa sa ubos
        private void Viewbtn_Click(object sender, EventArgs e)
        {
            con = cn.getConnection();
            con.Open();

            switch (statusBox.Text)
            {
                case "Available":
                    cmd = new SqlCommand("SELECT RentStatus, RoomNumber, RentPrice FROM DormTable WHERE RentStatus = 'Available'", con);
                    reader = cmd.ExecuteReader();
                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                    }
                    break;

                case "Occupied":
                    cmd = new SqlCommand("SELECT RentStatus, RoomNumber, RentPrice FROM DormTable WHERE RentStatus = 'Occupied'", con);
                    reader = cmd.ExecuteReader();
                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                    }
                    break;

                case "All":
                    cmd = new SqlCommand("SELECT RentStatus, RoomNumber, RentPrice FROM DormTable", con);
                    reader = cmd.ExecuteReader();
                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                    }
                    break;
            }

            cmd.Dispose();
            reader.Close();
            con.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            this.Hide();
            landingPage.ShowDialog();
            this.Close();
        }
    }
}


// FIRST VERSION
/**
 private void Viewbtn_Click(object sender, EventArgs e)
{
    try
    {
        con = cn.getConnection();
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        switch (StatusBox1.Text)
        {
            case "Available":
                cmd = new SqlCommand("SELECT RoomStatus, RoomNumber, RoomPrice FROM DormTable WHERE Status = 'Available'", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                break;

            case "Occupied":
                cmd = new SqlCommand("SELECT RoomStatus, RoomNumber, RoomPrice FROM DormTable WHERE Status = 'Occupied'", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                break;
            case "All":
                cmd = new SqlCommand("SELECT RoomStatus, RoomNumber, RoomPrice FROM DormTable", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                break;
        }
    } catch(Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {
        dataGridView1.Dispose();
        cmd.Dispose();
        con.Close();
    }
}
*/