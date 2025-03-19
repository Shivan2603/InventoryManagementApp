using System;
using System.Windows.Forms;
using InventoryManagement.Data;

namespace InventoryManagement.Forms
{
    public partial class Billing : Form
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public Billing()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.Columns.Clear();

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id", 
                DataPropertyName = "Id",
                HeaderText = "ID"
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                DataPropertyName = "Name",
                HeaderText = "Product Name"
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                DataPropertyName = "Quantity",
                HeaderText = "Stock"
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                DataPropertyName = "Price",
                HeaderText = "Price"
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Barcode",
                DataPropertyName = "Barcode",
                HeaderText = "Barcode"
            });

            dataGridViewProducts.DataSource = _dbHelper.GetProducts();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to bill.");
                return;
            }

            var row = dataGridViewProducts.SelectedRows[0];

            if (!int.TryParse(row.Cells["Id"].Value?.ToString(), out int id))
            {
                MessageBox.Show("Invalid product selection.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }   

            try
            {
                _dbHelper.BillProduct(id, quantity);
                LoadProducts();
                MessageBox.Show($"{quantity} items billed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
