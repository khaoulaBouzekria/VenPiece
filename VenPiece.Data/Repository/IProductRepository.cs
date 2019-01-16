using System.Collections.Generic;
using System.Threading.Tasks;
using VenPiece.Data.Models;

namespace VenPiece.Data.Repository
{
    public interface IProductRepository 
    {
        Task<Product> GetProductByIdAsync(string id);
        Task<List<Product>> GetProductsAsync();
    }
}