using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace WebApp
{
    public class AuthOptions
    {
        public const string ISSUER = "Server";
        public const string AUDIENCE = "Client";
        public const string KEY = "A5C5B2A1-05BF-4B11-8EFE-B8C12152B661";
        public const int LIFETIME = 1;

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}

