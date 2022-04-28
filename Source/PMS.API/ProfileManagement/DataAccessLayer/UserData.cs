namespace ProfileManagement
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

        public UserData(UserContext context)
        {
            _context = context;
        }
        public IEnumerable<User> getAll()
        {
            return _context.users;
        }
        public User getUser(int id)
        {
            return _context.users.FirstOrDefault(x => x.Id == id);
        }
        public void Add(User item)
        {
            _context.users.Add(item);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            User user = getUser(id);
            _context.users.Remove(user);
            _context.SaveChanges();
        }
        public void Update(User item)
        {
            _context.users.Update(item);
            _context.SaveChanges();
        }
        public bool save()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}