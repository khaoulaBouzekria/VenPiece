using System;
using VenPiece.Desktop.Repository;

namespace VenPiece.Desktop.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IClientRepository Clients { get; }
        IDeliveryRepository Deliveries { get; }
        IEmployeeRepository Employees { get; }
        IInvoiceRepository Invoices { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        int Complete();
    }
}