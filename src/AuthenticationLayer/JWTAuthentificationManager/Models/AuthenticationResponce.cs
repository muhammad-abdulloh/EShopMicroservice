using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTAuthentificationManager.Models
{
    public class AuthenticationResponce
    {
        public string UserName { get; set; }
        public string JwtToken { get; set; }
        public int ExpiresIn { get; set; }
    }
}
