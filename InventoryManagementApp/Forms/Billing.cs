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

            // Define columns explicitly
            dataGridViewProducts.Columns.Clear();
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID" });
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Name" });
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Quantity" });
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Price", HeaderText = "Price" });
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Barcode", HeaderText = "Barcode" });

            dataGridViewProducts.DataSource = _dbHelper.GetProducts();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewProducts.SelectedRows[0];
                int id = int.Parse(row.Cells["Id"].Value.ToString());
                int quantity;
                if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                _dbHelper.BillProduct(id, quantity);
                LoadProducts();
                MessageBox.Show("Product billed successfully");
            }
            else
            {
                MessageBox.Show("Please select a product to bill.");
            }
        }
    }
}