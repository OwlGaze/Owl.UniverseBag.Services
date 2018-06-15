using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using IdentityModel;
using Microsoft.IdentityModel.Tokens;

namespace Owl.UniverseBag.Core.Security
{
    public class TokenHandler : ITokenHandler
    {
        public JWTModel Generate(Guid userId, string phoneNumber)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(TokenSecret.Value);
            var authTime = DateTime.UtcNow;
            var expiresAt = authTime.AddDays(7);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(JwtClaimTypes.Audience,"api"),
                    new Claim(JwtClaimTypes.Issuer,"http://owl.ub.com"),
                    new Claim(JwtClaimTypes.Id, userId.ToString()),
                    new Claim(JwtClaimTypes.PhoneNumber, phoneNumber)
                }),
                Expires = expiresAt,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return new JWTModel
            {
                Access_Token = tokenString,
                Profile = new Profile
                {
                    Id = userId,
                    PhoneNumber = phoneNumber,
                    Auth_Time = new DateTimeOffset(authTime).ToUnixTimeSeconds(),
                    Exprires_At = new DateTimeOffset(expiresAt).ToUnixTimeSeconds()
                }
            };
        }
    }
}
