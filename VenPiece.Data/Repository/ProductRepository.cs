using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using VenPiece.Data.Models;

namespace VenPiece.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        VenPieceDbContext VpDbContext = new VenPieceDbContext();
        public Task<Product> GetProductByIdAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Product>> GetProductsAsync()
        {
            return VpDbContext.Products.ToListAsync();
        }
    }
}