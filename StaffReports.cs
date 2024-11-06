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
    public partial class StaffReports : Form
    {
        public StaffReports()
        {
            InitializeComponent();
        }

        private void TreatmentsReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beautyAndCosmeticsDataSet1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.beautyAndCosmeticsDataSet1.Staff);

            this.reportViewer1.RefreshReport();
        }
    }
}
