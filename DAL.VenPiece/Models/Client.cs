using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VenPiece.Models
{
    public class Client
    {
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
    }
}
