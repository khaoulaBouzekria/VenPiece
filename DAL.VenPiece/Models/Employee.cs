using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VenPiece.Models
{
    
    public class Employee : Person
    {
        public Guid EmployeeId { get; set; }
        public Departments Department { get; set; }
        public DateTime RecruitmentDate { get; set; }
        public DateTime EndOfEmployementDate { get; set; }

    }
}
