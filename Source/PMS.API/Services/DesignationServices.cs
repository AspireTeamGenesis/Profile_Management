using PMS_API.DataAccessLayer;
using System.Linq;
namespace PMS_API
{
    public class DesignationServices : IDesignationServices
    {
        private readonly IDesignationDataAccessLayer _designationDataAccessLayer = DesignationDataFactory.GetDesignationDataAccessLayerObject();
        private readonly Designation _designation = DesignationDataFactory.GetDesignationObject();
        private readonly ILogger<DesignationServices>?_logger;
        public DesignationServices(){
            
        }
         public DesignationServices( ILogger<DesignationServices> logger)
       {
        _logger=logger;
       }
       
        

       
        public IEnumerable<Designation> ViewDesignations()
        {
            try
            {
                IEnumerable<Designation>designations = new List<Designation>();
                return designations = from designation in _designationDataAccessLayer.GetDesignations() where designation.IsActive select designation;
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
                 throw new Exception();
                
            }
        }

    }
}