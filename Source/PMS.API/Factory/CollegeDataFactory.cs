using PMS_API.DataAccessLayer;

namespace PMS_API{
    public class CollegeDataFactory
    {
        public static ICollegeDataAccessLayer GetCollegeDataAccessLayerObject()
        {
            return new CollegeDataAccessLayer();
        }
      
         public static College GetCollegeObject()
        {
            return new College();
        }
       public static CollegeServices GetCollegeServiceObject()
        {
        return new CollegeServices();
        }
        
    }
}