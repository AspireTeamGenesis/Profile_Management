using PROFILE.Models;
using PROFILE.DataAccessLayer;
using PROFILE.DataFactory;
using System.Linq;
namespace PROFILE.Services
{
    public class TechnologyServices : ITechnologyServices
    {
        private ITechnologyDataAccessLayer _TechnologyDataAccessLayer = DataFactory.TechnologyDataFactory.GetTechnologyDataAccessLayerObject();
        private Technology _Technology = DataFactory.TechnologyDataFactory.GetTechnologyObject();
        private ILogger<TechnologyServices>?_logger;
       
        

       
        public IEnumerable<Technology> ViewTechnologies()
        {
            try
            {
                IEnumerable<Technology>technologys = new List<Technology>();
                return technologys = from technology in _TechnologyDataAccessLayer.GetTechnologies() where technology.IsActive == true select technology;
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
                 throw new Exception();
                
            }
        }

    }
}