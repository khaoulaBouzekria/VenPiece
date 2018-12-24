using System;

namespace VenPiece.Desktop.Models
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
