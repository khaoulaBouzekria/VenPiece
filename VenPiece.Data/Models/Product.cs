using System;
using System.Collections.Generic;

namespace VenPiece.Data.Models
{
    /// <summary>
    /// A class that represents a Product
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product identifier
        /// </summary>
        public Guid ProductId { get; set; }
        /// <summary>
        /// Product designation
        /// </summary>
        public String Designation { get; set; }
        /// <summary>
        /// Product price
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// Product quantity
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Product description
        /// </summary>
        public string Description { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public Product()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }
    }
}
