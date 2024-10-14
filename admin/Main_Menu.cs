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
using Laundry___Dormitory.openWindow;

namespace Laundry___Dormitory
{
    public partial class Main_Menu : Form
    {
        public Point mouseLocation;
        public Main_Menu()
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

        // para sa exit
        private void button2_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            this.Hide();
            landingPage.ShowDialog();
            this.Close();
        }

        // para sa add window
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // To create new floating window
            Form formBackground = new Form();
            try
            {
                using (frmAddBoarder uu = new frmAddBoarder())
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

       
        // para sa payment window
        private void btnPaymentInfo_Click(object sender, EventArgs e)
        {
            // To create new floating window
            Form formBackground = new Form();
            try
            {
                using (Payment_Menu uu = new Payment_Menu())
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

        // para sa remove
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // To create new floating window
            Form formBackground = new Form();
            try
            {
                using (RemoveTenant uu = new RemoveTenant())
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


        // para sa search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // To create new floating window
            Form formBackground = new Form();
            Search_Tenant uu = new Search_Tenant();
            try
            {             
                using (uu)
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
            finally 
            {
                dgvBoarder.Rows.Clear();

                string[] hold = uu.result;

                dgvBoarder.Rows.Add(hold[0], hold[1], hold[2], hold[3]);
                formBackground.Dispose(); 
            }
        }

        // edit window
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // To create new floating window
            Form formBackground = new Form();
            try
            {
                using (Edit_Tenant_Room uu = new Edit_Tenant_Room())
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
            finally
            {
                dgvBoarder.Rows.Clear();
                formBackground.Dispose();
            }
        }

        // ma krazy ang gui pag e del
        private void dgvBoarder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// Para sa viewing [sa main menu magawa]
        Koneksyon cn = new Koneksyon();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        // Viewing - Responsible for viewing
        private void btnView_Click(object sender, EventArgs e)
        {
            con = cn.getConnection();
            con.Open();

            cmd = new SqlCommand("select * from DormTable", con); //select RoomNumber, TenantName, PhoneNumber, RentStatus from DormTable
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

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeTracker.Text = DateTime.Now.ToLongDateString();
        }

        // EXIT BUTTOONNN
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAprov_Click(object sender, EventArgs e)
        {
            // To create new floating window
            Form formBackground = new Form();
            try
            {
                using (Approval_Window uu = new Approval_Window())
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
            finally
            {
                dgvBoarder.Rows.Clear();
                formBackground.Dispose();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            con = cn.getConnection();
            con.Open();

            // Remove the reader here, you don't need it for counting.
            for (int RoomCounter = 1; RoomCounter <= 20; RoomCounter++)
            {
                string checkQuery = "SELECT COUNT(*) FROM DormTable WHERE RoomNumber = @roomNumber";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@roomNumber", RoomCounter);

                    int count = (int)checkCmd.ExecuteScalar(); // This works without a reader

                    if (count > 0) // If a duplicate exists
                    {
                        // Proceed to update if RoomNumber exists
                        SqlCommand cmd = new SqlCommand("UPDATE DormTable SET TenantName = @TenantName, PhoneNumber = @PhoneNumber, RentStatus = @RentStatus WHERE RoomNumber = @RoomNumber", con);
                        cmd.Parameters.AddWithValue("@TenantName", ""); // Use DBNull for null values
                        cmd.Parameters.AddWithValue("@PhoneNumber", "00000000000");
                        cmd.Parameters.AddWithValue("@RentStatus", "Available");
                        cmd.Parameters.AddWithValue("@RoomNumber", RoomCounter);
                        cmd.ExecuteNonQuery();                      
                    }
                    else
                    {
                        // Insert if RoomNumber does not exist
                        cmd = new SqlCommand("insert into DormTable (RoomNumber, TenantName, PhoneNumber, RentStatus) values ('"
                        + RoomCounter + "','" + "" + "','" + "00000000000" + "','"
                        + "Available" + "')", con);
                        cmd.ExecuteNonQuery();                       
                    }                   
                }
            }

            MessageBox.Show("Reset Successful!");

            // Close the connection after all operations are done
            con.Close();

        }
    }
}
