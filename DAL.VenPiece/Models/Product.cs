using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VenPiece.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public String Designation { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public Boolean OutOfStock { get; set; }
    }
}
