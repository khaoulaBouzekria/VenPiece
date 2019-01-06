using System;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public interface IInvoiceRepository : IRepository<Invoice>
    {
        Invoice GetInvoiceById(Guid Id);
    }
}