using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenPiece.Desktop.ViewModels
{
    public class MainViewModel : IViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ClientListViewModel _clientListViewModel = new ClientListViewModel();
        private OrderListViewModel _orderListViewModel = new OrderListViewModel();
        private InvoiceListViewModel _invoiceListViewModel = new InvoiceListViewModel();
        private DeliveryListViewModel _deliveryListViewModel = new DeliveryListViewModel();
        private ProductListViewModel _productListViewModel = new ProductListViewModel();
        private EmployeeListViewModel _employeeListViewModel = new EmployeeListViewModel();

        public object CurrentViewModel { get; set; }
    }
}
