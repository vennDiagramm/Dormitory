using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry___Dormitory.admin
{
    public partial class ucDays : UserControl
    {
        string _day, _roomNumber, date, weekday; 

        private void panel1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 150, 79);
            } else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White;
            }
        }

        public ucDays(string day, string roomNumbers)
        {
            InitializeComponent();
            _day = day;
            label1.Text = day;  // Display the day number

            // Display room numbers (or leave empty if none)
            if (!string.IsNullOrEmpty(roomNumbers))
            {
                label2.Text = "Paid Rooms:\n" + roomNumbers;  // Update label2 to show room numbers
            }
            else
            {
                label2.Text = "";  // No room payments for this day
            }

            checkBox1.Hide();
            date = Payment_History._month + "/" + _day + "/" + Payment_History._year;
        }


        private void sundays()
        {
            try
            {
                // Construct DateTime properly using year, month, and day as integers
                int year = Payment_History._year;
                int month = Payment_History._month;
                int dayNumber = int.Parse(_day);  // _day is passed as a string, so we convert it to an integer

                DateTime day = new DateTime(year, month, dayNumber);

                // Get the weekday and check if it's Sunday
                weekday = day.ToString("ddd");
                if (weekday == "Sun")
                {
                    label1.ForeColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    label1.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }
            catch (Exception ex)
            {
                // Handle exception (optional logging or other measures can go here)
            }
        }


        private void ucDays_Load(object sender, EventArgs e)
        {
            sundays();
        }
    }
}
