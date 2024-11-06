using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpsonsDepartmentStore
{
    public partial class ViewBooking : Form
    {
        public ViewBooking()
        {
            InitializeComponent();
            label1.Visible = false;
            textBox1.Visible = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> allBookings = BookingDAL.selectAllBookings();

            if (allBookings.Count > 0)
            {
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "Booking ID";
                dataGridView1.Columns[1].Name = "Booking Customer";
                dataGridView1.Columns[2].Name = "Booking Date";
                dataGridView1.Columns[3].Name = "Booking Room";
                dataGridView1.Columns[4].Name = "Booking Contents";
                dataGridView1.Columns[5].Name = "Assigned Staff";

                foreach (string BookingID in allBookings)
                {
                    string[] info = BookingID.Split(',');
                    dataGridView1.Rows.Add(info);
                }

            }
            else
            {
                MessageBox.Show("No bookings found", "No bookings");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new BookingMenu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VisibleTrue();
        }

        private void VisibleTrue()
        {
            label1.Visible= true;
            textBox1.Visible= true;
            button4.Visible= true;
            button3.Visible = false;
        }

        private void searchBookingsByCustomer()
        {
            List<string> bookingNames = BookingDAL.BookingsByCustomer(textBox1.Text);
            if (bookingNames.Count > 0)
            {
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "Booking ID";
                dataGridView1.Columns[1].Name = "Booking Customer";
                dataGridView1.Columns[2].Name = "Booking Date";
                dataGridView1.Columns[3].Name = "Booking Room";
                dataGridView1.Columns[4].Name = "Booking Contents";
                dataGridView1.Columns[5].Name = "Assigned Staff";

                foreach (string BookingID in bookingNames)
                {
                    string[] info = BookingID.Split(',');
                    dataGridView1.Rows.Add(info);
                }
            }
            else
            {
                MessageBox.Show("No Bookings found", "No bookings");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchBookingsByCustomer();
        }
    }
}
