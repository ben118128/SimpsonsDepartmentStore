using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpsonsDepartmentStore
{
    public partial class EditStaff : Form
    {
        public EditStaff()
        {
            InitializeComponent();
            clearBoxes();
            dataGridView1.Rows.Clear();
            //dataGridView1.Rows.Refresh();
            label4.Visible = false;
            textBox3.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
            label5.Visible = false;
            textBox4.Visible = false;
            label6.Visible = false;
            maskedTextBox1.Visible = false;
            label7.Visible = false;
            textBox6.Visible = false;
            label8.Visible = false;
            maskedTextBox2.Visible = false;
            label9.Visible = false;
            maskedTextBox3.Visible = false;
            button3.Visible = false;
            comboBox1.Visible = false;
            dateTimePicker1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new ViewStaff().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool a = textBox2.Text.Any(x => Char.IsDigit(x));
            bool b = textBox3.Text.Any(x => Char.IsDigit(x));
            bool c = maskedTextBox1.Text.Any(x => Char.IsLetter(x));
            bool d = maskedTextBox3.Text.Any(x => Char.IsLetter(x));
            bool f = string.IsNullOrEmpty(textBox2.Text);
            bool g = string.IsNullOrEmpty(textBox3.Text);
            bool h = maskedTextBox1.MaskFull;
            bool i = maskedTextBox2.MaskFull;
            bool j = maskedTextBox3.MaskFull;
            bool k = string.IsNullOrEmpty(textBox6.Text);
            bool l = string.IsNullOrEmpty(comboBox1.Text);
            if (a == true || b == true)
            {
                MessageBox.Show("Only letters can be accepted in this field");
            }
            else if (c == true || d == true)
            {
                MessageBox.Show("Only numbers can be accepted in these fields");
            }
            else if (f == true || g == true || h == false || i == false || j == false || k == true || l == true)
            {
                MessageBox.Show("Please ensure that you have not left any fields empty");
            }
            else
            {
                editStaff();
                clearBoxes();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new StaffMenu().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //editVisible();
            searchStaffByID();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editVisible()
        {
            label4.Visible = true;
            textBox3.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            label5.Visible = true;
            comboBox1.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox6.Visible = true;
            label8.Visible = true;
            maskedTextBox2.Visible = true;
            label9.Visible = true;
            maskedTextBox3.Visible = true;
            button3.Visible = true;
            //dateTimePicker1.Visible = true;
            maskedTextBox1.Visible = true;
        }

        private void searchStaffByID()
        {
            List<string> staffIDs = StaffDAL.staffByID(Convert.ToInt32(textBox1.Text));
            if(staffIDs.Count > 0)
            {
                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].Name ="StaffID";
                dataGridView1.Columns[1].Name ="Staff Forename";
                dataGridView1.Columns[2].Name = "Staff Surname";
                dataGridView1.Columns[3].Name = "Staff Type";
                dataGridView1.Columns[4].Name = "Staff DOB";
                dataGridView1.Columns[5].Name = "Staff Address";
                dataGridView1.Columns[6].Name = "Staff Postcode";
                dataGridView1.Columns[7].Name = "Staff Contact Number";
                foreach(string staffID in staffIDs)
                {
                    string[] staffInfo = staffID.Split(',');
                    dataGridView1.Rows.Add(staffInfo);
                }
                fillTextBoxes();
                editVisible();
            }
            else
            {
                MessageBox.Show("No member of staff found", "Invalid ID");
            }
        }

        private void fillTextBoxes()
        {
            textBox1.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            textBox2.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value;
            textBox3.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value;
            comboBox1.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value;
            maskedTextBox1.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[4].Value;
            textBox6.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value;
            maskedTextBox2.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[6].Value;
            maskedTextBox3.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[7].Value;
        }

        private void clearBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            textBox6.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            comboBox1.Text = "";
        }

        private void editStaff()
        {
            int rowsAffected = StaffDAL.updateStaffInformation(textBox3.Text,
                textBox2.Text, comboBox1.Text, Convert.ToDateTime(dateTimePicker1.Value.Date), textBox6.Text, maskedTextBox2.Text, maskedTextBox3.Text, Convert.ToInt32(textBox1.Text));
            if (rowsAffected > 0)
            {
                MessageBox.Show("Employee details successfully updated", "Update successful");
            }
            else
            {
                MessageBox.Show("Employee details could not be updated", "Update failed");
            }
        }
    }
}
