﻿using System;
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
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new BeautyCosmetics().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new MedicalQuestionnaire().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new ViewCustomer().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new EditCustomer().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteCustomer().Show();
        }
    }
}
