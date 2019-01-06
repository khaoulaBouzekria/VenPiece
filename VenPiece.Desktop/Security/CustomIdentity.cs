using System.Security.Principal;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Security
{
    public class CustomIdentity : IIdentity
    {
        public CustomIdentity(string name, string email, string[] roles)
        {
            Name = name;
            Email = email;
            Roles = roles;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string[] Roles { get; private set; }

        #region IIdentity Members
        public string AuthenticationType => "Custom authentication";

        public bool IsAuthenticated => !string.IsNullOrEmpty(Name);

        #endregion
    }
}
