
using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryManagement.Forms
{
    partial class ProductManagement
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewProducts;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnGenerateReports;

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
            this.txtId = new TextBox();
            this.txtName = new TextBox();
            this.txtQuantity = new TextBox();
            this.txtPrice = new TextBox();
            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnGenerateReports = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();

            // dataGridViewProducts
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(500, 200);

            // txtId
            this.txtId.Location = new System.Drawing.Point(20, 240);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = false; // Allow manual entry of ID
            this.txtId.Size = new System.Drawing.Size(100, 20);

            // txtName
            this.txtName.Location = new System.Drawing.Point(140, 240);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);

            // txtQuantity
            this.txtQuantity.Location = new System.Drawing.Point(260, 240);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(380, 240);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(20, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(140, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(260, 280);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            // btnGenerateReports
            this.btnGenerateReports.Location = new System.Drawing.Point(400, 280);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(120, 30);
            this.btnGenerateReports.Text = "Generate Reports";

            this.btnGenerateReports.UseVisualStyleBackColor =
            true;
            this.btnGenerateReports.Click +=
            new EventHandler(this.btnGenerateReports_Click);

            // ProductManagement Form 
            this.ClientSize =
            new System.Drawing.Size(540,
            330);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGenerateReports);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
        }
    }
}