using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VenPiece.Models
{
    /// <summary>
    /// A class that represents the Order model
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Order identifier
        /// </summary>
        public Guid OrderId { get; set; }
        /// <summary>
        /// Order date
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Order state 
        /// </summary>
        public String State { get; set; }
    }
}
