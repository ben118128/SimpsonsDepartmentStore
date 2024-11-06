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
    public partial class DeleteBooking : Form
    {
        public DeleteBooking()
        {
            InitializeComponent();
            button3.Visible= false;
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

        private void button4_Click(object sender, EventArgs e)
        {
            searchBookingsByID();
            //deleteVisible();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteBookingByID();
        }

        private void deleteVisible()
        {
            button1.Visible = false;
            button3.Visible = true;
            button4.Visible = false;
        }

        private void searchBookingsByID()
        {
            List<string> BookingIDs = BookingDAL.BookingsByID(Convert.ToInt32(textBox1.Text));
            if (BookingIDs.Count > 0)
            {
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "Booking ID";
                dataGridView1.Columns[1].Name = "Booking Customer";
                dataGridView1.Columns[2].Name = "Booking Date";
                dataGridView1.Columns[3].Name = "Booking Room";
                dataGridView1.Columns[4].Name = "Booking Contents";
                dataGridView1.Columns[5].Name = "Assigned Staff";
                foreach (string BookingID in BookingIDs)
                {
                    string[] info = BookingID.Split(',');
                    dataGridView1.Rows.Add(info);
                }
                deleteVisible();
            }
            else
            {
                MessageBox.Show("No Bookings found", "No Bookings");
            }
        }

        private void DeleteBookingByID()
        {
            int rowsAffected = BookingDAL.DeleteBooking(textBox1.Text);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Booking has been deleted.", "Success");
            }
            else
            {
                MessageBox.Show("Booking has not been deleted", "Error");
            }
        }
    }
}
