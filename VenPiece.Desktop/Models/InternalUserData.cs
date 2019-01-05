using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenPiece.Desktop.Models
{
    public class InternalUserData
    {
        public InternalUserData()
        {

        }
        public InternalUserData(string username, string email, string hashedPassword, string roles)
        {
            Username = username;
            Email = email;
            HashedPassword = hashedPassword;
            Roles = roles;
        }
        [Key]
        public string Username
        {
            get;
            private set;
        }

        public string Email
        {
            get;
            private set;
        }

        public string HashedPassword
        {
            get;
            private set;
        }

        public string Roles
        {
            get;
            set;
        }
    }
}
