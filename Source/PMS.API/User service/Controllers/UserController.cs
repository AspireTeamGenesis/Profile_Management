using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
namespace PMS.API
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
        //Calling all users 
        [HttpGet(Name ="GetUsers")]
        public IActionResult Getallusers(){
            try{
                return Ok(_userServices.GetAll());
            }
           catch(Exception exception){
               _logger.LogInformation($"UserController :GetAllUsers()-service throwed exception while fetching records{exception.Message}{exception.StackTrace}");
               return BadRequest(exception.Message);
           }
            
            
        }
        
        [HttpPost]
        public IActionResult AddUser(User user){
            if(user==null){
                _logger.LogInformation("UserController :AddUser()-user tries to enter null values");
                return BadRequest("User values not be null");
            }
            
            
                
            try{

                //Adding user via userservice
                return _userServices.Add(user)?Ok("User Added"):Problem("Sorry internal error occured");
                
                
            }
            catch(Exception exception){
                 _logger.LogInformation($"UserController :AddUser()-{exception.Message}{exception.StackTrace}");
                
                 return BadRequest(exception.Message);
            }
            
            
           
        }
         [HttpPut]
         
         public IActionResult UpdateUser(User user){
             if(user==null){
                _logger.LogInformation("UserController :AddUser()-user tries to enter null values");
                return BadRequest("User values not be null");
            }
            //updating user via userservices
             try{

                return _userServices.Update(user)? Ok("User Updated Successfully"):BadRequest("Sorry internal error occured");

            }
             catch(ArgumentNullException argumentNullException){
                 _logger.LogInformation($"UserController:UpdateUser()-{argumentNullException.Message}{argumentNullException.StackTrace}");
                 return BadRequest(argumentNullException.Message);
             }
             catch(Exception exception){
                 _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
                 return BadRequest(exception.StackTrace);
             }
           
            
            
             
         } 
         [HttpDelete(Name="Disable")]
         public IActionResult Disable(int id){
            try{
                
                return _userServices.Delete(id)?Ok("User Disabled Successfully"):BadRequest("Sorry internal error occured");
            }
             catch(ArgumentNullException argumentNullException){
                 _logger.LogInformation($"UserController:UpdateUser()-{argumentNullException.Message}{argumentNullException.StackTrace}");
                 return BadRequest(argumentNullException.Message);
             }
             catch(Exception exception){
                 _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
                 return BadRequest(exception.StackTrace);
             }
        }
       
        

    }
}