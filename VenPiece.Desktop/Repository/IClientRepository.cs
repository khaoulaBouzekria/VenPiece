using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public interface IClientRepository : IRepository<Client>
    {
        Client GetClientById(string Id);
    }
}