using System;

namespace VenPiece.Data.Models
{
    /// <summary>
    /// A class that represents the Employee model
    /// </summary>
    public class Employee : Person
    {
        /// <summary>
        /// Employee identifier
        /// </summary>
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// Employee departement
        /// </summary>
        public Departments Department { get; set; }
        /// <summary>
        /// Employee recruitement date
        /// </summary>
        public DateTime RecruitmentDate { get; set; }
        /// <summary>
        /// Employee end of employement date
        /// </summary>
        public DateTime EndOfEmployementDate { get; set; }

    }
}
