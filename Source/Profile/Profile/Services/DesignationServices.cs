using PROFILE.Models;
using PROFILE.DataAccessLayer;
using PROFILE.DataFactory;
using System.Linq;
namespace PROFILE.Services
{
    public class DesignationServices : IDesignationServices
    {
        private IDesignationDataAccessLayer _designationDataAccessLayer = DataFactory.DesignationDataFactory.GetDesignationDataAccessLayerObject();
        private Designation _designation = DataFactory.DesignationDataFactory.GetDesignationObject();
        private ILogger<DesignationServices>?_logger;
       
        

       
        public IEnumerable<Designation> ViewDesignations()
        {
            try
            {
                IEnumerable<Designation>designations = new List<Designation>();
                return designations = from designation in _designationDataAccessLayer.GetDesignations() where designation.IsActive == true select designation;
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
                throw new Exception();
                
            }
        }

    }
}