using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;
using VenPiece.Desktop.Repository;

namespace VenPiece.Desktop.ViewModels
{
    public class OrderListViewModel : BindableBase
    {
        public OrderListViewModel()
        {
            LoadOrders();
        }
        

        private static readonly VenPieceDbContext dbContext = new VenPieceDbContext();
        private IOrderRepository _repository = new OrderRepository(dbContext);
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
