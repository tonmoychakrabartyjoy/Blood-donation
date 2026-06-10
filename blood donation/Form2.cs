using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace blood_donation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel5.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            panel5.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel5.Show();
        }

        private void btnDonor_Click(object sender, EventArgs e)
        {
            Users addDonor = new Users();
            addDonor.Show();
            this.Hide();
        }
    }
}
