using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using VenPiece.Data.Models;

namespace VenPiece.Data.Repository
{
    public class ClientRepository :  IClientRepository
    {
        VenPieceDbContext VpDbContext = new VenPieceDbContext();

        public Task<Client> GetClientByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Client>> GetClientsAsync()
        {
            return VpDbContext.Clients.ToListAsync();
        }

        public async Task<Client> UpdateClientAsync(Client client)
        {
            if (VpDbContext.Clients.Local.All(c => c.ClientId != client.ClientId))
            {
                VpDbContext.Clients.Attach(client);
            }
            VpDbContext.Entry(client).State = EntityState.Modified;
            await VpDbContext.SaveChangesAsync();
            return client;

        }

        public async Task<Client> AddClientAsync(Client client)
        {
            VpDbContext.Clients.Add(client);
            await VpDbContext.SaveChangesAsync();
            return client;
        }

        public async Task DeleteClientAsync(Guid clientId)
        {
            var client = VpDbContext.Clients.FirstOrDefault(c => c.ClientId == clientId);
            if (client != null)
            {
                VpDbContext.Clients.Remove(client);
            }
            await VpDbContext.SaveChangesAsync();
        }
    }
}