using System.ComponentModel.DataAnnotations;

namespace VenPiece.Data.Models
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
