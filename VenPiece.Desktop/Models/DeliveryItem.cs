using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenPiece.Desktop.Models
{
    public class DeliveryItem
    {
        [Key]
        public Guid Id { get; set; }
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
        public virtual Delivery Delivery { get; set; }
    }
}
