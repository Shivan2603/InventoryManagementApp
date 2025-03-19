using System.Windows.Forms;

namespace InventoryManagement.Forms
{
    partial class BarcodeForm
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBoxBarcode;

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
            this.pictureBoxBarcode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            this.SuspendLayout();

            // pictureBoxBarcode
            this.pictureBoxBarcode.Dock = DockStyle.Fill;
            this.pictureBoxBarcode.SizeMode = PictureBoxSizeMode.Zoom; // Ensures the image fits the PictureBox
            this.pictureBoxBarcode.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(400, 200);
            this.pictureBoxBarcode.TabIndex = 0;
            this.pictureBoxBarcode.TabStop = false;

            // BarcodeForm
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.pictureBoxBarcode);
            this.Name = "BarcodeForm";
            this.Text = "Barcode Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            this.ResumeLayout(false);
        }
    }
}