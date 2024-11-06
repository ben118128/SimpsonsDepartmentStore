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
    public partial class TreatmentReports : Form
    {
        public TreatmentReports()
        {
            InitializeComponent();
        }

        private void TreatmentReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beautyAndCosmeticsDataSet1.Treatment' table. You can move, or remove it, as needed.
            this.treatmentTableAdapter.Fill(this.beautyAndCosmeticsDataSet1.Treatment);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new ReportsMenu().Show();
        }
    }
}
