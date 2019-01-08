using System.Collections.Generic;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<Employee> GetEmployeeByIdAsync(string id);
        Task<List<Employee>> GetEmployeesAsync();
    }
}