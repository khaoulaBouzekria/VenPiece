using System.Collections.Generic;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public interface IClientRepository : IRepository<Client>
    {
        Task<Client> GetClientByIdAsync(string Id);
        Task<List<Client>> GetClientsAsync();
    }
}