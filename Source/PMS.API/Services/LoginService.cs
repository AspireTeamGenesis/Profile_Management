using PMS_API;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace PMS_API
{
    public class LoginService 
    {
        private UserData _userData;
        private ILogger<LoginService> _logger;
        private IConfiguration _configuration;

        public LoginService(ILogger<LoginService> logger, IConfiguration configuration, UserData userData)
        {
            _logger = logger;
            _configuration = configuration;
            _userData = userData;
        }

        public object AuthLogin(string UserName, string Password)
        {
            try
            {
                var user =_userData.LoginCrendentials(UserName,Password);

                var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserName",user.UserName),
                        new Claim("UserId", user.UserId.ToString()),
                        //new Claim(ClaimTypes.Role,user.RoleId.ToString()),
                    };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                        claims,
                    expires: DateTime.UtcNow.AddHours(6),
                    signingCredentials: signIn);

                var Result = new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    ExpiryInMinutes = 360,
                    //IsAdmin = user.RoleId == 10 ? true : false,
                    //IsTAC = user.RoleId == 9 ? true : false
                };

                return Result;

            }
            catch (ValidationException loginCredentialsNotValid)
            {
                _logger.LogInformation($"User DAL : LoginCredentails throwed an exception : {loginCredentialsNotValid.Message}");
                throw loginCredentialsNotValid;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"User DAL : LoginCredentails throwed an exception : {exception.Message}");
                throw exception;
            }
        }

    }
}