using PMS_API.DataAccessLayer;

using System.Linq;
namespace PMS_API
{
    public class DomainServices : IDomainServices
    {
        private readonly IDomainDataAccessLayer _domainDataAccessLayer = DomainDataFactory.GetDomainDataAccessLayerObject();
        private readonly Domain _domain = DomainDataFactory.GetDomainObject();
        private readonly ILogger<DomainServices>?_logger;
        public DomainServices(){

        }
        public DomainServices( ILogger<DomainServices> logger)
       {
        _logger=logger;
       }
       
        

       
        public IEnumerable<Domain> ViewDomains()
        {
            try
            {
                IEnumerable<Domain> domains = new List<Domain>();
                return domains = from domain in _domainDataAccessLayer.GetDomains() where domain.IsActive select domain;
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
                 throw new Exception();
                
            }
        }

    }
}