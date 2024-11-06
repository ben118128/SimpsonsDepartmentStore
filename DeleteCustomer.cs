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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
            button3.Visible = false;

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
            searchCustomerByID();
            //deleteVisible();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteCustomerByID();
        }

        private void deleteVisible()
        {
            button1.Visible = false;
            button3.Visible = true;
            button4.Visible = false;
        }

        private void searchCustomerByID()
        {
            List<string> customerIDs = CustomerDAL.CustomersByID(Convert.ToInt32(textBox1.Text));
            if (customerIDs.Count > 0)
            {
                dataGridView1.ColumnCount = 7;
                dataGridView1.Columns[0].Name = "Customer ID";
                dataGridView1.Columns[1].Name = "Customer Foreame";
                dataGridView1.Columns[2].Name = "Customer Surname";
                dataGridView1.Columns[3].Name = "Customer DOB";
                dataGridView1.Columns[4].Name = "Customer Address";
                dataGridView1.Columns[5].Name = "Customer Postcode";
                dataGridView1.Columns[6].Name = "Customer Contact Number";

                foreach (string CustomerID in customerIDs)
                {
                    string[] info = CustomerID.Split(',');
                    dataGridView1.Rows.Add(info);
                }
                deleteVisible();
            }
            else
            {
                MessageBox.Show("No customers found", "No customers");
            }
        }

        private void DeleteCustomerByID()
        {
            int rowsAffected = CustomerDAL.DeleteCustomer(textBox1.Text);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Customer has been deleted.", "Success");
            }
            else
            {
                MessageBox.Show("Customer has not been deleted", "Error");
            }
        }
    }
}
