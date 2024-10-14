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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Laundry___Dormitory.admin
{
    public partial class Approval_Window : Form
    {
        Koneksyon cn = new Koneksyon();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public Point mouseLocation;
        public Approval_Window()
        {
            InitializeComponent();
        }

        // Mouse moving
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form Main_Menu = new Main_Menu();
            Main_Menu.Show(this);
            Visible = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                con = cn.getConnection();
                con.Open();

                // Get the selected room number from the DataGridView
                int roomNumber = Convert.ToInt32(dgvBoarder.SelectedRows[0].Cells[0].Value);
        
                // Query to check the current status of the room
                cmd = new SqlCommand("SELECT RentStatus FROM DormTable WHERE RoomNumber = @RoomNumber", con);

                // Add parameter for the room number
                cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

                // Execute the query and get the current status
                string currentStatus = cmd.ExecuteScalar()?.ToString();

                if (currentStatus == "Pending")
                {
                    // Proceed to update the room status to "Occupied"
                    string updateStatusQuery = "UPDATE DormTable SET RentStatus = 'Occupied' WHERE RoomNumber = @RoomNumber";
                    using (SqlCommand updateCmd = new SqlCommand(updateStatusQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Room is now Occupied.");
                    }

                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a row in the table.");
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                con = cn.getConnection();
                con.Open();

                // Get the selected room number from the DataGridView
                int roomNumber = Convert.ToInt32(dgvBoarder.SelectedRows[0].Cells[0].Value);

                // Query to check the current status of the room
                cmd = new SqlCommand("SELECT RentStatus FROM DormTable WHERE RoomNumber = @RoomNumber", con);

                // Add parameter for the room number
                cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

                // Execute the query and get the current status
                string currentStatus = cmd.ExecuteScalar()?.ToString();

                if (currentStatus == "Pending")
                {
                    // Proceed to update the room status to "Occupied"
                    string updateStatusQuery = "UPDATE DormTable SET RentStatus = 'Available' WHERE RoomNumber = @RoomNumber";
                    using (SqlCommand updateCmd = new SqlCommand(updateStatusQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Tenant is Rejected.");
                    }

                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a row in the table.");
            }
        }

        private void Approval_Window_Load(object sender, EventArgs e)
        {
            con = cn.getConnection();
            con.Open();

            cmd = new SqlCommand("select RoomNumber, TenantName, PhoneNumber, RentStatus from DormTable", con);
            reader = cmd.ExecuteReader();
            dgvBoarder.Rows.Clear();

            while (reader.Read())
            {
                dgvBoarder.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
            }

            cmd.Dispose();
            reader.Close();
            con.Close();

        }
    }
}
