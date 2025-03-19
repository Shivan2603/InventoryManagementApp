using System;
using System.Windows.Forms;
using InventoryManagement.Data;

namespace InventoryManagement
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            DatabaseInitializer.InitializeDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.HomeScreen());
        }
    }
}