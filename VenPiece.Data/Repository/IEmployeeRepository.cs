using System.Collections.Generic;
using System.Threading.Tasks;
using VenPiece.Data.Models;

namespace VenPiece.Data.Repository
{
    public interface IEmployeeRepository 
    {
        Task<Employee> GetEmployeeByIdAsync(string id);
        Task<List<Employee>> GetEmployeesAsync();
    }
}