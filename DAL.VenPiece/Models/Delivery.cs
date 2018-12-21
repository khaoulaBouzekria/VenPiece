using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VenPiece.Models
{
    public class Delivery
    {
        public Guid DeliveryId { get; set; }
        public DateTime Date { get; set; }
        public int Weight { get; set; }
        public int NumberOfPackages {get; set;}

    }
}
