using System.Data.Entity;
using VenPiece.Desktop.Models;
using VenPiece.Desktop.Services;

namespace VenPiece.Desktop
{
    /// <summary>
    /// VenPiece Database Context
    /// </summary>
    public class VenPieceDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<DeliveryItem> DeliveryItems { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public  DbSet<InternalUserData> Users { get; set; }
    }
}
