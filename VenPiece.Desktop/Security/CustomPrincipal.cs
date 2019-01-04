using System.Linq;
using System.Security.Principal;

namespace VenPiece.Desktop.Security
{
    public class CustomPrincipal : IPrincipal
    {
        private CustomIdentity _identity;

        public CustomIdentity Identity
        {
            get => _identity ?? new AnonymousIdentity();
            set => _identity = value;
        }

        #region IPrincipal Members
        IIdentity IPrincipal.Identity => this.Identity;

        public bool IsInRole(string role)
        {
            return _identity.Roles.Contains(role);
        }
        #endregion
    }
}
