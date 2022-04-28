using System;
namespace ProfileManagement{
   

    public class UserServices : IUserServices
    {
        private UserData userData = DataFactory.GetUserObject();
        
        
        public IEnumerable<User> GetAll()
        {

            return userData.getAll();
        }
        public User GetUser(int id)
        {
            return userData.getUser(id);
        }
        public void Add(User item)
        {
             userData.Add(item);
        }
        public void Delete(int id)
        {
            userData.Delete(id);
 
        }
        public void Update(User item)
        {
            userData.Update(item);
 

        }
        public bool Save()
        {
            return userData.save();
        }
    }
}