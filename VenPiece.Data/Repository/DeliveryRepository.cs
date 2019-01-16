using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using VenPiece.Data.Models;

namespace VenPiece.Data.Repository
{
    public class DeliveryRepository :  IDeliveryRepository
    {
        private VenPieceDbContext VpDbContext = new VenPieceDbContext();

        public Task<Delivery> GetDeliveryByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Delivery>> GetDeliveriesAsync()
        {
            return VpDbContext.Deliveries.ToListAsync();
        }
    }
}