namespace PMS.API
{
    public class DataFactory{
        public static UserContext Getusercontext(){
            return new UserContext();
        }
        public static UserData GetUserObject(ILogger<UserServices> logger){
            return new UserData(Getusercontext(),logger);
        }
        public static User GetUserModelObject(){
            return new User();
        }
        public static UserValidation GetValidationObject(){
            return new UserValidation();
        }
        
    }
}