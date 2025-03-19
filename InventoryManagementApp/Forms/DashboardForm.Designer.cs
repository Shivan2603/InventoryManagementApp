using System.Windows.Forms;

namespace InventoryKiosk.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTotalProducts;
        private Label lblLowStock;
        private DataGridView dataGridViewRecent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTotalProducts = new Label();
            this.lblLowStock = new Label();
            this.dataGridViewRecent = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecent)).BeginInit();
            this.SuspendLayout();

            // lblTotalProducts
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Location = new System.Drawing.Point(20, 20);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(100, 20);
            this.lblTotalProducts.Text = "Total Products: ";

            // lblLowStock
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Location = new System.Drawing.Point(20, 50);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(100, 20);
            this.lblLowStock.Text = "Low Stock: ";

            // dataGridViewRecent
            this.dataGridViewRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecent.Location = new System.Drawing.Point(20, 80);
            this.dataGridViewRecent.Name = "dataGridViewRecent";
            this.dataGridViewRecent.Size = new System.Drawing.Size(500, 200);
            this.dataGridViewRecent.TabIndex = 0;

            // DashboardForm
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dataGridViewRecent);
            this.Controls.Add(this.lblLowStock);
            this.Controls.Add(this.lblTotalProducts);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}