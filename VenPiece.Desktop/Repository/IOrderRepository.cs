
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order GetOrderById(string id);
    }
}
