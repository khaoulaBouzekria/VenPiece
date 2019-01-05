using System.Data.Entity;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(DbContext context) : base(context)
        {
        }

        public Client GetClientById(string Id)
        {
            throw new System.NotImplementedException();
        }
    }
}