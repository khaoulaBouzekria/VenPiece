using System;
using System.Data.Entity;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(DbContext context) : base(context)
        {
        }

        public Invoice GetInvoiceById(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}