using PROFILE.Models;
namespace PROFILE.DataAccessLayer
{
    public interface ITechnologyDataAccessLayer
    
    {
        public List<Technology> GetTechnologies();
    }
}