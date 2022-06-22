using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace PMS_API
{
    public interface IUserData
    {
        bool AddUser(User item);
        bool Disable(int id);
        List<User> GetallUsers();
        User GetUser(int id);
        bool save();
        bool UpdateUser(User item);
        User LoginCrendentials(string UserName,string Password);
    }

    public class UserData : IUserData
    {
        private Context _context;
        private ILogger<UserServices> _logger;
        public UserData(Context context, ILogger<UserServices> logger)
        {
            _context = context;
            _logger=logger;
        }
         private UserValidation _validation=UserDataFactory.GetValidationObject();
        //getting all users 
        public List<User> GetallUsers()
        {
            
            try{

                return _context.users.Include("gender").Include("designation").Include("organisation").Include("countrycode").ToList();
                
            }
            
            catch(Exception exception){
                //log "if exception occures"
                _logger.LogError($"UserData.cs-GetallUsers()-{exception.Message}");
                _logger.LogInformation($"UserData.cs-GetallUsersL()-{exception.StackTrace}");
                throw exception;
            }
        }
        public User GetUser(int id)
        {
             if(id<=0)
               
                throw new ValidationException("User Id is not provided to DAL");
            
            try{
                User user= GetallUsers().Where(x=>x.UserId==id).First();
                if(user==null)throw new NullReferenceException($"Id not found-{id}");
                return user;
            }
            catch(Exception exception){
                _logger.LogError($"UserData.cs-GetUser()-{exception.Message}");
                _logger.LogInformation($"UserData.cs-GetUser()-{exception.StackTrace}");
                throw exception;
            }
        }
        
        //adding user to Database
        public bool AddUser(User item)
        {
            if (item == null)
                throw new ArgumentNullException("user object is not provided to DAL");
            _validation.userValidate(item);
            if(string.IsNullOrEmpty(item.UserName))
                throw new ValidationException($"UserName not be null and user supplied UserName is {item.UserName}");
            try{
            item.IsActive=true;
            _context.users.Add(item);
            _context.SaveChanges();
            return true;
            }
            
            catch(Exception exception){
                //log "unknown exception occured"
                 _logger.LogError($"UserData.cs-AddUser()-{exception.Message}");
                 _logger.LogInformation($"UserData.cs-AddUser()-{exception.StackTrace}");
                 return false;
            }
            
            
            
        }
        //Enabling user to active state to false on id
        public bool Disable(int id)
        {
            if(id<=0)
               
                throw new ValidationException("User Id is not provided to DAL");
            
            try{
                var user = _context.users.Find(id);
                
            //do null validation for user
            if(user==null)throw new NullReferenceException($"User Id not found{id}");
                user.IsActive=false;
                _context.users.Update(user);
                _context.SaveChanges();
                return true;
            
            }
           
          
            catch(Exception exception){
                //log "if exception occures"
                _logger.LogError($"UserData.cs-Disable()-{exception.Message}");
                _logger.LogInformation($"UserData.cs-Disable()-{exception.StackTrace}");
                 return false;
            }
            
            
            
            
        }
        //Updating user details based on id
        public bool UpdateUser(User item)
        {
            
             if(item ==null)
                 throw new ValidationException("User values is not provided to DAL");
            _validation.userValidate(item);
            
            try{
                var user = _context.users.Find(item.UserId);
                if(user==null)throw new NullReferenceException($"User Id not found{item.UserId}");
                user.UserId=item.UserId;
                user.Name=item.Name;
                user.Email=item.Email;
                user.UserName=item.UserName;
                user.Password=item.Password;
                user.GenderId=item.GenderId;
                user.CountryCodeId=user.CountryCodeId;
                user.MobileNumber=item.MobileNumber;
                user.OrganisationId=item.OrganisationId;
                user.DesignationId=item.DesignationId;
                user.ReportingPersonUsername=item.ReportingPersonUsername;
                user.IsActive=item.IsActive;
                user.CreatedBy=item.CreatedBy;
            _context.users.Update(user);
            _context.SaveChanges();
            return true;
            }
            catch(Exception exception){
                //log " exception occures"
                _logger.LogError($"UserData.cs-UpdateUser)-{exception.Message}");
                _logger.LogInformation($"UserData.cs-UpdateUser()-{exception.StackTrace}");
                 return false;
            }
            
            
            
        }
        public bool save()
        {
            return _context.SaveChanges() >= 0;
        }
          public User LoginCrendentials(string UserName, string Password)
        {
            try
            {
                if(!_context.users.Any(x => x.UserName == UserName))
                    throw new ValidationException($"No User Found : {UserName}");

                if(!_context.users.Any(x => x.UserName== UserName && x.Password == Password))
                    throw new ValidationException($"Wrong Password!");

                var user = GetallUsers().Where(user => user.UserName == UserName).First();
                return user;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"Exception on User DAL : LoginCrendentials(string UserName, string password) : {exception.Message}");
                throw exception;
            }
        }
    }
}