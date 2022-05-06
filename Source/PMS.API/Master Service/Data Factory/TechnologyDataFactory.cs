using PROFILE.DataAccessLayer;
using PROFILE.Models;
using PROFILE.Services;
namespace PROFILE.DataFactory{
    public static class TechnologyDataFactory
    {
        public static ITechnologyDataAccessLayer GetTechnologyDataAccessLayerObject()
        {
            return new TechnologyDataAccessLayer();
        }
      
         public static Technology GetTechnologyObject()
        {
            return new Technology();
        }
       public static ITechnologyServices GetTechnologyServiceObject()
        {
        return new TechnologyServices();
        }
    }
}