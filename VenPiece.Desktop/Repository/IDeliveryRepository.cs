using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public interface IDeliveryRepository : IRepository<Delivery>
    {
        Delivery GetDeliveryById(string id);
    }
}