using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using VenPiece.Data.Models;

namespace VenPiece.Data.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        VenPieceDbContext VpDbContext = new VenPieceDbContext();

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