namespace PMS_API
{
    public class TechnologyServices : ITechnologyServices
    {
        private readonly ITechnologyDataAccessLayer _TechnologyDataAccessLayer = TechnologyDataFactory.GetTechnologyDataAccessLayerObject();
        private readonly Technology _Technology = TechnologyDataFactory.GetTechnologyObject();
        private readonly ILogger<TechnologyServices>?_logger;
        public TechnologyServices(){
            
        }
         public TechnologyServices( ILogger<TechnologyServices> logger)
       {
        _logger=logger;
       }
       
        

       
        public IEnumerable<Technology> ViewTechnologies()
        {
            try
            {
                IEnumerable<Technology> technologys = new List<Technology>();
                return technologys = from technology in _TechnologyDataAccessLayer.GetTechnologies() where technology.IsActive select technology;
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
                 throw new Exception();
                
            }
        }

    }
}