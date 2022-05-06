using PROFILE.Models;

namespace PROFILE.Services{
    public interface IDesignationServices
    {
        // public  bool CreateCollege(string collegeName);
        // public bool RemoveCollege(int collegeId);
        public IEnumerable<Designation> ViewDesignations();

    }
}