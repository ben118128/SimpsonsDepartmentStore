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
    public partial class BeautyCosmetics : Form
    {
        public BeautyCosmetics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new TreatmentMenu().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new BookingMenu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new CustomerMenu().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new StaffMenu().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new StartPage().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            new ReportsMenu().Show();
        }
    }
}
