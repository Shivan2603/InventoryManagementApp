using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;
using InventoryManagement.Data;

namespace InventoryManagement.Forms
{
    public partial class ReportsForm : Form
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public ReportsForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            dataGridViewProducts.AutoGenerateColumns = true; // Fix for empty grid.
            dataGridViewProducts.DataSource = _dbHelper.GetProducts();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var products = _dbHelper.GetProducts();
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Products");

                    worksheet.Cells["A1"].Value = "ID";
                    worksheet.Cells["B1"].Value = "Name";
                    worksheet.Cells["C1"].Value = "Quantity";
                    worksheet.Cells["D1"].Value = "Price";
                    worksheet.Cells["E1"].Value = "Barcode";

                    int rowIndex = 2;
                    foreach (var product in products)
                    {
                        worksheet.Cells[$"A{rowIndex}"].Value = product.Id;
                        worksheet.Cells[$"B{rowIndex}"].Value = product.Name;
                        worksheet.Cells[$"C{rowIndex}"].Value = product.Quantity;
                        worksheet.Cells[$"D{rowIndex}"].Value = product.Price;
                        worksheet.Cells[$"E{rowIndex}"].Value = product.Barcode;
                        rowIndex++;
                    }

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    var saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx",
                        Title = "Save Report"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        package.SaveAs(new FileInfo(saveFileDialog.FileName));
                        MessageBox.Show($"Report saved successfully at {saveFileDialog.FileName}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting report: {ex.Message}");
            }
        }
    }
}
