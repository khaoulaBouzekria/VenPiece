using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using VenPiece.Desktop.Models;
using VenPiece.Desktop.Repository;

namespace VenPiece.Desktop.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly VenPieceDbContext dbContext = new VenPieceDbContext();
        public IUserRepository Users { get; private set; }


        public AuthenticationService()
        {
            Users = new UserRepository(dbContext);
        }

        public User AuthenticateUser(string username, string clearTextPassword)
        {
            var userData = Users.GetUserByUsername(username);
            if (!userData.HashedPassword.Equals(CalculateHash(clearTextPassword, username)))
            {
                throw new UnauthorizedAccessException("Access denied. Please provide some valid credentials.");
            }
            return new User(userData.Username, userData.Email, userData.Roles);
        }

        private static string CalculateHash(string clearTextPassword, string salt)
        {
            // Convert the salted password to a byte array
            var saltedHashBytes = Encoding.UTF8.GetBytes(clearTextPassword + salt);
            // Use the hash algorithm to calculate the hash
            HashAlgorithm algorithm = new SHA256Managed();
            var hash = algorithm.ComputeHash(saltedHashBytes);
            // Return the hash as a base64 encoded string to be compared to the stored password
            return Convert.ToBase64String(hash);
        }
    }
}
