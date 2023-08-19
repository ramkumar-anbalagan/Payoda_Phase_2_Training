using JWT_Auth.Services.Interface;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT_Auth.Services
{
    public class TokenService : IToken
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateToken(string username, string role)
        {
            var jwtSettings = _configuration.GetSection("jwtSetting");
            var secretkey = Encoding.ASCII.GetBytes("this is the jwt token...");

            var issuer = jwtSettings["Issuer"];
            //var epires= DateTime.UtcNow.Addminutes(5);

            //security package -  it will authorize us
            var claims = new[]
      {
        new Claim(ClaimTypes.NameIdentifier, username),//nameidentifier - act as primary keyno duplicate
                new Claim(ClaimTypes.Role,role)

      };

            //token descriptor
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Issuer = issuer,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretkey), SecurityAlgorithms.HmacSha512)

            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
