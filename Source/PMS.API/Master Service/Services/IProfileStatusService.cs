using PROFILE.Models;

namespace PROFILE.Services{
    public interface IProfileStatusServices
    {
        // public  bool CreateCollege(string collegeName);
        // public bool RemoveCollege(int collegeId);
        public IEnumerable<ProfileStatus> ViewProfileStatuss();

    }
}