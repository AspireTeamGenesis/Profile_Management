namespace PMS_API
{
    public static class ProfileDataFactory
    {
        public static Context GetProfileContext()
        {
            return new Context();
        }
        public static ProfileData GetProfileData(ILogger<ProfileService> logger)
        {
            return new ProfileData(GetProfileContext(),logger);
        }
    }
}