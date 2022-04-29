using Serilog;
namespace PMS.API
{
    public interface IUserData
    {
        void Add(User item);
        void Delete(int id);
        IEnumerable<User> getAll();
        User getUser(int id);
        bool save();
        void Update(User item);
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
        public IEnumerable<User> getAll()
        {
            List<User> result = new List<User>();
            try{
                result=_context.users.ToList();
                return result;
            }
            catch(Exception ex){
                logger.LogWarning("Unable to get the all users!try again");
            }
           return result;
        }
        //getting user based on id
        public User getUser(int id)
        {


            var result= _context.users.FirstOrDefault(x=>x.Id==id);
            if(result != null){
                return result;
            }
            
            return result;
            
        }
        //adding user to Database
        public void Add(User item)
        {
            try{
            item.CreatedBy="Testing";
            item.CreatedOn=DateTime.Now;
            _context.users.Add(item);
            _context.SaveChanges();
            }
            catch(Exception ex){
                logger.LogError("Error occured while inserting data");
            }
        }
        //Enabling user to active state to false on id
        public void Delete(int id)
        {
            User user = getUser(id);
            try{
            if(user.IsActive){
                user.IsActive=false;
                _context.users.Update(user);
                _context.SaveChanges();
            }
            }
            catch(Exception ex){
                logger.LogInformation("Error while Disabling");
            }
            
        }
        //Updating user details based on id
        public void Update(User item)
        {
            try{
            item.UpdatedBy="Testing";
            item.UpdatedOn=DateTime.Now;
            _context.users.Update(item);
            _context.SaveChanges();
            }
            catch(Exception ex){
                logger.LogWarning("Error while updating");
            }
        }
        public bool save()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}