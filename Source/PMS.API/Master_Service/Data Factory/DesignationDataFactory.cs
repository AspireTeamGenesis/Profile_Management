using PROFILE.DataAccessLayer;
using PROFILE.Models;
using PROFILE.Services;
namespace PROFILE.DataFactory{
    public static class DesignationDataFactory
    {
        public static IDesignationDataAccessLayer GetDesignationDataAccessLayerObject()
        {
            return new DesignationDataAccessLayer();
        }
      
         public static Designation GetDesignationObject()
        {
            return new Designation();
        }
       public static IDesignationServices GetDesignationServiceObject()
        {
        return new DesignationServices();
        }
    }
}