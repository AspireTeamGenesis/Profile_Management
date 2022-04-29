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
            
            try{
                return _context.users;
            }
            catch(Exception ex){
                logger.LogWarning("Unable to get the all users!try again");
            }
           return null;
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
            item.CreatedBy="Testing";
            item.CreatedOn=DateTime.Now;
            _context.users.Add(item);
            _context.SaveChanges();
        }
        //Enabling user to active state to false based on id
        public void Delete(int id)
        {
            User user = getUser(id);
            if(user.IsActive){
                user.IsActive=false;
                _context.users.Update(user);
                _context.SaveChanges();
            }
            
        }
        //Updating user details based on id
        public void Update(User item)
        {
            item.UpdatedBy="Testing";
            item.UpdatedOn=DateTime.Now;
            _context.users.Update(item);
            _context.SaveChanges();
        }
        public bool save()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}