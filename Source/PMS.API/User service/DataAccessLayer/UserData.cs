using Serilog;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PMS.API
{
    public interface IUserData
    {
        bool Add(User item);
        bool Delete(int id);
        List<User> getAll();
        //User getUser(int id);
        bool save();
        bool Update(User item);
    }

    public class UserData : IUserData
    {
        private UserContext _context;
        private ILogger<UserServices> _logger;
        public UserData(UserContext context, ILogger<UserServices> logger)
        {
            _context = context;
            _logger=logger;
        }
        //getting all users 
        public List<User> getAll()
        {
            
            try{

                return _context.users.ToList();
                
            }
            
            catch(Exception exception){
                //log "if exception occures"
                _logger.LogError($"UserData.cs-getAll()-{exception.Message}");
                _logger.LogInformation($"UserData.cs-getALL()-{exception.StackTrace}");
                throw exception;
            }
        }
        
        //adding user to Database
        public bool Add(User item)
        {
            
            
            if (item == null)
                throw new ArgumentNullException("user object is not provided to DAL");
            
            try{
            
            _context.users.Add(item);
            _context.SaveChanges();
            return true;
            }
            
            catch(Exception exception){
                //log "unknown exception occured"
                 _logger.LogError($"UserData.cs-Add()-{exception.Message}");
                 _logger.LogInformation($"UserDate.cs-Add()-{exception.StackTrace}");
                 return false;
            }
            
            
        }
        //Enabling user to active state to false on id
        public bool Delete(int id)
        {
            if(id<=0)
               
                throw new ValidationException("User Id is not provided to DAL");
            
            try{
                var user = _context.users.Find(id);
                
            //do null validation for user

                user.IsActive=false;
                _context.users.Update(user);
                _context.SaveChanges();
                return true;
            
            }
           
          
            catch(Exception exception){
                //log "if exception occures"
                _logger.LogError($"UserData.cs-Delete()-{exception.Message}");
                _logger.LogInformation($"UserDate.cs-Delete()-{exception.StackTrace}");
                 return false;
            }
            
            
            
            
        }
        //Updating user details based on id
        public bool Update(User item)
        {
             if(item ==null)
                 throw new ValidationException("User values is not provided");

            
            try{
            
            _context.users.Update(item);
            _context.SaveChanges();
            return true;
            } 
            catch(Exception exception){
                //log " exception occures"
                _logger.LogError($"UserData.cs-Update()-{exception.Message}");
                _logger.LogInformation($"UserDate.cs-Update()-{exception.StackTrace}");
                 return false;
            }
            
            
            
        }
        public bool save()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}