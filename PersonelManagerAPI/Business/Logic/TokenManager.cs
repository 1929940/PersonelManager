using API.Business.Helpers;
using API.Business.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API.Business.Logic {

    public static class TokenManager {
        //public static string GenerateJwtToken(User user, AppSettings settings) {
        public static string GenerateJwtToken(User user, AppSecrets secrets) {

            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(secrets.AuthSecret);

            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(new Claim[]{
                    new Claim(ClaimTypes.Role, user.Role),
                    new Claim(ClaimTypes.Name, string.Format("{0} {1}", user.FirstName, user.LastName)),
                }),
                Expires = DateTime.UtcNow.AddHours(12),
                Issuer = secrets.Issuer,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
