using PROFILE.Models;
using Microsoft.EntityFrameworkCore;
namespace PROFILE.DataAccessLayer
{
    public class CollegeDataAccessLayer:ICollegeDataAccessLayer
    {
       private CollegeContext _db = DataFactory.DbContextDataFactory.GetDbContextObject();  
       private ILogger<CollegeDataAccessLayer> _logger;
        public bool AddCollege(College college)
        {
            if (college == null)
                throw new ArgumentNullException("College shouldn't be null");
            try
            {
                _db.Colleges.Add(college);
                _db.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)                //DB Update Exception Occured
            {
                
                return false;
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
            }
            catch (OperationCanceledException ex)      //Operation cancelled exception
            {
                return false;
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
            }
            catch (Exception ex)                       //unknown exception occured
            {
                
                return false;
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
            }
        }
         public bool RemoveCollege(int collegeId)
        {
            if (collegeId == 0)                        
                throw new ArgumentNullException("College Id is not given");

            try
            {
                var college = _db.Colleges.Find(collegeId);
                college.IsActive = false;
                _db.Colleges.Update(college);
                _db.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)              //DB Update Exception Occured
            {
                
                return false;
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
            }
            catch (OperationCanceledException ex)     //Operation cancelled exception
            {
               
                return false;
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
            }
            catch (Exception ex)                     //unknown exception occured
            {
                
                return false;
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
            }

        }
         public List<College> GetColleges()
        {
            try
            {
                return _db.Colleges.ToList();
            }
            catch (DbUpdateException ex)              //DB Update Exception Occured
            {
                
                throw new DbUpdateException();
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
            }
            catch (OperationCanceledException ex)    //Operation cancelled exception
            {
                
                throw new OperationCanceledException();
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
            }
            catch (Exception ex)                      //unknown exception occured
            {
                
                throw new Exception();
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
            }
        }


        
    }
}