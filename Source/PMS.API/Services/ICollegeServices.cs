namespace PMS_API{
    public interface ICollegeServices
    {
        
        // public bool RemoveCollege(int collegeId);
        public IEnumerable<College> ViewColleges();

    }
}