using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public class DeliveryRepository : Repository<Delivery>, IDeliveryRepository
    {
        public VenPieceDbContext VpDbContext => Context as VenPieceDbContext;
        public DeliveryRepository(DbContext context) : base(context)
        {
        }

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