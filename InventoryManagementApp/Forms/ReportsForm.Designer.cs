using System;
using System.Windows.Forms;

namespace InventoryManagement.Forms
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewProducts;
        private Button btnExport;

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
            this.dataGridViewProducts = new DataGridView();
            this.btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();

            // dataGridViewProducts
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(500, 200);

            // btnExport
            this.btnExport.Location = new System.Drawing.Point(20, 240);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 30);
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new EventHandler(this.btnExport_Click);

            // ReportsForm
            this.ClientSize = new System.Drawing.Size(540, 300);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataGridViewProducts);
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
