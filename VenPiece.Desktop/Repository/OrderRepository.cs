using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public VenPieceDbContext VpDbContext => Context as VenPieceDbContext;
        public OrderRepository(DbContext context) : base(context)
        {
        }

        public Task<Order> GetOrderByIdAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Order>> GetOrdersAsync()
        {
            return VpDbContext.Orders.ToListAsync();
        }
    }
}