using Microsoft.EntityFrameworkCore; // Only EF Core
using InventoryManagement.Models;

namespace InventoryManagement.Data
{
    public class InventoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}