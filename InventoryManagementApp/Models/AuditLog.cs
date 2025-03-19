using System;

namespace InventoryManagement.Models
{
    public class AuditLog
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string TableName { get; set; }
        public DateTime Timestamp { get; set; }
        public int UserId { get; set; }
    }
}