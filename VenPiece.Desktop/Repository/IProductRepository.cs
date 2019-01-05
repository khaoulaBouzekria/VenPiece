using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetProductById(string id);
    }
}