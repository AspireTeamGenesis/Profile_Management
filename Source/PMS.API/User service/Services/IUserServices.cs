using PMS.API;

namespace PMS.API
{
    public interface IUserServices
    {
        bool AddUser(User item);
        bool Disable(int id);
        IEnumerable<User> GetallUsers();
        bool GetUser(int id);
        bool Save();
        bool UpdateUser(User item);
    }
}