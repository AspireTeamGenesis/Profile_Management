namespace PMS.API
{
    public interface IPersonalService
    {
        bool AddEducation(Education education);
        bool AddPersonalDetail(PersonalDetails personalDetails);
        bool AddProjects(Projects project);
        bool AddSkills(Skills skill);
        bool AddBreakDuration(BreakDuration duration);
        bool AddLanguage(Language language);
        bool AddSocialMedia(SocialMedia media);
    }

    public class PersonalService : IPersonalService
    {

        ProfileData profileData;
        private ILogger<PersonalService> _logger;

        public PersonalService(ILogger<PersonalService> logger)
        {
            _logger = logger;
            profileData = DataFactory.GetProfileData(logger);

        }
        public bool AddPersonalDetail(PersonalDetails personalDetails)
        {
            if (personalDetails == null) throw new ArgumentNullException($"Values cannot be null values are {personalDetails}");
            try
            {
                personalDetails.CreatedBy = personalDetails.Name;
                personalDetails.CreatedOn = DateTime.Now;
                return profileData.AddPersonalDetail(personalDetails) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddPersonalDetail()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }
        public bool AddEducation(Education education)
        {
            if (education == null) throw new ArgumentNullException($"Values cannot be null values are {education}");
            try
            {

                education.CreatedOn = DateTime.Now;
                return profileData.AddEducation(education) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddEducation()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }
        public bool AddProjects(Projects project)
        {
            if (project == null) throw new ArgumentNullException($"Values cannot be null values are {project}");
            try
            {

                project.CreatedOn = DateTime.Now;
                return profileData.AddProjects(project) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddProjects()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }
        public bool AddSkills(Skills skill)
        {
            if (skill == null) throw new ArgumentNullException($"Values cannot be null values are {skill}");
            try
            {

                skill.CreatedOn = DateTime.Now;
                return profileData.AddSkills(skill) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddSkills()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }
        public bool AddBreakDuration(BreakDuration duration)
        {
            if (duration == null) throw new ArgumentNullException($"Values cannot be null values are {duration}");
            try
            {

                duration.CreatedOn = DateTime.Now;
                return profileData.AddBreakDuration(duration) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddSkills()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }
        public bool AddLanguage(Language language)
        {
            if (language == null) throw new ArgumentNullException($"Values cannot be null values are {language}");
            try
            {

                language.CreatedOn = DateTime.Now;
                return profileData.AddLanguage(language) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddSkills()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }
        public bool AddSocialMedia(SocialMedia media)
        {
            if (media == null) throw new ArgumentNullException($"Values cannot be null values are {media}");
            try
            {

                media.CreatedOn = DateTime.Now;
                return profileData.AddSocialMedia(media) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddSkills()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }

    }
}