using System.Collections.Generic;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetProductByIdAsync(string id);
        Task<List<Product>> GetProductsAsync();
    }
}