using System;
using System.ComponentModel;
using VenPiece.Data.Models;
using VenPiece.Data.Repository;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.ViewModels
{
    public class AddEditClientViewModel : BindableBase
    {
        private bool _editMode;
        private IClientRepository _repository;
        public bool EditMode
        {
            get => _editMode;
            set => SetProperty(ref _editMode,value);
        }

        private ClientDTO _client;

        public ClientDTO Client
        {
            get => _client;
            set => SetProperty(ref _client, value);
        }
        private Client _editingClient = null;
        public RelayCommand CancelCommand { get; private set; }
        public RelayCommand SaveCommand { get; private set; }
        public event Action Done = delegate { };
        public void SetClient(Client client)
        {
            _editingClient = client;
            if (Client != null) Client.ErrorsChanged -= RaiseCanExecuteChanged;
            Client = new ClientDTO();
            Client.ErrorsChanged += RaiseCanExecuteChanged;
            CopyClient(client, Client);
        }

        private void RaiseCanExecuteChanged(object sender, DataErrorsChangedEventArgs e)
        {
            SaveCommand.RaiseCanExecuteChanged();
        }

        private void CopyClient(Client source, ClientDTO target)
        {
            target.ClientId = source.ClientId;
            if (EditMode)
            {
                target.Name = source.Name;
                target.Address = source.Address;
                target.City = source.City;
                target.Country = source.Country;
                target.Email = source.Email;
                target.Phone = source.Phone;
                target.Type = source.Type;
                target.Street = source.Street;
                target.Zip = source.Zip;
            }
        }

        public AddEditClientViewModel(IClientRepository clientRepository)
        {
            _repository = clientRepository;
            CancelCommand = new RelayCommand(OnCancel);
            SaveCommand = new RelayCommand(OnSave,CanSave);
        }

        private bool CanSave()
        {
            return !Client.HasErrors;
        }

        private async void OnSave()
        {
            UpdateClient(Client, _editingClient);
            if (EditMode)
                await _repository.UpdateClientAsync(_editingClient);
            else
                await _repository.AddClientAsync(_editingClient);
            Done();
        }

        private void OnCancel()
        {
            Done();
        }
        private void UpdateClient(ClientDTO source, Client target)
        {
            target.Name = source.Name;
            target.Address = source.Address;
            target.City = source.City;
            target.Country = source.Country;
            target.Email = source.Email;
            target.Phone = source.Phone;
            target.Type = source.Type;
            target.Street = source.Street;
            target.Zip = source.Zip;
        }
    }
}
