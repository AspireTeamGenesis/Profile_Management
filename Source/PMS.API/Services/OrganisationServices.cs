namespace PMS_API
{
    public class OrganisationServices : IOrganisationServices
    {
        private readonly IOrganisationDataAccessLayer _OrganisationDataAccessLayer = OrganisationDataFactory.GetOrganisationDataAccessLayerObject();
        private readonly Organisation _Organisation = OrganisationDataFactory.GetOrganisationObject();
        private readonly ILogger<OrganisationServices>?_logger;
        public OrganisationServices(){
            
        }
         public OrganisationServices( ILogger<OrganisationServices> logger)
       {
        _logger=logger;
       }
       
        

       
        public IEnumerable<Organisation> ViewOrganisations()
        {
            try
            {
                IEnumerable<Organisation> organization = new List<Organisation>();
                return organization = from organisation in _OrganisationDataAccessLayer.GetOrganisations() where organisation.IsActive select organisation;
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
                 throw new Exception();
                
            }
        }

    }
}