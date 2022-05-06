using PROFILE.Models;
using Microsoft.EntityFrameworkCore;
namespace PROFILE.DataAccessLayer
{
    public class ProfileStatusDataAccessLayer:IProfileStatusDataAccessLayer
    {
       private MasterContext _db = DataFactory.DbContextDataFactory.GetDbContextObject();  
       private ILogger<ProfileStatusDataAccessLayer> _logger;
        
         public List<ProfileStatus> GetProfileStatuss() // List of ProfileStatuss
        {
            try
            {
                return _db.ProfileStatuss.ToList();
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