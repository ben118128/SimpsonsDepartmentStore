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
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
            label1.Visible= false;
            textBox1.Visible= false;
            button4.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> allCustomers = CustomerDAL.selectAllCustomers();

            if (allCustomers.Count > 0)
            {
                dataGridView1.ColumnCount = 7;
                dataGridView1.Columns[0].Name = "Customer ID";
                dataGridView1.Columns[1].Name = "Customer Foreame";
                dataGridView1.Columns[2].Name = "Customer Surname";
                dataGridView1.Columns[3].Name = "Customer DOB";
                dataGridView1.Columns[4].Name = "Customer Address";
                dataGridView1.Columns[5].Name = "Customer Postcode";
                dataGridView1.Columns[6].Name = "Customer Contact Number";

                foreach (string CustomerID in allCustomers)
                {
                    string[] info = CustomerID.Split(',');
                    dataGridView1.Rows.Add(info);
                }

            }
            else
            {
                MessageBox.Show("No customers found", "No customers");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new CustomerMenu().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchCustomerBySurname();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VisibleTrue();
            label1.Text = "Customer Surname";
        }

        private void VisibleTrue()
        {
            label1.Visible = true;
            textBox1.Visible = true;
            button4.Visible = true;
            button3.Visible = false;
        }

        private void searchCustomerBySurname()
        {
            List<string> customerNames = CustomerDAL.CustomersBySurname(textBox1.Text);
            if (customerNames.Count > 0)
            {
                dataGridView1.ColumnCount = 7;
                dataGridView1.Columns[0].Name = "Customer ID";
                dataGridView1.Columns[1].Name = "Customer Foreame";
                dataGridView1.Columns[2].Name = "Customer Surname";
                dataGridView1.Columns[3].Name = "Customer DOB";
                dataGridView1.Columns[4].Name = "Customer Address";
                dataGridView1.Columns[5].Name = "Customer Postcode";
                dataGridView1.Columns[6].Name = "Customer Contact Number";

                foreach (string CustomerID in customerNames)
                {
                    string[] info = CustomerID.Split(',');
                    dataGridView1.Rows.Add(info);
                }
            }
            else
            {
                MessageBox.Show("No customers found", "No customers");
            }
        }
    }
}
