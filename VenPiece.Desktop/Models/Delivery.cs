using System;
using System.Collections.Generic;

namespace VenPiece.Desktop.Models
{
    /// <summary>
    /// A class that represents the Delivery model
    /// </summary>
    public class Delivery
    {
        /// <summary>
        /// Delivery identifier
        /// </summary>
        public Guid DeliveryId { get; set; }
        /// <summary>
        /// Delivery date 
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Delivery weight
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// Number of packages in a delivery
        /// </summary>
        public int NumberOfPackages { get; set; }
        public Guid OrderId { get; set; }

        public virtual Order Order { get; set; }

        public virtual ICollection<DeliveryItem> DeliveryItems { get; set; }

        public Delivery()
        {
            this.DeliveryItems = new HashSet<DeliveryItem>();
        }

    }
}
