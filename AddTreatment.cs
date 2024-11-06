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
    public partial class AddTreatment : Form
    {
        public AddTreatment()
        {
            InitializeComponent();
            textBox1.Visible= false;
            label1.Visible=false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = textBox2.Text.Any(x => Char.IsDigit(x));
            bool b = textBox3.Text.Any(x => Char.IsDigit(x));
            bool c = textBox4.Text.Any(x => Char.IsDigit(x));
            bool d = textBox5.Text.Any(x => Char.IsLetter(x));
            bool f = string.IsNullOrEmpty(textBox2.Text);
            bool g = string.IsNullOrEmpty(textBox3.Text);
            bool h = string.IsNullOrEmpty(textBox4.Text);
            bool i = string.IsNullOrEmpty(textBox5.Text);
            if (a == true || b == true || c == true)
            {
                MessageBox.Show("Only letters can be accepted in this field");
            }
            else if (d == true)
            {
                MessageBox.Show("Only number can be entered in the treatment price field");
            }
            else if (f == true || g == true || h == true || i == true)
            {
                MessageBox.Show("Please ensure you have not left any fields empty");
            }
            else
            {
                int rowsAffected = TreatmentDAL.AddTreatment(textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToDecimal(textBox5.Text));
                if (rowsAffected > 0)
                {
                    MessageBox.Show("New treatment has been added successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("New treatment has not been added", "Error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new TreatmentMenu().Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
