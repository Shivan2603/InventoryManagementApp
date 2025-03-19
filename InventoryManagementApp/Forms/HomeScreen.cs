using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagement.Forms
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            ApplyStyling();
        }

        private void ApplyStyling()
        {
            this.BackColor = Color.FromArgb(240, 240, 240); // Light gray background
            btnManagerLogin.BackColor = Color.FromArgb(0, 122, 204); // Blue button
            btnManagerLogin.ForeColor = Color.White;
            btnBillPersonLogin.BackColor = Color.FromArgb(0, 122, 204); // Blue button
            btnBillPersonLogin.ForeColor = Color.White;
        }

        private void btnManagerLogin_Click(object sender, EventArgs e)
        {
            var managerLogin = new ManagerLogin();
            managerLogin.ShowDialog();
        }

        private void btnBillPersonLogin_Click(object sender, EventArgs e)
        {
            var billPersonLogin = new BillPersonLogin();
            billPersonLogin.ShowDialog();
        }
    }
}