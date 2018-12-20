using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.VenPiece.Models;

namespace DAL.VenPiece
{
    public class VenPieceDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
    }
}
