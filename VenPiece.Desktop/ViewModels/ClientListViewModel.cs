using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;
using VenPiece.Desktop.Repository;

namespace VenPiece.Desktop.ViewModels
{
    public class ClientListViewModel  : BindableBase
    {
        private static readonly VenPieceDbContext dbContext = new VenPieceDbContext();
        private IClientRepository _repository = new ClientRepository(dbContext);
        private ObservableCollection<Client> _clients;

        public ObservableCollection<Client> Clients
        {
            get { return _clients; }
            set { SetProperty(ref _clients, value);}
        }
        public RelayCommand AddClientCommand { get; private set; }
        public RelayCommand<Client> EditClientCommand { get; private set; }
        public event Action<Client> AddClientRequested = delegate { };
        public event Action<Client> EditClientRequested = delegate { };
        /// <summary>
        /// Constructor
        /// </summary>
        public ClientListViewModel()
        {
            LoadClients();
            AddClientCommand = new RelayCommand(OnAddClient);
            EditClientCommand = new RelayCommand<Client>(OnEditClient);
        }

        private void OnEditClient(Client client)
        {
            throw new NotImplementedException();
        }

        private void OnAddClient()
        {
            AddClientRequested(new Client{ClientId = Guid.NewGuid(), });
        }

        public async void LoadClients()
        {
            Clients = new ObservableCollection<Client>(await  _repository.GetClientsAsync());
        }
    }
}
