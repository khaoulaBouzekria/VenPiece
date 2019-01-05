using System.Data.Entity;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context) : base(context)
        {
        }

        public Order GetOrderById(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}