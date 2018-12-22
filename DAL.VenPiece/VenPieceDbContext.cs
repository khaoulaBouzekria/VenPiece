using System.Data.Entity;
using DAL.VenPiece.Models;

namespace DAL.VenPiece
{
    /// <summary>
    /// VenPiece Database Context
    /// </summary>
    public class VenPieceDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
