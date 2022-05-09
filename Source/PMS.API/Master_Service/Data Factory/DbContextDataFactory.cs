using PROFILE.DataAccessLayer;
namespace PROFILE.DataFactory{
    public static class DbContextDataFactory{
        public static MasterContext GetDbContextObject()
        {
            return new MasterContext();
        }
  
       
    

}
}
