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
    public partial class ViewTreatment : Form
    {
        public ViewTreatment()
        {
            InitializeComponent();
            label1.Visible = false;
            textBox1.Visible = false;
            button4.Visible = false;
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
            Hide();
            new TreatmentMenu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "Treatment Name";
            button3.Visible = false;
            button4.Visible = true;
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
            }
            else
            {
                MessageBox.Show("No Treatments found", "No Treatments");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchTreatmentsByName();
        }
    }
}
