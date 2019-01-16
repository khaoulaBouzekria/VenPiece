using System;
using System.ComponentModel.DataAnnotations;

namespace VenPiece.Data.Models
{
    public class OrderItem
    {
        /// <summary>
        /// Order Item Identifier
        /// </summary>
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// Order Identifier
        /// </summary>
        public Guid OrderId { get; set; }
        /// <summary>
        /// Product Identifier
        /// </summary>
        public Guid ProductId { get; set; }
        /// <summary>
        /// Represents the quantity of the product ordered
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Represents the unit price for the product ordered
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// Represents the total price for the ordered item 
        /// </summary>
        public decimal TotalPrice { get; set; }
        /// <summary>
        /// Represents instruction for a particular item
        /// </summary>
        public string Instructions { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}