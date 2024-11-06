using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SimpsonsDepartmentStore
{
    public partial class MedicalQuestionnaire : Form
    {
        public MedicalQuestionnaire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count >= 3 || checkedListBox1.GetItemChecked(0) || checkedListBox1.GetItemChecked(6))
            {
                MessageBox.Show("You are not eligble for spa treatments", "Health issues.");
                new BeautyCosmetics().Show();
                Hide();
            }
            else if (checkedListBox1.CheckedItems.Count<= 2)
            {
                MessageBox.Show("You are eligible for spa treatments", "Congratulations");
                new AddCustomer().Show();
                Hide();
            }
        }
    }
}
