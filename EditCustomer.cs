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
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
            label3.Visible = false;
            textBox2.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
            maskedTextBox1.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox5.Visible = false;
            label8.Visible = false;
            maskedTextBox2.Visible = false;
            label9.Visible = false;
            maskedTextBox3.Visible = false;
            button3.Visible = false;
            dateTimePicker1.Visible = false;
            //dateTimePicker1.Value = Convert.ToDateTime(maskedTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new CustomerMenu().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new ViewCustomer().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool a = textBox2.Text.Any(x => Char.IsDigit(x));
            bool b = textBox3.Text.Any(x => Char.IsDigit(x));
            bool c = maskedTextBox1.Text.Any(x => Char.IsLetter(x));
            bool d = maskedTextBox2.MaskFull;
            bool f = maskedTextBox3.Text.Any(x => Char.IsLetter(x));
            bool g = string.IsNullOrEmpty(textBox2.Text);
            bool h = string.IsNullOrEmpty(textBox3.Text);
            bool i = maskedTextBox1.MaskFull; ;
            bool j = maskedTextBox3.MaskFull;
            bool k = string.IsNullOrEmpty(textBox5.Text);
            if (a == true || b == true)
            {
                MessageBox.Show("Only letters can be accepted in this field");
            }
            else if (c == true)
            {
                MessageBox.Show("Please enter a date");
            }
            else if (f == true)
            {
                MessageBox.Show("Please only enter numbers in the contact number field");
            }
            else if (d == false || g == true || h == true || i == false || j == false || k== true)
            {
                MessageBox.Show("Please ensure every field has been filled out");
            }
            else
            {
                editCustomer();
                clearBoxes();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //editVisible();
            searchCustomersByID();
        }

        private void editVisible()
        {
            label3.Visible = true;
            textBox2.Visible = true;
            label4.Visible = true;
            textBox3.Visible = true;
            // dateTimePicker1.Visible = true;
            maskedTextBox1.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox5.Visible = true;
            label8.Visible = true;
            maskedTextBox2.Visible = true;
            label9.Visible = true;
            maskedTextBox3.Visible = true;
            button3.Visible = true;
        }

        private void searchCustomersByID()
        {
            List<string> customerIds = CustomerDAL.CustomersByID(Convert.ToInt32(textBox1.Text));
            if (customerIds.Count > 0)
            {
                dataGridView1.ColumnCount = 7;
                dataGridView1.Columns[0].Name = "CustomerID";
                dataGridView1.Columns[1].Name = "Customer Forename";
                dataGridView1.Columns[2].Name = "Customer Surname";
                dataGridView1.Columns[3].Name = "Customer DOB";
                dataGridView1.Columns[4].Name = "Customer Address";
                dataGridView1.Columns[5].Name = "Customer Postcode";
                dataGridView1.Columns[6].Name = "Customer Contact Number";
                foreach (string CustomerID in customerIds)
                {
                    string[] info = CustomerID.Split(',');
                    dataGridView1.Rows.Add(info);
                }
                fillBoxes();
                editVisible();
            }
            else
            {
                MessageBox.Show("No Treatments found", "No Treatments");
            }
        }

        private void fillBoxes()
        {
            textBox1.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            textBox2.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value;
            textBox3.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value;
            maskedTextBox1.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value;
            textBox5.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[4].Value;
            maskedTextBox2.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value;
            maskedTextBox3.Text = (string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[6].Value;

        }

        private void clearBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            maskedTextBox2.Clear();
            textBox5.Clear();
            maskedTextBox3.Clear();
        }

        private void editCustomer()
        {
            int rowsAffected = CustomerDAL.updateCustomerInformation(textBox2.Text, 
                textBox3.Text, Convert.ToDateTime(dateTimePicker1.Value.Date), textBox5.Text, maskedTextBox2.Text, maskedTextBox3.Text, Convert.ToInt32(textBox1.Text));
            if (rowsAffected > 0)
            {
                MessageBox.Show("Customer details successfully updated", "Update successful");
            }
            else
            {
                MessageBox.Show("Customer details could not be updated", "Update failed");
            }
        }
    }
}
