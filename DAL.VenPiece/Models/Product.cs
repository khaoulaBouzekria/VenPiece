using System;

namespace DAL.VenPiece.Models
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
        /// The product is it out of stock !
        /// </summary>
        public Boolean OutOfStock { get; set; }
    }
}
