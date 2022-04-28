using ProfileManagement;

namespace ProfileManagement
{
    public interface IUserServices
    {
        void Add(User item);
        void Delete(int id);
        IEnumerable<User> GetAll();
        User GetUser(int id);
        bool Save();
        void Update(User item);
    }
}