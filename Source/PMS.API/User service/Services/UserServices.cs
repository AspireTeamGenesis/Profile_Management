using System;
namespace PMS.API{
   

    public class UserServices : IUserServices
    {
        private UserData userData;

        private ILogger<UserServices> _logger;
      
        public UserServices(ILogger<UserServices> logger){
            _logger=logger;
            userData=DataFactory.GetUserObject(logger);
        }
        private UserValidation _validation=DataFactory.GetValidationObject();
        public IEnumerable<User> GetallUsers()
        {
            try{
                // IEnumerable<User> userDetails = new List<User>();
             
                return from  user in userData.GetallUsers() where user.IsActive==true select user;
                
            
            
            }
            catch(Exception exception){
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"UserServices:GetAll()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
       
        public User GetUser(int id)
        {
            if(id<=0)
                throw new ArgumentNullException($"ID is not provided{id}");
            try
            {
                return userData.GetUser(id); 
            }
            catch(Exception exception){
                _logger.LogError($"UserServices:GetUser()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public bool AddUser(User item)

        {
            if(item==null)
                throw new ArgumentNullException($"UserServices:Add()-user value not be null{item}");
             _validation.userValidate(item);
            try
            {
               
                item.CreatedBy="HR";
                item.CreatedOn=DateTime.Now;
                return userData.AddUser(item)?true:false;              //Ternary operator
                
            }
            
            catch(Exception exception){
                _logger.LogInformation($"UserServices:Add()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
            
            
             
        }
        public bool Disable(int id)
        {
            if(id<=0)
                throw new ArgumentNullException($"ID is not provided{id}");

            
            try
            {

                return userData.Disable(id)?true:false;
                
            }
            
            catch(Exception exception){
                _logger.LogInformation($"UserServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
            
            
            
 
        }
        public bool UpdateUser(User item)
        {
            
            if(item==null)throw new ArgumentNullException($" UserServices:Update()-user values not be null{item}");
            _validation.userValidate(item);
            try{
                
               item.UpdatedBy=item.Name;
                item.UpdatedOn=DateTime.Now;
                return userData.UpdateUser(item)?true:false;
                
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