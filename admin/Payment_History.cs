using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry___Dormitory.admin
{
    public partial class Payment_History : Form
    {
        public static int _year, _month;
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

            showDays(DateTime.Now.Month, DateTime.Now.Year);
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

        private void btnNextClick_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showDays(_month, _year);
        }

        private void btnPrevClick_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            showDays(_month, _year);
        }

        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lbMonth.Text = monthName.ToUpper() + " " + year;
            DateTime startofTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startofTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < week; i++)
            {
                ucDays uc = new ucDays("", "");  // Empty day cells before the 1st of the month
                flowLayoutPanel1.Controls.Add(uc);
            }

            // Prepare a dictionary to store all rooms that paid on the same date
            Dictionary<string, List<string>> roomPayments = new Dictionary<string, List<string>>();

            con = cn.getConnection();
            con.Open();
            cmd = new SqlCommand("select * from PaymentsTable", con);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string paymentDate = DateTime.Parse(reader[3].ToString()).ToString("yyyy-MM-dd");
                string roomNumber = reader[1].ToString();

                if (roomPayments.ContainsKey(paymentDate))
                {
                    roomPayments[paymentDate].Add(roomNumber);  // Add additional room to the date
                }
                else
                {
                    roomPayments[paymentDate] = new List<string> { roomNumber };  // Initialize the list with the first room
                }
            }

            reader.Close();
            con.Close();

            // Loop through the days of the month and display room numbers accordingly
            for (int i = 1; i <= day; i++)
            {
                string date = year + "-" + month.ToString("D2") + "-" + i.ToString("D2");

                if (roomPayments.ContainsKey(date))
                {
                    // Combine room numbers into a single string
                    string roomsForDay = string.Join(", ", roomPayments[date]);
                    ucDays uc = new ucDays(i.ToString(), roomsForDay);  // Pass the rooms for that day
                    flowLayoutPanel1.Controls.Add(uc);
                }
                else
                {
                    ucDays uc = new ucDays(i.ToString(), "");  // No rooms paid on this date
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }

    }
}
