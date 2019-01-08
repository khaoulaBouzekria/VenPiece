
using System.Collections.Generic;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {
       Task<Order> GetOrderByIdAsync(string id);
        Task<List<Order>> GetOrdersAsync();
    }
}
