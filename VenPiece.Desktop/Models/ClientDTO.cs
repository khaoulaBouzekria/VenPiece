using System;
using System.ComponentModel.DataAnnotations;
using VenPiece.Data.Models;

namespace VenPiece.Desktop.Models
{
    public class ClientDTO : ValidatableBindableBase
    {
        private Guid _clientId;

        public Guid ClientId
        {
            get => _clientId;
            set => SetProperty(ref _clientId, value);
        }


        /// <summary>
        /// Client name
        /// </summary>
        private string _name;
        [Required]
        public string Name { get=>_name; set=>SetProperty(ref _name, value); }

        /// <summary>
        /// Client address
        /// </summary>
        private string _address;
        public string Address { get => _address; set => SetProperty(ref _address, value); }

        /// <summary>
        /// Client type
        /// </summary>
        private ClientType _type;
        public ClientType Type { get=> _type; set =>SetProperty(ref _type, value); }

        /// <summary>
        /// Client Phone Number
        /// </summary>
        private string _phone;
        [Phone]
        public string Phone { get =>_phone; set => SetProperty(ref _phone, value); }

        /// <summary>
        /// Represents the client email address
        /// </summary>
        private string _email;
        [EmailAddress]
        public string Email { get => _email; set =>SetProperty(ref _email, value); }

        /// <summary>
        /// Represents the client street address
        /// </summary>
        private string _street;
        public string Street
        {
            get => _street; set => SetProperty(ref _street,value); }

        /// <summary>
        /// Represents the client's city
        /// </summary>
        private string _city;
        public string City { get => _city; set =>SetProperty(ref _city, value); }

        /// <summary>
        /// Represents the client's country
        /// </summary>
        private string _country;
        public string Country { get => _country; set =>SetProperty(ref _country, value); }

        /// <summary>
        /// Represents the ZIP CODE for the client's address
        /// </summary>
        private string _zip;
        public string Zip { get => _zip; set => SetProperty(ref _zip, value); }
        
    }
}