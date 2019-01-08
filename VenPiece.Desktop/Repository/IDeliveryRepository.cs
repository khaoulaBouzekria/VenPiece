using System.Collections.Generic;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public interface IDeliveryRepository : IRepository<Delivery>
    {
        Task<Delivery> GetDeliveryByIdAsync(string id);
        Task<List<Delivery>> GetDeliveriesAsync();
    }
}