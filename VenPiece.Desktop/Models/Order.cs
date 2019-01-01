using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// Order state 
        /// </summary>
        public String State { get; set; }
        /// <summary>
        /// Total of Items
        /// </summary>
        public decimal ItemsTotal { get; set; }
        /// <summary>
        /// Represents the phone number to call on an order
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Represents the client that launched the order
        /// </summary>
        public Guid ClientId { get; set; }

        public virtual Client Client { get; set; }

        public virtual Invoice Invoice { get; set; }
        /// <summary>
        /// Represents the items being ordered
        /// </summary>
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }
    }
}
