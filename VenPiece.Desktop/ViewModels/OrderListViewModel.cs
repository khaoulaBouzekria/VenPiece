using System.Collections.ObjectModel;
using VenPiece.Data;
using VenPiece.Data.Models;
using VenPiece.Data.Repository;

namespace VenPiece.Desktop.ViewModels
{
    public class OrderListViewModel : BindableBase
    {
        public OrderListViewModel(IOrderRepository orderRepository)
        {
            _repository = orderRepository;
            LoadOrders();
        }


        private IOrderRepository _repository;
        private ObservableCollection<Order> _orders;

        public ObservableCollection<Order> Orders
        {
            get { return _orders; }
            set { SetProperty(ref _orders, value); }
        }


        public async void LoadOrders()
        {
            Orders = new ObservableCollection<Order>(await _repository.GetOrdersAsync());
        }
    }
}
