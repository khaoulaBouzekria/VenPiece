using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public VenPieceDbContext VpDbContext => Context as VenPieceDbContext;
        public ClientRepository(DbContext context) : base(context)
        {
        }
        public ClientRepository() : base()
        {
            
        }

        public Task<Client> GetClientByIdAsync(string Id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Client>> GetClientsAsync()
        {
            return VpDbContext.Clients.ToListAsync();
        }
    }
}