using System;
using System.Drawing;
using System.Windows.Forms;
using InventoryManagement.Utils;

namespace InventoryManagement.Forms
{
    public partial class BarcodeForm : Form
    {
        public BarcodeForm(string barcodeText)
        {
            InitializeComponent();
            LoadBarcode(barcodeText);
        }

        private void LoadBarcode(string barcodeText)
        {
            try
            {
                // Generate the barcode image
                Bitmap barcodeImage = BarcodeGenerator.GenerateBarcode(barcodeText);

                // Assign the image to the PictureBox
                pictureBoxBarcode.Image = barcodeImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating barcode: {ex.Message}");
            }
        }
    }
}