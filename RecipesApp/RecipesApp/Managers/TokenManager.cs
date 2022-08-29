using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RecipesApp.Entities;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System;

namespace RecipesApp.Managers
{
    public class TokenManager : ITokenManager
    {
        private readonly IConfiguration configuration;
        private readonly UserManager<User> userManager;

        public TokenManager(IConfiguration configuration, UserManager<User> userManager)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }

        public async Task<string> CreateToken(User user)
        {
            var secretKey = configuration.GetSection("Jwt").GetSection("SecretKey").Get<string>();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            //algorithms for cryptography that use the same cryptographic keys for both the encryption of plaintext
            //and the decryption of ciphertext
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);


            //creez lista de claims si adaug pt fiecare rol, un claim ce contine rolul respectiv
            var claims = new List<Claim>();
            var roles = await userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddHours(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);  //facem token-ul string si il returnam

        }
    }
}
