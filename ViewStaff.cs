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
    public partial class ViewStaff : Form
    {
        public ViewStaff()
        {
            InitializeComponent();
            label1.Visible = false;
            textBox1.Visible = false;
            button4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new StaffMenu().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> allStaff = StaffDAL.selectAllStaff();

            if (allStaff.Count > 0)
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

                foreach (string StaffID in allStaff)
                {
                    string[] info = StaffID.Split(',');
                    dataGridView1.Rows.Add(info);
                }

            }
            else
            {
                MessageBox.Show("No staff found", "No staff");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "Staff Surname";
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchStaffBySurname();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchStaffBySurname()
        {
            List<string> staffNames = StaffDAL.staffBySurname(textBox1.Text);
            if (staffNames.Count > 0)
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

                foreach (string StaffID in staffNames)
                {
                    string[] info = StaffID.Split(',');
                    dataGridView1.Rows.Add(info);
                }
            }
            else
            {
                MessageBox.Show("No Staff found", "No Staff");
            }
        }
    }
}
