using System;

namespace VenPiece.Data.Models
{
    /// <summary>
    /// A class that represents a person model
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Person first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Person last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Person date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Person sexe
        /// </summary>
        public Gender Gender { get; set; }

    }
}
