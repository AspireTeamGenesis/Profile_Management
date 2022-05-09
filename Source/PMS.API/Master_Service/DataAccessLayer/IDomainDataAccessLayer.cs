using PROFILE.Models;
namespace PROFILE.DataAccessLayer
{
    public interface IDomainDataAccessLayer
    
    {
        public List<Domain> GetDomains();
    }
}