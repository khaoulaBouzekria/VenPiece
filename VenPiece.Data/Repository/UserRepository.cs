using System.Linq;
using VenPiece.Data.Models;

namespace VenPiece.Data.Repository
{
    public class UserRepository : Repository<InternalUserData>, IUserRepository
    {
        public UserRepository(VenPieceDbContext context) : base(context)
        {
        }

        public InternalUserData GetUserByUsername(string username)
        {
            return VpDbContext.Users.FirstOrDefault(s => s.Username == username);
        }

        public VenPieceDbContext VpDbContext => Context as VenPieceDbContext;
    }
}