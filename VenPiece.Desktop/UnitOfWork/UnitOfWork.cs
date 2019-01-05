using VenPiece.Desktop.Repository;

namespace VenPiece.Desktop.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VenPieceDbContext _context = new VenPieceDbContext();

        public UnitOfWork()
        {
            Users = new UserRepository(_context);
            Clients = new ClientRepository(_context);
            Deliveries = new DeliveryRepository(_context);
            Employees = new EmployeeRepository(_context);
            Invoices = new InvoiceRepository(_context);
            Orders = new OrderRepository(_context);
            Products = new ProductRepository(_context);
        }
        

        public IUserRepository Users { get; }
        public IClientRepository Clients { get; }
        public IDeliveryRepository Deliveries { get; }
        public IEmployeeRepository Employees { get; }
        public IInvoiceRepository Invoices { get; }
        public IOrderRepository Orders { get; }
        public IProductRepository Products { get; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}