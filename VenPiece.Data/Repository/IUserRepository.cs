using VenPiece.Data.Models;

namespace VenPiece.Data.Repository
{
    public interface IUserRepository 
    {
        InternalUserData GetUserByUsername(string username);
    }
}