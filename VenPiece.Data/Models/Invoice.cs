using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VenPiece.Data.Models
{
    /// <summary>
    /// A class that represents the Invoice model
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Invoice identifier
        /// </summary>
        [Key, ForeignKey("Order")]
        public Guid InvoiceId { get; set; }
        /// <summary>
        /// Invoice date
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Invoice payement deadline
        /// </summary>
        public DateTime PayementDeadline { get; set; }
        public virtual Order Order { get; set; }

    }
}
