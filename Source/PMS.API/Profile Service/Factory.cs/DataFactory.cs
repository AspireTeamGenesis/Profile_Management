namespace PMS.API
{
    public class DataFactory
    {
        public static ProfileContext GetProfileContext()
        {
            return new ProfileContext();
        }
        public static ProfileData GetProfileData(ILogger<PersonalService> logger)
        {
            return new ProfileData(GetProfileContext(),logger);
        }
    }
}