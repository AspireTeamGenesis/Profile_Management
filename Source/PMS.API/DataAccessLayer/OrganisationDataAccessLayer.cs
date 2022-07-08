using Microsoft.EntityFrameworkCore;
namespace PMS_API
{
    public class OrganisationDataAccessLayer:IOrganisationDataAccessLayer
    {
       private readonly Context _db = DbContextDataFactory.GetDbContextObject();  
       private readonly ILogger<OrganisationDataAccessLayer> _logger;
       public OrganisationDataAccessLayer(){
        
       }
        public OrganisationDataAccessLayer( ILogger<OrganisationDataAccessLayer> logger)
       {
        _logger=logger;
       }
        
         public List<Organisation> GetOrganisations() // List of Organisations
        {
            try
            {
                return _db.Organisations.ToList();
            }
            catch (DbUpdateException ex)              //DB Update Exception Occured
            {
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
                throw new DbUpdateException();
              
            }
            catch (OperationCanceledException ex)    //Operation cancelled exception
            {
                  _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
                throw new OperationCanceledException();
              
            }
            catch (Exception ex)                      //unknown exception occured
            {
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
                throw ex;
                
            }
        }


        
    }
}