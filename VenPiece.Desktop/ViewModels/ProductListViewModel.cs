using System.Collections.ObjectModel;
using VenPiece.Data;
using VenPiece.Data.Models;
using VenPiece.Data.Repository;

namespace VenPiece.Desktop.ViewModels
{
    public class ProductListViewModel : BindableBase
    {
        public ProductListViewModel(IProductRepository productRepository)
        {
            _repository = productRepository;
            LoadProducts();
        }

        private readonly IProductRepository _repository;
        private ObservableCollection<Product> _products;

        public ObservableCollection<Product> Products
        {
            get => _products;
            set => SetProperty(ref _products, value);
        }


        public async void LoadProducts()
        {
            Products = new ObservableCollection<Product>(await _repository.GetProductsAsync());
        }
    }
}
