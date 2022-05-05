using PROFILE.Models;
using PROFILE.DataAccessLayer;
using PROFILE.DataFactory;
using System.Linq;
namespace PROFILE.Services
{
    public class CollegeServices : ICollegeServices
    {
        private ICollegeDataAccessLayer _collegeDataAccessLayer = DataFactory.CollegeDataFactory.GetCollegeDataAccessLayerObject();
        private College _college = DataFactory.CollegeDataFactory.GetCollegeObject();
        private ILogger<CollegeServices> _logger;
       
        public bool CreateCollege(string collegeName)
        {
            if (collegeName == null)
                throw new ArgumentNullException("College Name is not provided");

            try
            {
                //checking 
                _college.CollegeName = collegeName;
                return _collegeDataAccessLayer.AddCollege(_college) ? true : false;
            }
            catch (Exception ex)
            {
              
                return false;
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
            }
        }

       

        public bool RemoveCollege(int collegeId)
        {
            if (collegeId == null)
                throw new ArgumentNullException("College Id is not provided");

            try
            {
                return _collegeDataAccessLayer.RemoveCollege(collegeId) ? true :false; 
            }
            catch (Exception ex)
            {
                
                return false;
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
            }
        }

       
        public IEnumerable<College> ViewColleges()
        {
            try
            {
                IEnumerable<College> colleges = new List<College>();
                return colleges = from college in _collegeDataAccessLayer.GetColleges() where college.IsActive == true select college;
            }
            catch (Exception ex)
            {
                
                throw new Exception();
                _logger.LogInformation($"{ex.Message}\n {ex.StackTrace}");
            }
        }

    }
}