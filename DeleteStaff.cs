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

namespace SimpsonsDepartmentStore
{
    public partial class DeleteStaff : Form
    {
        public DeleteStaff()
        {
            InitializeComponent();
            button3.Visible= false;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> allStaff =StaffDAL.selectAllStaff();

            if (allStaff.Count > 0)
            {
                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].Name = "Staff ID";
                dataGridView1.Columns[1].Name = "Forename";
                dataGridView1.Columns[2].Name = "Surname";
                dataGridView1.Columns[3].Name = "Staff Type";
                dataGridView1.Columns[4].Name = "DOB";
                dataGridView1.Columns[5].Name = "Address";
                dataGridView1.Columns[6].Name = "Postcode";
                dataGridView1.Columns[7].Name = "Contact Number";

                foreach (string StaffID in allStaff)
                {
                    string[] info = StaffID.Split(',');
                    dataGridView1.Rows.Add(info);
                }
            }
            else
            {
                MessageBox.Show("No staff found", "No Staff");
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new StaffMenu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteStaffByID();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchStaffByID();
            //DeleteVisible();
        }

        private void DeleteVisible()
        {
            button3.Visible = true;
            button1.Visible = false;
            button4.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditStaff_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchStaffByID()
        {
            List<string> staffIDs = StaffDAL.staffByID(Convert.ToInt32(textBox1.Text));
            if (staffIDs.Count > 0)
            {
                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].Name = "Staff ID";
                dataGridView1.Columns[1].Name = "Staff Foreame";
                dataGridView1.Columns[2].Name = "Staff Surname";
                dataGridView1.Columns[3].Name = "Staff Type";
                dataGridView1.Columns[4].Name = "Staff DOB";
                dataGridView1.Columns[5].Name = "Staff Address";
                dataGridView1.Columns[6].Name = "Staff Postcode";
                dataGridView1.Columns[7].Name = "Staff Contact Number";

                foreach (string StaffID in staffIDs)
                {
                    string[] info = StaffID.Split(',');
                    dataGridView1.Rows.Add(info);
                }
                DeleteVisible();
            }
            else
            {
                MessageBox.Show("No Staff found", "No Staff");
            }
        }

        private void DeleteStaffByID()
        {
            int rowsAffected = StaffDAL.DeleteStaff(textBox1.Text);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Member of staff has been deleted.", "Success");
            }
            else
            {
                MessageBox.Show("Member of staff has not been deleted", "Error");
            }
        }
    }
}
