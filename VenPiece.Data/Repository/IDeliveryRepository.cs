using System.Collections.Generic;
using System.Threading.Tasks;
using VenPiece.Data.Models;

namespace VenPiece.Data.Repository
{
    public interface IDeliveryRepository 
    {
        Task<Delivery> GetDeliveryByIdAsync(string id);
        Task<List<Delivery>> GetDeliveriesAsync();
    }
}