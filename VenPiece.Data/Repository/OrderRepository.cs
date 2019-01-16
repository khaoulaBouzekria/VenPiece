using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using VenPiece.Data.Models;

namespace VenPiece.Data.Repository
{
    public class OrderRepository :  IOrderRepository
    {
        VenPieceDbContext VpDbContext = new VenPieceDbContext();

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