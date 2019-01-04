
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Security
{
    public class AnonymousIdentity : CustomIdentity
    {
        public AnonymousIdentity()
            : base(string.Empty, string.Empty, new string[] { })
        { }
    }
}
