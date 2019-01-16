using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using VenPiece.Data;
using VenPiece.Data.Models;
using VenPiece.Data.Repository;

namespace VenPiece.Desktop.ViewModels
{
    /// <summary>
    /// Client List View Model
    /// </summary>
    public class ClientListViewModel  : BindableBase
    {
        /// <summary>
        /// DataBase Context
        /// </summary>
        /// <summary>
        /// Client Repository initiation
        /// </summary>
        private IClientRepository _repository;

        private List<Client> _allClients;
        /// <summary>
        /// Clients Observable Collection
        /// </summary>
        private ObservableCollection<Client> _clients;

        public ObservableCollection<Client> Clients
        {
            get => _clients;
            set => SetProperty(ref _clients, value);
        }
        /// <summary>
        /// Add Client Command
        /// </summary>
        public RelayCommand AddClientCommand { get; }
        public RelayCommand<Client> EditClientCommand { get; }
        public RelayCommand<Client> DeleteClientCommand { get; }
        public event Action<Client> AddClientRequested = delegate { };
        public event Action<Client> EditClientRequested = delegate { };

        public event Action<Client> DeleteClientRequested = delegate { };

        /// <summary>
        /// Constructor
        /// </summary>
        public ClientListViewModel(IClientRepository clientRepository)
        {
            _repository = clientRepository;
            LoadClients();
            AddClientCommand = new RelayCommand(OnAddClient);
            EditClientCommand = new RelayCommand<Client>(OnEditClient);
            DeleteClientCommand = new RelayCommand<Client>(OnDeleteClient);
        }

        private void OnDeleteClient(Client client)
        {
            DeleteClientRequested(client);
        }

        private void OnEditClient(Client client)
        {
            EditClientRequested(client);
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
