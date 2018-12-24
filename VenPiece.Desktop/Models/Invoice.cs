using System;

namespace VenPiece.Desktop.Models
{
    /// <summary>
    /// A class that represents the Invoice model
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Invoice identifier
        /// </summary>
        public Guid InvoiceId { get; set; }
        /// <summary>
        /// Invoice date
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Invoice payement deadline
        /// </summary>
        public DateTime PayementDeadline { get; set; }
    }
}
