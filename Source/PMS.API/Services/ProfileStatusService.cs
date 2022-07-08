namespace PMS_API
{
    public class ProfileStatusServices : IProfileStatusServices
    {
        private readonly IProfileStatusDataAccessLayer _ProfileStatusDataAccessLayer = ProfileStatusDataFactory.GetProfileStatusDataAccessLayerObject();
        private readonly ProfileStatus _ProfileStatus = ProfileStatusDataFactory.GetProfileStatusObject();
        private readonly ILogger<ProfileStatusServices>?_logger;
        public ProfileStatusServices(){
            
        }
         public ProfileStatusServices( ILogger<ProfileStatusServices> logger)
       {
        _logger=logger;
       }
       
        

       
        public IEnumerable<ProfileStatus> ViewProfileStatuss()
        {
            try
            {
                IEnumerable<ProfileStatus> profileStatuss = new List<ProfileStatus>();
                return profileStatuss = from profileStatus in _ProfileStatusDataAccessLayer.GetProfileStatuss() where profileStatus.IsActive select profileStatus;
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
                 throw new Exception();
                
            }
        }

    }
}