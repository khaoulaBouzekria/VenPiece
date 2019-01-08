using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public VenPieceDbContext VpDbContext => Context as VenPieceDbContext;
        public ProductRepository(DbContext context) : base(context)
        {
        }

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