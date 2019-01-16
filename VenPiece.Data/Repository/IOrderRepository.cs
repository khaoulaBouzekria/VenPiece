using System.Collections.Generic;
using System.Threading.Tasks;
using VenPiece.Data.Models;

namespace VenPiece.Data.Repository
{
    public interface IOrderRepository 
    {
       Task<Order> GetOrderByIdAsync(string id);
        Task<List<Order>> GetOrdersAsync();
    }
}
