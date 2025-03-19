using System.Windows.Forms;
using System;

namespace InventoryManagement.Forms
{
    partial class Billing
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewProducts;
        private TextBox txtQuantity;
        private Button btnBill;

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
            this.txtQuantity = new TextBox();
            this.btnBill = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();

            // dataGridViewProducts
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(500, 200);
            this.dataGridViewProducts.TabIndex = 0;

            // txtQuantity
            this.txtQuantity.Location = new System.Drawing.Point(20, 240);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);

            // btnBill
            this.btnBill.Location = new System.Drawing.Point(140, 240);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(100, 30);
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new EventHandler(this.btnBill_Click);

            // Billing Form
            this.ClientSize = new System.Drawing.Size(540, 300);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "Billing";
            this.Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}