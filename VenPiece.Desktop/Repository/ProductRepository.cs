using System.Data.Entity;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }

        public Product GetProductById(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}