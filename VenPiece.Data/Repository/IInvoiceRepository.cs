using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VenPiece.Data.Models;

namespace VenPiece.Data.Repository
{
    public interface IInvoiceRepository 
    {
        Task<Invoice> GetInvoiceByIdAsync(Guid Id);
        Task<List<Invoice>> GetClientsAsync();
    }
}