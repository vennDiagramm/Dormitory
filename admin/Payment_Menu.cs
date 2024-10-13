﻿using Laundry___Dormitory.admin;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Laundry___Dormitory
{
    public partial class Payment_Menu : Form
    {
        public Point mouseLocation;
        public Payment_Menu()
        {
            InitializeComponent();
        }
        private void mouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        Koneksyon cn = new Koneksyon();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void btnAP_Back_Click(object sender, EventArgs e)
        {
            Form Main_Menu = new Main_Menu();
            Main_Menu.Show(this);
            Visible = false;
        }

        private void btnAP_Transact_Click(object sender, EventArgs e)
        {
            try
            {
                con = cn.getConnection();
                con.Open();

                // Validate if room numbers are valid integers
                if (int.TryParse(textBox1.Text, out int roomNumber) && double.TryParse(textBox2.Text, out double totalCost))
                {
                    if (roomNumber > 0 && totalCost > 0)
                    {
                        // Ensure fields are not empty
                        if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
                        {
                            string query = "SELECT MonthlyBill FROM DormTable WHERE RoomNumber = @RoomNumber";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

                            // Execute the query and retrieve the data
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                double monthlyBill = 0;
                                if (reader.Read()) // If a record is found
                                {
                                    // Retrieve the MonthlyBill from the result set
                                    monthlyBill = Convert.ToDouble(reader["MonthlyBill"]);

                                    if (monthlyBill > totalCost)
                                    {
                                        MessageBox.Show("Insufficient Amount!");
                                    } else if (monthlyBill == 0)
                                    {
                                        MessageBox.Show("Lacking information! Calculate first the utilities to get the needed monthly bill!");
                                    }
                                    else
                                    {
                                        // Subtract the retrieved MonthlyBill from the totalCost
                                        double remainingAmount = totalCost - monthlyBill;
                                        string remainingAmountStr = remainingAmount.ToString("F2");

                                        reader.Close(); // Close the reader before executing another command

                                        // Saving to the database
                                        cmd = new SqlCommand("UPDATE DormTable SET MonthlyBill = @MonthlyBill, PaymentStatus = @PaymentStatus WHERE RoomNumber = @RoomNumber", con);
                                        cmd.Parameters.AddWithValue("@MonthlyBill", 0);
                                        cmd.Parameters.AddWithValue("@PaymentStatus", "Paid");
                                        cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

                                        cmd.ExecuteNonQuery();

                                        // Diri e tawag ang method para ma butang sa isa ka table
                                        DateTime currentDate = DateTime.Now;
                                        string dateString = currentDate.ToString();
                                        //string yearMonthDay = dateString.Substring(0, 10);
                                        string yearMonthDay = currentDate.ToString("yyyy-MM-dd HH:mm:ss");
                                        InsertPayment(roomNumber, (decimal)monthlyBill, yearMonthDay, "Paid");

                                        // Clearing fields
                                        Changelbl.Text = remainingAmountStr;
                                        MessageBox.Show("Transaction Successful");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Room number not found.");
                                    return; // Exit the method if the room number is not found
                                }
                            } // The reader will automatically be closed here due to the 'using' statement

                            cmd.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("All fields must be filled out.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Room Number must be greater than 0.");
                    }
                }
                else
                { // Show error message if room number or phone number are invalid
                    MessageBox.Show("Please enter valid numeric values for Room Number.");
                }
            }
            catch (Exception ex)
            { // Normal catching
                MessageBox.Show(ex.Message); 
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                { // para jud ma close
                    con.Close(); 
                }
            }
        }


        private void btnAP_AddUtilities_Click(object sender, EventArgs e)
        {
            try
            {
                con = cn.getConnection(); // Assuming cn.getConnection() returns a valid connection object
                con.Open();

                // Validate if room number is a valid integer
                if (int.TryParse(txtAP_Room.Text, out int roomNumber) && double.TryParse(txtAP_Electricity.Text, out double electricityCost) && double.TryParse(txtAP_Water.Text, out double monthlyWater))
                {
                    if (roomNumber > 0)
                    {
                        // Ensure that the required fields are not empty
                        if (!string.IsNullOrEmpty(txtAP_Electricity.Text) && !string.IsNullOrEmpty(txtAP_Water.Text) && !string.IsNullOrEmpty(txtAP_Room.Text))
                        {
                            //Calculation for total cost
                            double totalCost = ((electricityCost * 11) + monthlyWater) + 3000;
                            string totalCoststr = totalCost.ToString("F2");

                            // Create the SQL query to update the utilities cost for the specified room number
                            string query = "UPDATE DormTable SET ElectricityCost = @ElectricityCost, MonthlyWater = @MonthlyWater, MonthlyBill = @MonthlyBill, PaymentStatus = @PaymentStatus WHERE RoomNumber = @RoomNumber";

                            // Initialize the SqlCommand with the query and the connection
                            cmd = new SqlCommand(query, con);

                            // Bind the parameters to the values from the text boxes
                            cmd.Parameters.AddWithValue("@ElectricityCost", electricityCost);
                            cmd.Parameters.AddWithValue("@MonthlyWater", monthlyWater);
                            cmd.Parameters.AddWithValue("@MonthlyBill", totalCost);
                            cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                            cmd.Parameters.AddWithValue("@PaymentStatus","Unpaid");

                            // Execute the update query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Utilities Updated!");

                                // Clear the text boxes after successful operation
                                //txtAP_Room.Text = "";
                                //txtAP_Electricity.Text = "";
                                //txtAP_Water.Text = "";
                                lblTotal.Text = totalCoststr;
                            }
                            else
                            {
                                // If no rows were affected, the room number doesn't exist
                                MessageBox.Show("Room Number not found.");
                            }

                            cmd.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("All fields must be filled out.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Room Number must be greater than 0.");
                    }
                }
                else
                {
                    // Show error message if room number is invalid
                    MessageBox.Show("Please enter a valid numeric value for Room Number.");
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

        // para inig sulod mo load dayon
        private void Payment_Menu_Load(object sender, EventArgs e)
        {
            con = cn.getConnection();
            con.Open();

            cmd = new SqlCommand("select RoomNumber, TenantName, RentStatus, MonthlyBill, PaymentStatus from DormTable", con);
            reader = cmd.ExecuteReader();
            PaymentGridView.Rows.Clear();

            while (reader.Read())
            {
                PaymentGridView.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
            }

            cmd.Dispose();
            reader.Close();
            con.Close();

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            con = cn.getConnection();
            con.Open();

            switch (comboBox1.Text)
            {
                case "Unpaid":
                    cmd = new SqlCommand("select RoomNumber, TenantName, RentStatus, MonthlyBill, PaymentStatus from DormTable where RentStatus  = 'Occupied' and PaymentStatus = 'Unpaid'", con);
                    reader = cmd.ExecuteReader();
                    PaymentGridView.Rows.Clear();

                    while (reader.Read())
                    {
                        PaymentGridView.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                    }
                    break;

                case "Paid":
                    cmd = new SqlCommand("select RoomNumber, TenantName, RentStatus, MonthlyBill, PaymentStatus from DormTable where RentStatus  = 'Occupied' and PaymentStatus = 'Paid'", con);
                    reader = cmd.ExecuteReader();
                    PaymentGridView.Rows.Clear();

                    while (reader.Read())
                    {
                        PaymentGridView.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                    }
                    break;

                case "Overdue":
                    cmd = new SqlCommand("select RoomNumber, TenantName, RentStatus, MonthlyBill, PaymentStatus from DormTable where RentStatus  = 'Occupied' and PaymentStatus = 'Overdue'", con);
                    reader = cmd.ExecuteReader();
                    PaymentGridView.Rows.Clear();

                    while (reader.Read())
                    {
                        PaymentGridView.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                    }
                    break;
            }
            cmd.Dispose();
            reader.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = cn.getConnection();
            con.Open();

            cmd = new SqlCommand("update DormTable set PaymentStatus = 'Unpaid'", con);
            reader = cmd.ExecuteReader();
            PaymentGridView.Rows.Clear();

            while (reader.Read())
            {
                PaymentGridView.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
            }
            MessageBox.Show("");
            cmd.Dispose();
            reader.Close();
            con.Close();
        }

        private void PaymentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // for the date and stuff

        private void InsertPayment(int roomNumber, decimal paymentAmount, string paymentDate, string paymentStatus)
        {
                try
                {
                    con = cn.getConnection(); 
                    con.Open();
                

                    string query = "INSERT INTO PaymentsTable (RoomNumber, PaymentAmount, PaymentDate, PaymentStatus) VALUES (@RoomNumber, @PaymentAmount, @PaymentDate, @PaymentStatus)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to the SQL command
                        cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                        cmd.Parameters.AddWithValue("@PaymentAmount", paymentAmount);
                        cmd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                        cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus);

                        int rowsAffected = cmd.ExecuteNonQuery(); // Execute the insert command

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment recorded successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to record payment.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close(); // Ensure the connection is closed after operation
                }  
        }

        private void btn_PM_ViewAll_Click(object sender, EventArgs e)
        {
            // To create new floating window
            Form formBackground = new Form();
            try
            {
                using (Payment_History uu = new Payment_History())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Minimized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { formBackground.Dispose(); }
        }
    }
}
