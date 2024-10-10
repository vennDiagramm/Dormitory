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

namespace Laundry___Dormitory.admin
{
    public partial class Payment_History : Form
    {
        public Point mouseLocation;
        public Payment_History()
        {
            InitializeComponent();
        }

        Koneksyon cn = new Koneksyon();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        private void btn_PH_Back_Click(object sender, EventArgs e)
        {
            Form Payment_Menu = new Payment_Menu();
            Payment_Menu.Show(this);
            Visible = false;
        }

        // para inig sulod mo load dayon
        private void Payment_History_Load(object sender, EventArgs e)
        {
            con = cn.getConnection();
            con.Open();

            cmd = new SqlCommand("select * from PaymentsTable", con);
            reader = cmd.ExecuteReader();
            dgv_PaymentHistory.Rows.Clear();

            while (reader.Read())
            {
                dgv_PaymentHistory.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
            }

            cmd.Dispose();
            reader.Close();
            con.Close();

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
    }
}
