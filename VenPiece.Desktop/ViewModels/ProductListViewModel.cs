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
    public class ProductListViewModel : BindableBase
    {
        public ProductListViewModel()
        {
            LoadProducts();
        }


        private static readonly VenPieceDbContext dbContext = new VenPieceDbContext();
        private IProductRepository _repository = new ProductRepository(dbContext);
        private ObservableCollection<Product> _products;

        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set { SetProperty(ref _products, value); }
        }


        public async void LoadProducts()
        {
            Products = new ObservableCollection<Product>(await _repository.GetProductsAsync());
        }
    }
}
