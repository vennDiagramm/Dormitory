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

            cmd = new SqlCommand("SELECT Status FROM Rooms WHERE RoomNumber = @RoomNumber", con);
            cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
            string currentStatus = cmd.ExecuteScalar()?.ToString();

            if (currentStatus == "Occupied")
            {
                string updateStatusQuery = "UPDATE Rooms SET Status = 'Under Maintenance' WHERE RoomNumber = @RoomNumber";
                using (SqlCommand updateCmd = new SqlCommand(updateStatusQuery, con))
                {
                    updateCmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Cancellation is complete, room will be available soon.");
                }

            }
            else if (currentStatus == "Pending")
            {
                string updateStatusQuery = "UPDATE Rooms SET Status = 'Available' WHERE RoomNumber = @RoomNumber";
                using (SqlCommand updateCmd = new SqlCommand(updateStatusQuery, con))
                {
                    updateCmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Cancellation is complete, room is now available.");
                }
            }
            cmd.Dispose();
            con.Close();
        }

        private void RentBtn_Click(object sender, EventArgs e)
        {
            con = cn.getConnection();
            con.Open();

            // Get the selected room number from the DataGridView
            int roomNumber = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);

            // Query to check the current status of the room
            cmd = new SqlCommand("SELECT Status FROM Rooms WHERE RoomNumber = @RoomNumber", con);

            // Add parameter for the room number
            cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

            // Execute the query and get the current status
            string currentStatus = cmd.ExecuteScalar()?.ToString();

            if (currentStatus == "AVAILABLE")
            {
                // Proceed to update the room status to "Occupied"
                string updateStatusQuery = "UPDATE Rooms SET Status = 'Pending' WHERE RoomNumber = @RoomNumber";
                using (SqlCommand updateCmd = new SqlCommand(updateStatusQuery, con))
                {
                    updateCmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Room status updated to 'Occupied'.");
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

        private void Viewbtn_Click(object sender, EventArgs e)
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
            dataGridView1.Dispose();
            cmd.Dispose();
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
