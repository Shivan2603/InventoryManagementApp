using System;
using System.Windows.Forms;
using InventoryManagement.Data;

namespace InventoryManagement.Forms
{
    public partial class BillPersonLogin : Form
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public BillPersonLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (_dbHelper.ValidateBillPerson(username, password))
            {
                var billing = new Billing();
                billing.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}