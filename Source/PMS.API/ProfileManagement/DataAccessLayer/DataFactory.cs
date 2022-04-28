namespace ProfileManagement
{
    public class DataFactory{
        public static UserContext Getusercontext(){
            return new UserContext();
        }
        public static UserData GetUserObject(){
            return new UserData(Getusercontext());
        }
        
    }
}