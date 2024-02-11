using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTracker
{
    public static class PasswordHasher
    {
        public static string hashPassword(string password)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            return passwordHash;
        }

        public static bool verifyPassword(string plainText, string HashedPassword)
        {
            bool isValid = BCrypt.Net.BCrypt.Verify(plainText, HashedPassword);

            return isValid;
        }
    }
}
