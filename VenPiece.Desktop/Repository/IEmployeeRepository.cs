using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee GetEmployeeById(string id);
    }
}