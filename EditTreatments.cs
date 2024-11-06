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
    public partial class EditTreatments : Form
    {
        public EditTreatments()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            //clearBoxes();
            label2.Visible = false;
            textBox1.Visible = false;
            label4.Visible= false;
            textBox3.Visible= false;
            label5.Visible= false;
            textBox4.Visible= false;
            label6.Visible= false;
            textBox5.Visible= false;
            button3.Visible= false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new TreatmentMenu().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new ViewTreatment().Show();
        }

        private void button3_Click(object sender, EventArgs e)
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
                MessageBox.Show("Only numbers can be accecpted in the treatment price field");
            }
            else if (f == true || g == true || h == true || i == true)
            {
                MessageBox.Show("Please ensure that you have not left any fields empty");
            }
            else
            {
                EditTreatment();
                clearBoxes();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //EditVisible();
            searchTreatmentsByName();
            //fillBoxes();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditVisible()
        {
            label2.Visible = true;
            textBox1.Visible= true; 
            label4.Visible= true;
            textBox3.Visible= true;
            label5.Visible= true;
            textBox4.Visible= true;
            label6.Visible= true;
            textBox5.Visible= true;
            button3.Visible= true;
        }

        private void EditTreatments_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void searchTreatmentsByName()
        {
            List<string> treatmentNames = TreatmentDAL.treatmentsByTreatmentName(textBox2.Text);
            if (treatmentNames.Count > 0)
            {
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name ="TreatmentID";
                dataGridView1.Columns[1].Name ="TreatmentName";
                dataGridView1.Columns[2].Name ="TreatmentDescription";
                dataGridView1.Columns[3].Name ="TreatmentContents";
                dataGridView1.Columns[4].Name ="TreatmentCost";
                foreach (string TreatmentID in treatmentNames)
                {
                    string[] info = TreatmentID.Split(',');
                    dataGridView1.Rows.Add(info);
                }
                fillBoxes();
                EditVisible();
            }
            else
            {
                MessageBox.Show("No Treatments found", "No Treatments");
            }
        }

        private void fillBoxes()
        {
            textBox1.Text=(string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            textBox2.Text=(string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value;
            textBox3.Text=(string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value;
            textBox4.Text=(string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value;
            textBox5.Text=(string)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[4].Value;
        }

        private void clearBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EditTreatment()
        {
            int rowsAffected = TreatmentDAL.updateTreatmentsInformation(textBox2.Text, 
            textBox3.Text, textBox4.Text, Convert.ToDecimal(textBox5.Text), Convert.ToInt32(textBox1.Text));
            if (rowsAffected > 0)
            {
                MessageBox.Show("Treatment details successfully updated", "Update successful");
            }
            else
            {
                MessageBox.Show("Treatment details could not be updated", "Update failed");
            }
        }
    }
}
