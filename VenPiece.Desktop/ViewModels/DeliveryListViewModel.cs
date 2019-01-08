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
    public class DeliveryListViewModel : BindableBase
    {
        public DeliveryListViewModel()
        {
            LoadDeliveries();
        }

        private static readonly VenPieceDbContext dbContext = new VenPieceDbContext();
        private IDeliveryRepository _repository = new DeliveryRepository(dbContext);
        private ObservableCollection<Delivery> _deliveries;

        public ObservableCollection<Delivery> Deliveries
        {
            get { return _deliveries; }
            set { SetProperty(ref _deliveries, value); }
        }
        

        public async void LoadDeliveries()
        {
            Deliveries = new ObservableCollection<Delivery>(await _repository.GetDeliveriesAsync());
        }
    }
}
