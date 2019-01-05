using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public class UserRepository : Repository<InternalUserData>, IUserRepository
    {
        public UserRepository(VenPieceDbContext context) : base(context)
        {
        }

        public InternalUserData GetUserByUsername(string username)
        {
            return VPDbContext.Users.FirstOrDefault(s => s.Username == username);
        }

        public VenPieceDbContext VPDbContext
        {
            get { return Context as VenPieceDbContext; }
        }
    }
}