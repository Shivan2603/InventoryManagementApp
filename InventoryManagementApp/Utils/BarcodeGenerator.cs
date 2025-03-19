using ZXing;
using ZXing.Common;
using System.Drawing;
using System;

namespace InventoryManagement.Utils
{
    public static class BarcodeGenerator
    {
        public static Bitmap GenerateBarcode(string barcodeText)
        {
            if (string.IsNullOrWhiteSpace(barcodeText))
            {
                throw new ArgumentException("Barcode text cannot be null or empty.");
            }

            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Height = 100,
                    Width = 300,
                    Margin = 5
                }
            };
            return writer.Write(barcodeText); // Returns a Bitmap
        }
    }
}