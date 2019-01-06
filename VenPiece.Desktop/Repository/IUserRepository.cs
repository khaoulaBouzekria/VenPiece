using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public interface IUserRepository : IRepository<InternalUserData>
    {
        InternalUserData GetUserByUsername(string username);
    }
}