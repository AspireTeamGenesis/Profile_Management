using PMS.API;

namespace PMS.API
{
    public interface IUserServices
    {
        bool Add(User item);
        bool Delete(int id);
        IEnumerable<User> GetAll();
        //User GetUser(int id);
        bool Save();
        bool Update(User item);
    }
}