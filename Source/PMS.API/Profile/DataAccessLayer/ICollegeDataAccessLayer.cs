using PROFILE.Models;
namespace PROFILE.DataAccessLayer
{
    public interface ICollegeDataAccessLayer
    
    {
        public List<College> GetColleges();
    }
}