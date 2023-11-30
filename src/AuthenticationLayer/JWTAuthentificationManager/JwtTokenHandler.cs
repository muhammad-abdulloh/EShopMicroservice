using JWTAuthentificationManager.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTAuthentificationManager
{
    public class JwtTokenHandler
    {
        public const string JWT_SECURITY_KEY = "nasiduh87h12h81d1b87h187h2e811873h1732h732h77h78h2378";
        public const int JWT_TOKEN_VALIDITY_MINS = 20;

        private readonly List<UserAccount> _userAccountList;

        public JwtTokenHandler()
        {
            _userAccountList = new List<UserAccount> 
            { 
                new UserAccount { UserName = "admin", Password = "admin123", Role = "Administrator" },
                new UserAccount { UserName = "user01", Password = "user01", Role = "User" },
            };
        }
    }
}
