using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.ComponentModel.DataAnnotations;
namespace PMS_API
{
   [ApiController]
    [Route("[controller]/[Action]")]
    public class LoginController :Controller{
        
        private LoginService _loginServices;
         private ILogger<LoginController> _logger;
        public LoginController(LoginService loginServices, ILogger<LoginController> logger)
        {

            _loginServices = loginServices;
            _logger = logger;
        }
        [HttpPost("Login")]
        public IActionResult AuthLogin(string UserName, string Password)
        {
            try
            {
                var Result = _loginServices.AuthLogin(UserName, Password);                
                return Ok(Result);
            }
            catch (ValidationException validationException)
            {
                _logger.LogInformation($"Login Service : AuthLogin() : {validationException.Message}");
                return BadRequest(validationException.Message);
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"Login Service : AuthLogin() : {exception.Message}");
                return Problem("Sorry some internal error occured");
            }
        }
     
}
}
