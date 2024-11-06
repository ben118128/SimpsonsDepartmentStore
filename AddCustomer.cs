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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            textBox3.Visible= false;
            textBox5.Visible= false;
            textBox6.Visible= false;
            maskedTextBox1.Visible=false;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = textBox1.Text.Any(x => Char.IsDigit(x));
            bool b = textBox2.Text.Any(x => Char.IsDigit(x));
            bool c = maskedTextBox3.Text.Any(x => Char.IsLetter(x));
            bool d = string.IsNullOrEmpty(textBox1.Text);
            bool f = string.IsNullOrEmpty(textBox2.Text);
            bool g = string.IsNullOrEmpty(textBox4.Text);
            bool h = maskedTextBox2.MaskFull;
            bool i = maskedTextBox3.MaskFull;

            if (a == true || b == true)
            {
                MessageBox.Show("Only letters can be accepted in this field");
            }
            else if (c == true)
            {
                MessageBox.Show("The customer contact number field must only contain numbers");
            }

            else if (d == true || f == true || g == true || h == false || i == false)
            {
                MessageBox.Show("Please ensure that you have not left any fields empty");
            }

            else
            { 
                int rowsAffected = CustomerDAL.addCustomer(textBox1.Text, textBox2.Text, dateTimePicker1.Value.Date, textBox4.Text, maskedTextBox2.Text, maskedTextBox3.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("New customer has been added successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("New customer has not been added", "Error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new CustomerMenu().Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
