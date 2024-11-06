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
    public partial class TreatmentMenu : Form
    {
        public TreatmentMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new AddTreatment().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new ViewTreatment().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new EditTreatments().Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteTreatment().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new BeautyCosmetics().Show();
        }
    }
}
