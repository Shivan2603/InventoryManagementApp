using System;
using System.Windows.Forms;

namespace InventoryManagement.Forms
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "manager" && txtPassword.Text == "password")
            {
                var productManagement = new ProductManagement();
                productManagement.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}