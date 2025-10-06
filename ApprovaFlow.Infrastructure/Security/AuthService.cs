using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ApprovaFlow.Infrastructure.Security
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _config;

        public AuthService (IConfiguration config)
        {
            _config = config;
        }
        public string ComputeHash(string password)
        {
           using (var hash = SHA256.Create())
            {
                var passwordBytes = Encoding.UTF8.GetBytes(password);
                var hashBytes = hash.ComputeHash(passwordBytes);
                var builder = new StringBuilder();


                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public string GenerateToken(string email, string role)
        {
            var issuer = _config["Jwt: Issuer"];
            var audience = _config["Jwt: Audience"];
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt: Key"]));

            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var clains = new List<Claim>
            {
                new Claim("username", email),
                new Claim(ClaimTypes.Role, role)
            };

            var token = new JwtSecurityToken(issuer, audience, clains, null, DateTime.Now.AddHours(2), credential);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
