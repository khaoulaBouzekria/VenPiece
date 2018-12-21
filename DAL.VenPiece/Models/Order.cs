using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VenPiece.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime ArrivingDate { get; set; }
        public String state { get; set; }
    }
}
