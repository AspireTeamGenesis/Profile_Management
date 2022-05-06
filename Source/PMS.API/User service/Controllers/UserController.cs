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
        [HttpGet(Name ="GetallUsers")]
        public IActionResult Getallusers(){
            try{
                
                return Ok(_userServices.GetallUsers());
            }
           catch(Exception exception){
               _logger.LogInformation($"UserController :GetAllUsers()-exception occured while fetching records{exception.Message}{exception.StackTrace}");
               return BadRequest(exception.Message);
           }
            
            
        }
        [HttpGet]
        public IActionResult GetUserById(int id){
            if(id<=0){_logger.LogError($"UserController:GetUserById()-user id supplies as {id}");return BadRequest($"user id supplies as {id}");}
            try{
                return Ok(_userServices.GetUser(id));
            }
            catch(Exception exception){
                _logger.LogInformation($"UserController :GetUserById()-exception occured while fetching {id} record{exception.Message}{exception.StackTrace}");
               return BadRequest(exception.Message);
            }
        }
        
        [HttpPost]
        public IActionResult AddUser(User user){
            if(user==null){
                _logger.LogInformation("UserController :AddUser()-user tries to enter null values");
                return BadRequest("User values not be null");
            }
            
            if(ModelState.IsValid)
            {    
            try{

                //Adding user via userservice
                return _userServices.AddUser(user)?Ok("User Added"):Problem("Sorry internal error occured");
                
                
            }
            catch(Exception exception){
                 _logger.LogInformation($"UserController :AddUser()-{exception.Message}{exception.StackTrace}");
                
                 return BadRequest(exception.Message);
            }
            }
            else{
                return Problem("validation failed"); 
            }

            
           
        }
         [HttpPut]
         
         public IActionResult UpdateUser(User user){
             if(user==null){
                _logger.LogInformation("UserController :AddUser()-user tries to enter null values");
                return BadRequest("User values not be null");
            }
            //updating user via userservices
             if(ModelState.IsValid){
             try{

                return _userServices.UpdateUser(user)? Ok("User Updated Successfully"):BadRequest("Sorry internal error occured");

            }
             
             catch(Exception exception){
                 _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
                 return BadRequest(exception.StackTrace);
             }
            }
            else{
                return Problem("validation fails");
             }
           
            
            
             
         } 
         [HttpDelete(Name="Disable")]
         public IActionResult Disable(int id){
            try{
                
                return _userServices.Disable(id)?Ok("User Disabled Successfully"):BadRequest("Sorry internal error occured");
            }
             
             catch(Exception exception){
                 _logger.LogInformation($"UserController:UpdateUser()-{exception.Message}{exception.StackTrace}");
                 return BadRequest(exception.StackTrace);
             }
        }
       
        

    }
}