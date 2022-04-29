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
        public IEnumerable<User> Getallusers(){


            _logger.LogInformation("Getting all users");
            return _userServices.GetAll();
            
            
        }
        [HttpGet(Name="GetUserById")]
        public IActionResult Getuser([FromQuery]int id){
            if(id!=0){
                var user=_userServices.GetUser(id);
                if(user !=null){
                    return Ok(user);
                }
                return BadRequest("User not Found ");
            }
            
            
     
        return BadRequest("The id is zero");
            
        }
        [HttpPost]
        public IActionResult AddUser(User user){
            if(user ==null || !ModelState.IsValid ) return BadRequest();

            //Adding user via userservice
            _userServices.Add(user);
            return Ok("User Added");
           
        }
         [HttpPut]
         
         public IActionResult UpdateUser(User user,[FromQuery]int id){
             if(user ==null || id==0||!ModelState.IsValid ||!user.IsActive)return BadRequest();
            //updating user via userservices
            try{
                if(id==user.Id){
                    
                _userServices.Update(user);
                return Ok("User Updated");
                }
                return BadRequest("User Not Found");
            }
            catch(Exception ex){
                _logger.LogInformation("Error occured while updating");
                return BadRequest("User Not Found");
            }
             
         } 
         [HttpDelete(Name="Disable")]
         public IActionResult Disable(int id,User user){
             if(user ==null || id==0||!ModelState.IsValid||!user.IsActive)return BadRequest();
             try{
            if(id==user.Id){
                //updating isactive via userservices
             _userServices.Delete(id);
             return Ok("User Updated");
            }
            return BadRequest("User Not found");
             }
             catch(Exception ex){
                _logger.LogInformation("Error occured while updating");
                return BadRequest("User Not Found");
             }
       
        }

    }
}