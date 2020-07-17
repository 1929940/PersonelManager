using API.Business.Models;
using API.Core.DBContext;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace API.Business.Logic {
    public class JWTHandler {
        public AuthenticateResponse Authenticate(AuthenticateRequest model) {
            using(var context = new Context(null)) {

                Credential credential = context.Credential.FirstOrDefault(x => x.Email == model.Login);

        //var user = _users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);

            // return null if user not found
            if (credential == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(credential);

            return new AuthenticateResponse(token);
            }
    }

    private string generateJwtToken(Credential credential) {

        var tokenHandler = new JwtSecurityTokenHandler();

        //var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
        var key = Encoding.ASCII.GetBytes("WTF");
        var tokenDescriptor = new SecurityTokenDescriptor {
            Subject = new ClaimsIdentity(new Claim[]{
                    new Claim("Role", credential.Role.ToString()),
                    new Claim("FullName", string.Format("{0} {1}", credential.FirstName, credential.LastName)),
                }),
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}
}
