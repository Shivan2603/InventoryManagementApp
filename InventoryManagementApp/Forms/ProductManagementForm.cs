using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Forms
{
    public partial class ProductManagement : Form
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public ProductManagement()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            dataGridViewProducts.AutoGenerateColumns = false;
            // Clear existing columns
            dataGridViewProducts.Columns.Clear();
            // Define columns explicitly
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID" });
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Name" });
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Quantity" });
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Price", HeaderText = "Price" });
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Barcode", HeaderText = "Barcode" });
            // Bind the data source
            dataGridViewProducts.DataSource = _dbHelper.GetProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput(out string name, out int quantity, out decimal price))
                {
                    // Generate a unique barcode text
                    string barcodeText = Guid.NewGuid().ToString("N").Substring(0, 12);
                    // Store the barcode text in the Product object
                    _dbHelper.AddProduct(new Product
                    {
                        Name = name,
                        Quantity = quantity,
                        Price = price,
                        Barcode = barcodeText // Assign the barcode text (string)
                    });
                    LoadProducts();
                    MessageBox.Show("Product added successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtId.Text, out int id) && ValidateInput(out string name, out int quantity, out decimal price))
                {
                    var product = _dbHelper.Products.Find(id);
                    if (product == null)
                    {
                        MessageBox.Show("Product not found.");
                        return;
                    }

                    product.Name = name;
                    product.Quantity = quantity;
                    product.Price = price;

                    _dbHelper.UpdateProduct(product);
                    LoadProducts();
                    MessageBox.Show("Product updated successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtId.Text, out int id))
                {
                    var product = _dbHelper.Products.Find(id);
                    if (product == null)
                    {
                        MessageBox.Show("Product not found.");
                        return;
                    }

                    _dbHelper.DeleteProduct(id);
                    LoadProducts();
                    MessageBox.Show("Product deleted successfully");
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var row = dataGridViewProducts.SelectedRows[0];
                txtId.Text = row.Cells["Id"].Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells["Name"].Value?.ToString() ?? string.Empty;
                txtQuantity.Text = row.Cells["Quantity"].Value?.ToString() ?? string.Empty;
                txtPrice.Text = row.Cells["Price"].Value?.ToString() ?? string.Empty;
            }
        }

        private bool ValidateInput(out string name, out int quantity, out decimal price)
        {
            name = txtName.Text.Trim();
            quantity = int.TryParse(txtQuantity.Text, out int q) ? q : 0;
            price = decimal.TryParse(txtPrice.Text, out decimal p) ? p : 0;
            if (string.IsNullOrWhiteSpace(name) || quantity <= 0 || price <= 0)
            {
                MessageBox.Show("Please enter valid product details.");
                return false;
            }
            return true;
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            var reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }
    }
}