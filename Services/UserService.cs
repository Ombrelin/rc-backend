using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RencontreContemporainesAPI.Models;
using RencontreContemporainesAPI.Repositories;
using RencontreContemporainesAPI.Services.Interfaces;

namespace RencontreContemporainesAPI.Services
{
    public class UserService : IUserService
    {

        public User Authenticate(string username, string password)
        {
            var user = new User()
            {
                Username = Environment.GetEnvironmentVariable("ADMIN_LOGIN"),
                Password = Environment.GetEnvironmentVariable("ADMIN_PASSWORD")
            };
            
            if (username !=  user.Username|| password != user.Password)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Environment.GetEnvironmentVariable("JWT_SECRET"));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Username)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials =
                    new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };
            
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            return user;
        }
    }
}