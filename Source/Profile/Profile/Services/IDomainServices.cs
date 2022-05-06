using PROFILE.Models;

namespace PROFILE.Services{
    public interface IDomainServices
    {
        // public  bool CreateCollege(string collegeName);
        // public bool RemoveCollege(int collegeId);
        public IEnumerable<Domain> ViewDomains();

    }
}