using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpsonsDepartmentStore
{
    public partial class AddStaff : Form
    {
        /*public string contactno = textBox7.Text;
        public static long Parse(string contactno);*/
        public AddStaff()
        {
            InitializeComponent();
            textBox3.Visible= false;
            textBox4.Visible = false;
            textBox6.Visible= false;
            textBox7.Visible= false;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            bool a = textBox1.Text.Any(x => Char.IsDigit(x));
            bool b = textBox2.Text.Any(x => Char.IsDigit(x));
            bool c = maskedTextBox3.Text.Any(x => Char.IsLetter(x));
            bool d = string.IsNullOrEmpty(textBox1.Text);
            bool f = string.IsNullOrEmpty(textBox2.Text);
            bool g = string.IsNullOrEmpty(textBox5.Text);
            bool h = maskedTextBox2.MaskFull;
            bool i = maskedTextBox3.MaskFull;
            bool j = string.IsNullOrEmpty(comboBox1.Text);
            bool k = string.IsNullOrEmpty(Convert.ToString(dateTimePicker1.Value));
            if (a == true || b == true)
            {
                MessageBox.Show("Only letters can be accepted in this field");
            }
            else if (c == true)
            {
                MessageBox.Show("Only number can be entered in the staff contact number field.");
            }
            else if (d == true || f == true || g == true || h == false || i == false || j == true || k == true)
            {
                MessageBox.Show("Please ensure you have not left any fields empty");
            }
            else
            {
                int rowsAffected = StaffDAL.addStaff(textBox1.Text, textBox2.Text, comboBox1.Text, Convert.ToDateTime(dateTimePicker1.Value.Date), textBox5.Text, maskedTextBox2.Text, maskedTextBox3.Text);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("New member of staff has been added successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("New member of staff has not been added", "Error");
                }

                
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new StaffMenu().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
 
            
        }

    }
}
