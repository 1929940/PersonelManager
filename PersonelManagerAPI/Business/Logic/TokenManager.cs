﻿using API.Business.Helpers;
using API.Business.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API.Business.Logic {

    public static class TokenManager {
        public static string GenerateJwtToken(Credential credential, AppSettings settings) {

            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(settings.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(new Claim[]{
                    new Claim(ClaimTypes.Role, credential.Role),
                    new Claim(ClaimTypes.Name, string.Format("{0} {1}", credential.FirstName, credential.LastName)),
                }),
                Expires = DateTime.UtcNow.AddHours(12),
                Issuer = settings.Issuer,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
