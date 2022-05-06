using System;
namespace PMS.API{
   

    public class UserServices : IUserServices
    {
        private UserData userData = DataFactory.GetUserObject();

        private ILogger<UserServices> _logger;
      
        
        
        public IEnumerable<User> GetAll()
        {
            try{
                IEnumerable<User> userDetails = new List<User>();
                return userDetails = from  user in userData.getAll() where user.IsActive==true select user;
                
            
            
            }
            catch(Exception exception){
                // Log Exception occured in DAL while fetching users
                _logger.LogInformation($"UserServices:GetAll()-{exception.Message}\n{exception.StackTrace}");
                throw new Exception();
            }
        }
        public bool Add(User item)

        {
            if(item==null)
                throw new ArgumentNullException("UserServices:Add()-user value not be null");
            try
            {
                item.CreatedBy="HR";
                item.CreatedOn=DateTime.Now;
                if(userData.Add(item))
                    return true;
                else{
                    return false;
                }
            }
            catch(ArgumentNullException exception){
                //item object not provided to DAL
                _logger.LogInformation($"UserServices:Add()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
            catch(Exception exception){
                _logger.LogInformation($"UserServices:Add()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
             
        }
        public bool Delete(int id)
        {
            if(id<=0)
                throw new ArgumentNullException($"ID is not provided{id}");

            
            try
            {

                if(userData.Delete(id)){
                    return true;
                }
                else{
                    //log error in DAL
                     _logger.LogError($"unable to disable the data{id}");
                    return false;
                }
            }
            catch(ArgumentNullException exception){
                //Log error is not provided to DAL
                _logger.LogInformation($"UserServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false; 
            }
            catch(Exception exception){
                _logger.LogInformation($"UserServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
            
            
            
 
        }
        public bool Update(User item)
        {
            if(item==null){throw new ArgumentNullException(" UserServices:Update()-user values not be null");}
            try{
               item.UpdatedBy=item.Name;
                item.UpdatedOn=DateTime.Now;
                if(userData.Update(item)){
                    return true;
                }
                else{
                    return false;
                }
            }
            catch(ArgumentNullException exception){
                //item object not provided to DAL
                 _logger.LogInformation($"UserServices:Update()-{exception.Message}\n{exception.StackTrace}");
                return false;
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