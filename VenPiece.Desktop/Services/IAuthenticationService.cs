
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Services
{
    public interface IAuthenticationService
    {
        User AuthenticateUser(string username, string password);
    }
}
