using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public class DeliveryRepository : Repository<Delivery>, IDeliveryRepository
    {
        
        public Delivery GetDeliveryById(string id)
        {
            throw new NotImplementedException();
        }

        public DeliveryRepository(DbContext context) : base(context)
        {
        }
    }
}