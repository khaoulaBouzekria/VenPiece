using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public VenPieceDbContext VpDbContext => Context as VenPieceDbContext;
        public EmployeeRepository(DbContext context) : base(context)
        {
        }

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