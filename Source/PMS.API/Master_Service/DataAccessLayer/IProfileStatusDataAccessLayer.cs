using PROFILE.Models;
namespace PROFILE.DataAccessLayer
{
    public interface IProfileStatusDataAccessLayer
    
    {
        public List<ProfileStatus> GetProfileStatuss();
    }
}