using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SimpsonsDepartmentStore
{
    public partial class AddBooking : Form
    {
        String connectionString = ConfigurationManager.ConnectionStrings["BeautyAndCosmeticsConnectionString"].ConnectionString;
        public AddBooking()
        {
            InitializeComponent();
        }

        //int i = 100;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = string.IsNullOrEmpty(comboBox1.Text);
            bool b = string.IsNullOrEmpty(comboBox2.Text);
            bool c = string.IsNullOrEmpty(Convert.ToString(checkedListBox1.Text));
            bool d = string.IsNullOrEmpty(comboBox3.Text);

            if (a == true || b == true || c == true || d == true)
            {
                MessageBox.Show("Please ensure you have not left any fields empty");
            }
            else
            {
                doubleBookingCheck();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new BeautyCosmetics().Show();
        }

        private void AddBooking_Load(object sender, EventArgs e)
        {
            NameComboBox();
            TreatmentListBox();
            StaffComboBox();
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
            foreach(string s in Staff)
            {
                string[] names = s.Split(',');
                comboBox3.Items.Add(names[1]);
                i++;
            }
        }

        private void doubleBookingCheck()
        {
            List<string> Rooms = BookingDAL.getBookingRooms();
            foreach(string s in Rooms)
            {
                string[] rooms = s.Split(',');
            }
            List<string> Dates = BookingDAL.getBookingDates();
            foreach(string s in Dates)
            {
                string[] dates = s.Split(',');
            }
            List<string> Staff = BookingDAL.getAssignedStaff();
            foreach(string s in Staff)
            {
                string[] staff = s.Split(',');
                //staff.Contains(comboBox2.Text)
            }

            List<string> StaffType = StaffDAL.SelectStaffTypes();
            foreach(string s in StaffType)
            {
                string[] staffType = s.Split(',');
            }

           if (Staff.Contains(comboBox3.Text) && Dates.Contains(dateTimePicker1.Text))
            {
                MessageBox.Show("This member of staff is unavailable for this date", "Member of staff already booked");
            }
           else if (Dates.Contains(dateTimePicker1.Text) && Rooms.Contains(comboBox1.Text))
            {
                MessageBox.Show("This room is already booked on this date, please select a different one", "Room booked");
            }
           else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Friday && StaffType.Contains("Part-Time"))
            {
                MessageBox.Show("This member of staff is part time and cannot be booked on fridays");
            }
           else if (Dates.Contains(dateTimePicker1.Text) && Rooms.Contains(comboBox1.Text) && Staff.Contains(comboBox3.Text))
            {
                MessageBox.Show("The member of staff or booking room that you have selected is unavaliable on this date", "Double booking");
            }
           else
            {
                int rowsAffected = BookingDAL.addBooking(comboBox1.Text, Convert.ToDateTime(dateTimePicker1.Value), comboBox2.Text, checkedListBox1.Text, comboBox3.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("New booking has been added successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("New booking has not been added", "Error");
                }
            }
        }
    }
}
