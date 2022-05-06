using PROFILE.Models;
using PROFILE.DataAccessLayer;
using PROFILE.DataFactory;
using System.Linq;
namespace PROFILE.Services
{
    public class DomainServices : IDomainServices
    {
        private IDomainDataAccessLayer _domainDataAccessLayer = DataFactory.DomainDataFactory.GetDomainDataAccessLayerObject();
        private Domain _domain = DataFactory.DomainDataFactory.GetDomainObject();
        private ILogger<DomainServices>?_logger;
       
        

       
        public IEnumerable<Domain> ViewDomains()
        {
            try
            {
                IEnumerable<Domain> domains = new List<Domain>();
                return domains = from domain in _domainDataAccessLayer.GetDomains() where domain.IsActive == true select domain;
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
                 throw new Exception();
                
            }
        }

    }
}