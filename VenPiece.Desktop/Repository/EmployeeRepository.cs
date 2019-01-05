using System.Data.Entity;
using VenPiece.Desktop.Models;

namespace VenPiece.Desktop.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context) : base(context)
        {
        }

        public Employee GetEmployeeById(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}