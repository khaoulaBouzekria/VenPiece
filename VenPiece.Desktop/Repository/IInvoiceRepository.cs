using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public interface IInvoiceRepository : IRepository<Invoice>
    {
        Task<Invoice> GetInvoiceByIdAsync(Guid Id);
        Task<List<Invoice>> GetClientsAsync();
    }
}