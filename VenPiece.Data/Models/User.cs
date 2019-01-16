using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace VenPiece.Data.Models
{
    public class User
    {
        public User(string username, string email, string roles)
        {
            Username = username;
            Email = email;
            Roles = JsonConvert.DeserializeObject<string[]>(roles);
        }

        [Key]
        public string Username
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string[] Roles
        {
            get;
            set;
        }
    }
}
