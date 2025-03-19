using System;
using System.Linq;
using System.Windows.Forms;
using InventoryManagement.Data;

namespace InventoryKiosk.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly DatabaseHelper _context;

        public DashboardForm()
        {
            InitializeComponent();
            _context = new DatabaseHelper();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            var totalProducts = _context.Products.Count();
            lblTotalProducts.Text = totalProducts.ToString();

            var lowStockProducts = _context.Products.Count(p => p.Quantity < 10);
            lblLowStock.Text = lowStockProducts.ToString();

            var recentActivities = _context.Products.OrderByDescending(p => p.Id).Take(5).ToList();
            dataGridViewRecent.DataSource = recentActivities;
        }
    }
}