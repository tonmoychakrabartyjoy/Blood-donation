using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace blood_donation
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pass = txtPass.Text;
            string phone = txtPhone.Text;
            if (name == "")
            {
                MessageBox.Show("add name first");
            }
            else if (pass == "")
            {
                MessageBox.Show("add pass first");
            }
            else if (phone == "")
            {
                MessageBox.Show("add phone first");
            }
            else
            {
                MessageBox.Show("saved");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPhone.Clear();
            txtName.Clear();
            txtPass.Clear();
        }
    }
}
