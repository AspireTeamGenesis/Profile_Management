using Serilog;
using Microsoft.EntityFrameworkCore;
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
        private ILogger<UserData> logger;
        public UserData(UserContext context)
        {
            _context = context;
        }
        //getting all users 
        public List<User> getAll()
        {
            
            try{
                return _context.users.ToList();
                
            }
            catch(DbUpdateException exception){
                //log "DB update exception occured"
                logger.LogInformation($"UserData.cs-getAll()-{exception.Message}{exception.StackTrace}");
                throw new DbUpdateException();
            }
            catch(OperationCanceledException exception){
                //log "Operation Cancelled Exception"
                logger.LogInformation($"UserData.cs-getAll()-{exception.Message}{exception.StackTrace}");
                throw new OperationCanceledException();
            }
            catch(Exception exception){
                //log "unknown exception occured"
                logger.LogInformation($"UserData.cs-getAll()-{exception.Message}{exception.StackTrace}");
                throw new Exception();
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
             catch(DbUpdateException exception){
                //log "DB update exception occured"
                 logger.LogInformation($"UserData.cs-Add()-{exception.Message}{exception.StackTrace}");
                 return false;
            }
            catch(OperationCanceledException exception){
                //log "Operation Cancelled Exception"
                 logger.LogInformation($"UserData.cs-Add()-{exception.Message}{exception.StackTrace}");
                 return false;
            }
            catch(Exception exception){
                //log "unknown exception occured"
                 logger.LogInformation($"UserData.cs-Add()-{exception.Message}{exception.StackTrace}");
                 return false;
            }
            
            
        }
        //Enabling user to active state to false on id
        public bool Delete(int id)
        {
            if(id<=0)
               
                throw new ArgumentNullException("User Id is not provided to DAL");
            
            try{
                var user = _context.users.Find(id);
                
            
                user.IsActive=false;
                _context.users.Update(user);
                _context.SaveChanges();
                return true;
            
            }
           catch(DbUpdateException exception){
                //log "DB update exception occured"
                logger.LogInformation($"UserData.cs-Delete()-{exception.Message}{exception.StackTrace}");
                 return false;
            }
            catch(OperationCanceledException exception){
                //log "Operation Cancelled Exception"
                logger.LogInformation($"UserData.cs-Delete()-{exception.Message}{exception.StackTrace}");
                 return false;
            }
          
            catch(Exception exception){
                //log "unknown exception occured"
                logger.LogInformation($"UserData.cs-Delete()-{exception.Message}{exception.StackTrace}");
                 return false;
            }
            
            
            
            
        }
        //Updating user details based on id
        public bool Update(User item)
        {
             if(item !=null)
                 throw new ArgumentNullException("User values is not provided");

            
            try{
            
            _context.users.Update(item);
            _context.SaveChanges();
            return true;
            }
             catch(DbUpdateException exception){
                //log "DB update exception occured"
                logger.LogInformation($"UserData.cs-Update()-{exception.Message}{exception.StackTrace}");
                 return false;
            }
            catch(OperationCanceledException exception){
                //log "Operation Cancelled Exception"
                logger.LogInformation($"UserData.cs-Update()-{exception.Message}{exception.StackTrace}");
                 return false;
            }
            catch(Exception exception){
                //log "unknown exception occured"
                logger.LogInformation($"UserData.cs-Update()-{exception.Message}{exception.StackTrace}");
                 return false;
            }
            
            
            
        }
        public bool save()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}