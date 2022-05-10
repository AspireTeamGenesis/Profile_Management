using PROFILE.DataAccessLayer;
using PROFILE.Models;
using PROFILE.Services;
namespace PROFILE.DataFactory{
    public static class ProfileStatusDataFactory
    {
        public static IProfileStatusDataAccessLayer GetProfileStatusDataAccessLayerObject()
        {
            return new ProfileStatusDataAccessLayer();
        }
      
         public static ProfileStatus GetProfileStatusObject()
        {
            return new ProfileStatus();
        }
       public static IProfileStatusServices GetProfileStatusServiceObject()
        {
        return new ProfileStatusServices();
        }
    }
}