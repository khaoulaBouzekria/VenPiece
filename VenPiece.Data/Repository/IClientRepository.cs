using System.Collections.Generic;
using System.Threading.Tasks;
using VenPiece.Data.Models;

namespace VenPiece.Data.Repository
{
    public interface IClientRepository
    {
        Task<Client> GetClientByIdAsync(string Id);
        Task<List<Client>> GetClientsAsync();
        Task<Client> UpdateClientAsync(Client client);
        Task<Client> AddClientAsync(Client client);
    }
}