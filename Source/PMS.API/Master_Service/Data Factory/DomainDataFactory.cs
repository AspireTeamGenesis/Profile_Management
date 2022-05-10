using PROFILE.DataAccessLayer;
using PROFILE.Models;
using PROFILE.Services;
namespace PROFILE.DataFactory{
    public static class DomainDataFactory
    {
        public static IDomainDataAccessLayer GetDomainDataAccessLayerObject()
        {
            return new DomainDataAccessLayer();
        }
      
         public static Domain GetDomainObject()
        {
            return new Domain();
        }
       public static IDomainServices GetDomainServiceObject()
        {
        return new DomainServices();
        }
    }
}