using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VenPiece.Models
{
    public class Invoice
    {
        public Guid InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public DateTime PayementDeadline { get; set; }
    }
}
