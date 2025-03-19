using Microsoft.EntityFrameworkCore;
using InventoryManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagement.Data
{
    public class DatabaseHelper : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<BillPerson> BillPersons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-5HJDH0FT;Database=InventoryDB;Trusted_Connection=True;");
        }

        public bool ValidateBillPerson(string username, string password)
        {
            return BillPersons.Any(bp => bp.Username == username && bp.Password == password);
        }

        public List<Product> GetProducts()
        {
            return Products.ToList();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            Products.Update(product);
            SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = Products.Find(id);
            if (product != null)
            {
                Products.Remove(product);
                SaveChanges();
            }
        }

        public void BillProduct(int id, int quantity)
        {
            var product = Products.Find(id);
            if (product != null && product.Quantity >= quantity)
            {
                product.Quantity -= quantity;
                SaveChanges();
            }
        }
    }
}