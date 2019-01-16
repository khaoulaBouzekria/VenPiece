using VenPiece.Data.Models;
using Microsoft.Practices.Unity;
using Unity;
using VenPiece.Desktop.Helpers;

namespace VenPiece.Desktop.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private ClientListViewModel _clientListViewModel = ContainerHelper.Container.Resolve<ClientListViewModel>();
        private OrderListViewModel _orderListViewModel = ContainerHelper.Container.Resolve<OrderListViewModel>();
        private InvoiceListViewModel _invoiceListViewModel = ContainerHelper.Container.Resolve<InvoiceListViewModel>();
        private DeliveryListViewModel _deliveryListViewModel = ContainerHelper.Container.Resolve<DeliveryListViewModel>();
        private ProductListViewModel _productListViewModel = ContainerHelper.Container.Resolve<ProductListViewModel>();
        private EmployeeListViewModel _employeeListViewModel = ContainerHelper.Container.Resolve<EmployeeListViewModel>();
        private AddEditClientViewModel _addEditClientViewModel = ContainerHelper.Container.Resolve<AddEditClientViewModel>();
         
        private BindableBase _currentViewModel;

        public MainViewModel()
        {
            NavCommand = new RelayCommand<string>(OnNav);
            _clientListViewModel.AddClientRequested += NavToAddClient;
            _clientListViewModel.EditClientRequested += NavToEditClient;
            _clientListViewModel.DeleteClientRequested += NavToDeleteClient;
            _addEditClientViewModel.Done += NavToClientList;
        }

        private void NavToEditClient(Client client)
        {
            _addEditClientViewModel.EditMode = true;
            _addEditClientViewModel.SetClient(client);
            CurrentViewModel = _addEditClientViewModel;
        }

        private void NavToAddClient(Client client)
        {
            _addEditClientViewModel.EditMode = false;
            _addEditClientViewModel.SetClient(client);
            CurrentViewModel = _addEditClientViewModel;
        }
        private void NavToDeleteClient(Client client)
        {
            _addEditClientViewModel.EditMode = false;
            _addEditClientViewModel.SetClient(client);
            CurrentViewModel = _addEditClientViewModel;
        }

        private void NavToClientList()
        {
            CurrentViewModel = _clientListViewModel;
        }
        public BindableBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        public RelayCommand<string> NavCommand { get; }

        /// <summary>
        /// This method implements the logic behind calling one of the navigation buttons
        /// </summary>
        /// <param name="destination"></param>
        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "clients":
                    CurrentViewModel = _clientListViewModel;
                    break;
                case "products":
                    CurrentViewModel = _productListViewModel;
                    break;
                case "orders":
                    CurrentViewModel = _orderListViewModel;
                    break;
                case "invoices":
                    CurrentViewModel = _invoiceListViewModel;
                    break;
                case "deliveries":
                    CurrentViewModel = _deliveryListViewModel;
                    break;
                case "employees":
                    CurrentViewModel = _employeeListViewModel;
                    break;
                default:
                    CurrentViewModel = _productListViewModel;
                    break;
            }
        }
    }
}
