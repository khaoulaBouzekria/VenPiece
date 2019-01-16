using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using VenPiece.Data.Models;

namespace VenPiece.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        VenPieceDbContext VpDbContext = new VenPieceDbContext();

        public Task<Employee> GetEmployeeByIdAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Employee>> GetEmployeesAsync()
        {
            return VpDbContext.Employees.ToListAsync();
        }
    }
}