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
    public partial class DeleteTreatment : Form
    {
        public DeleteTreatment()
        {
            InitializeComponent();
            button2.Visible = false;
            button5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> allTreatments = TreatmentDAL.SelectAllTreatments();

            if (allTreatments.Count > 0)
            {
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Treatment ID";
                dataGridView1.Columns[1].Name = "Treatment Name";
                dataGridView1.Columns[2].Name = "Treatment Description";
                dataGridView1.Columns[3].Name = "Treatment Contents";
                dataGridView1.Columns[4].Name = "Treatment Cost";
                
                foreach (string TreatmentID in allTreatments)
                {
                    string[] info = TreatmentID.Split(',');
                    dataGridView1.Rows.Add(info);
                }
              
            }
            else
            {
                MessageBox.Show("No treatments found", "No treatments");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchTreatmentsByName();
            //DeleteVisibile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new TreatmentMenu().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            int rowsAffected = TreatmentDAL.DeleteTreatment(textBox1.Text);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Treatment has been removed successfully.", "Success");
            }
            else
            {
                MessageBox.Show("Treatment has not been removed", "Error");
            }
        }

        private void DeleteVisibile()
        {
            textBox1.Visible= true;
            button5.Visible= true;
            button1.Visible = false;
            button3.Visible= false;
        }

        private void searchTreatmentsByName()
        {
            List<string> treatmentNames = TreatmentDAL.treatmentsByTreatmentName(textBox1.Text);
            if (treatmentNames.Count > 0)
            {
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "TreatmentID";
                dataGridView1.Columns[1].Name = "TreatmentName";
                dataGridView1.Columns[2].Name = "TreatmentDescription";
                dataGridView1.Columns[3].Name = "TreatmentContents";
                dataGridView1.Columns[4].Name = "TreatmentCost";
                foreach (string TreatmentID in treatmentNames)
                {
                    string[] info = TreatmentID.Split(',');
                    dataGridView1.Rows.Add(info);
                }
                DeleteVisibile();
            }
            else
            {
                MessageBox.Show("No Treatments found", "No Treatments");
            }
        }

        private void DeleteStaffBySurname()
        {
            int rowsAffected = TreatmentDAL.DeleteTreatment(textBox1.Text);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Treatment has been deleted.", "Success");
            }
            else
            {
                MessageBox.Show("Treatment of staff has not been deleted", "Error");
            }
        }
    }
}
