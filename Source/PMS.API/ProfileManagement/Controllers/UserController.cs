using Microsoft.AspNetCore.Mvc;
using System;
namespace ProfileManagement
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController:Controller{
        
        private IUserServices _userServices;
        private ILogger _logger;
        public UserController(IUserServices userServices,ILogger<UserController> logger)
        {
            _userServices=userServices;
            _logger=logger;
           
        }
        [HttpGet(Name ="GetUsers")]
        public IEnumerable<User> Getallusers(){
            
           _logger.LogInformation("Getting all users");
            return _userServices.GetAll();
        }
        [HttpGet(Name="GetUserById")]
        public User Getuser(int id){
            
            User user=_userServices.GetUser(id);
            return user;
        }
        [HttpPost]
        public IActionResult AddUser(User user){
            _userServices.Add(user);
            return Ok();
           
        }
         [HttpPut]
         
         public IActionResult UpdateUser(User user,int id){
            if(id==user.Id){
             _userServices.Update(user);
             return Ok();
            }
            return BadRequest();
            
             
         } 
         [HttpDelete]
         public IActionResult Delete(int id){
             var ExistingUser =_userServices.GetUser(id);
             _userServices.Delete(id);
             return Ok();
         }

    }
}