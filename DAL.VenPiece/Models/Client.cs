using System;

namespace DAL.VenPiece.Models
{
    /// <summary>
    /// A class that represents the Client model
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Client identifier
        /// </summary>
        public Guid ClientId { get; set; }
        /// <summary>
        /// Client name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Client address
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Client type
        /// </summary>
        public ClientType Type { get; set; }
    }
}
