using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using RencontresContemporaines.Core.Domain;
using RencontresContemporaines.Core.Repositories;

namespace RencontresContemporaines.Core.Applications;

public class UserApplication
{
    
    private readonly IUserRepository userRepository;
    private readonly string jwtSecret;

    public UserApplication(IUserRepository userRepository, string jwtSecret)
    {
        this.userRepository = userRepository;
        this.jwtSecret = jwtSecret;
    }

    public async Task<string> Authenticate(string username, string password)
    {
        User user = await userRepository.GetByUsername(username);

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(jwtSecret);
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
            
        SecurityToken token = ;

        return tokenHandler.CreateToken(tokenDescriptor).ToString();
    }
}