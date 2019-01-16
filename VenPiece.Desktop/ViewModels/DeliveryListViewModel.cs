using System.Collections.ObjectModel;
using VenPiece.Data;
using VenPiece.Data.Models;
using VenPiece.Data.Repository;

namespace VenPiece.Desktop.ViewModels
{
    public class DeliveryListViewModel : BindableBase
    {
        public DeliveryListViewModel(IDeliveryRepository deliveryRepository)
        {
            _repository = deliveryRepository;
            LoadDeliveries();
        }

        private IDeliveryRepository _repository;
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
