using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VenPiece.Data.Annotations;

namespace VenPiece.Data.Models
{
    /// <summary>
    /// A class that represents the Client model
    /// </summary>
    public class Client : INotifyPropertyChanged
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
        /// <summary>
        /// Client Phone Number
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Represents the client email address
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Represents the client street address
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Represents the client's city
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Represents the client's country
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Represents the ZIP CODE for the client's address
        /// </summary>
        public string Zip { get; set; }
        /// <summary>
        /// Represents the list of orders that the client made
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }

        public Client()
        {
            this.Orders = new HashSet<Order>();
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
