using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenPiece.Desktop.Models
{
    public class User
    {
        public User(string username, string email, string[] roles)
        {
            Username = username;
            Email = email;
            Roles = roles;
            
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
