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

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

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

        private void dgvBoarder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Koneksyon cn = new Koneksyon();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        // Viewing - Responsible for viewing
        private void btnView_Click(object sender, EventArgs e)
        {
            con = cn.getConnection();
            con.Open();

            cmd = new SqlCommand("select * from DormTable", con);
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
            finally {
                dgvBoarder.Rows.Clear();
                formBackground.Dispose(); 
            }
        }
    }
}
