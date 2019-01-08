using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        public VenPieceDbContext VpDbContext => Context as VenPieceDbContext;
        public InvoiceRepository(DbContext context) : base(context)
        {
        }

        public Task<Invoice> GetInvoiceByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Invoice>> GetClientsAsync()
        {
            return VpDbContext.Invoices.ToListAsync();
        }
    }
}