using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private ClientListViewModel _clientListViewModel = new ClientListViewModel();
        private OrderListViewModel _orderListViewModel = new OrderListViewModel();
        private InvoiceListViewModel _invoiceListViewModel = new InvoiceListViewModel();
        private DeliveryListViewModel _deliveryListViewModel = new DeliveryListViewModel();
        private ProductListViewModel _productListViewModel = new ProductListViewModel();
        private EmployeeListViewModel _employeeListViewModel = new EmployeeListViewModel();
        private AddEditClientViewModel _addEditClientViewModel = new AddEditClientViewModel();

        private BindableBase _currentViewModel;

        public MainViewModel()
        {
            NavCommand = new RelayCommand<string>(OnNav);
            _clientListViewModel.AddClientRequested += NavToAddClient;
            _clientListViewModel.EditClientRequested += NavToEditClient;
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
