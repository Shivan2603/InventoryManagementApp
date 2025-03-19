using InventoryManagement.Models;
using System.Linq;

namespace InventoryManagement.Data
{
    public static class DatabaseInitializer
    {
        public static void InitializeDatabase()
        {
            using (var db = new DatabaseHelper())
            {
                db.Database.EnsureCreated();

                if (!db.BillPersons.Any())
                {
                    db.BillPersons.Add(new BillPerson
                    {
                        Username = "billperson",
                        Password = "password"
                    });
                    db.SaveChanges();
                }
            }
        }
    }
}