using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpsonsDepartmentStore
{
    public partial class EditBooking : Form
    {
        public EditBooking()
        {
            InitializeComponent();
            label3.Visible= false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            label4.Visible = false;
            maskedTextBox1.Visible = false;
            label6.Visible= false;
            comboBox2.Visible = false;
            label7.Visible = false;
            checkedListBox1.Visible = false;
            label9.Visible = false;
            comboBox3.Visible = false;
            button3.Visible = false;

        }

        private void NameComboBox()
        {
            int i = 100;
            List<string> Client = CustomerDAL.SelectCustomersSurnames();
            foreach (string s in Client)
            {
                string[] names = s.Split(',');
                comboBox1.Items.Add(names[1]);
                i++;
            }
        }

        private void TreatmentListBox()
        {
            int i = 100;
            List<string> Treatment = TreatmentDAL.SelectTreatmentNames();
            foreach (string s in Treatment)
            {
                string[] names = s.Split(',');
                checkedListBox1.Items.Add(names[1]);
                i++;
            }
        }

        private void StaffComboBox()
        {
            int i = 100;
            List<string> Staff = StaffDAL.SelectStaffSurnames();
            foreach (string s in Staff)
            {
                string[] names = s.Split(',');
                comboBox3.Items.Add(names[1]);
                i++;
            }
        }

        private void RoomsComboBox()
        {
            int i = 100;
            List<string> Rooms = BookingDAL.getBookingRooms();
            foreach (string s in Rooms)
            {
                string[] names = s.Split(',');
                comboBox2.Items.Add(names[1]);
                i++;
            }
        }

        private void EditBooking_Load(object sender, EventArgs e)
        {
            NameComboBox();
            TreatmentListBox();
            StaffComboBox();
            RoomsComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new ViewBooking().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new BookingMenu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool a = string.IsNullOrEmpty(comboBox1.Text);
            bool b = string.IsNullOrEmpty(maskedTextBox1.Text);
            bool c = string.IsNullOrEmpty(comboBox2.Text);
            bool d = string.IsNullOrEmpty(Convert.ToString(checkedListBox1.Text));

            if (a == true || b == true || c == true || d == true)
            {
                MessageBox.Show("Please ensure that you have not left any fields empty");
            }
            else
            {
                editBooking();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //editVisible();
            searchBookingsByID();
        }

        private void editVisible()
        {
            label3.Visible = true;
            textBox2.Visible = true;
            comboBox1.Visible = true;
            label4.Visible = true;
            maskedTextBox1.Visible = true;
            label6.Visible = true;
            comboBox2.Visible = true;
            label7.Visible = true;
            checkedListBox1.Visible = true;
            label9.Visible = true;
            comboBox3.Visible= true;
            button3.Visible = true;
            textBox2.Visible = false;
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
                fillBoxes();
                editVisible();
            }
            else
            {
                MessageBox.Show("No Bookings found", "No Bookings");
            }
        }

        private void fillBoxes()
        {
            textBox1.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            comboBox1.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value;
            maskedTextBox1.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value;
            comboBox2.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value;
            checkedListBox1.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[4].Value;
            comboBox3.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value;
            

        }
        private void editBooking()
        {
            int rowsAffected = BookingDAL.updateBookingInformation(comboBox1.Text, 
                Convert.ToDateTime(maskedTextBox1.Text), comboBox2.Text, checkedListBox1.Text, comboBox3.Text);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Booking details successfully updated", "Update successful");
            }
            else
            {
                MessageBox.Show("Booking details could not be updated", "Update failed");
            }
        }
    }
}
