using PMS.API;

namespace PMS.API
{
    public interface IUserServices
    {
        bool AddUser(User item);
        bool Disable(int id);
        IEnumerable<User> GetallUsers();
        User GetUser(int id);
        bool Save();
        bool UpdateUser(User item);
    }
}