using System;
using System.ComponentModel.DataAnnotations;
namespace PMS.API{
   

    public class UserServices : IUserServices
    {
        private UserData userData;

        private ILogger<UserServices> _logger;
      
        public UserServices(ILogger<UserServices> logger){
            _logger=logger;
            userData=DataFactory.GetUserObject(logger);
        }
        
        public IEnumerable<User> GetallUsers()
        {
            try{
               
             
                return  from  user in userData.getAll() where user.IsActive==true select user;
                
            
            
            }
            catch(Exception exception){
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"UserServices:GetAll()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
       
        public bool AddUser(User item)

        {
            if(item==null)
                throw new ArgumentNullException("UserServices:Add()-user value not be null");
            try
            {
                item.CreatedBy="HR";
                item.CreatedOn=DateTime.Now;
                return userData.Add(item)?true:false ;           //Ternary operator
               
            }
            
            catch(Exception exception){
                _logger.LogInformation($"UserServices:Add()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
             
        }
        public bool Disable(int id)
        {
            if(id<=0)
                throw new ValidationException($"ID is not provided{id}");

            
            try
            {

                return userData.Delete(id)?true:false;
                    return true;
               
                
            }
            
            catch(Exception exception){
                _logger.LogInformation($"UserServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
            
            
            
 
        }
        public bool UpdateUser(User item)
        {
            if(item==null){throw new ArgumentNullException(" UserServices:Update()-user values not be null");}
            try{
               item.UpdatedBy=item.Name;
                item.UpdatedOn=DateTime.Now;
                if(userData.Update(item)){
                    return true;                        //Ternary operator
                }
                else{
                    return false;
                }
            }
            
            catch(Exception exception){
                 _logger.LogInformation($"UserServices:Update()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
            
 

        }
        public bool Save()
        {
            return userData.save();
        }
    }
}