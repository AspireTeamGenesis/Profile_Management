using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;


namespace PMS_API
{
    public interface IProfileData
    {
        bool AddProfile(Profile profile);
        bool AddPersonalDetail(PersonalDetails personalDetails);
        List<PersonalDetails> GetAllPersonalDetails();
        PersonalDetails GetPersonalDetailsById(int Personalid);

        bool UpdatePersonalDetail(PersonalDetails personalDetails);
        bool DisablePersonalDetails(int PersonalDetailsid);

        bool AddEducation(Education education);
        List<Education> GetallEducationDetails();
        Education GetEducationDetailsById(int Educationid);
        bool UpdateEducation(Education education);
        bool DisableEducationalDetails(int Educationid);

        bool AddProjects(Projects project);
        List<Projects> GetallProjectDetails();
        Projects GetProjectDetailsById(int Projectid);
        bool UpdateProjects(Projects projects);
        bool DisableProjectDetails(int Projectid);

        bool AddSkills(Skills skill);
        List<Skills> GetallSkillDetails();
        Skills GetSkillDetailsById(int Skillid);
        bool UpdateSkills(Skills skill);
        bool DisableSkillDetails(int Skillid);

        bool AddAchievements(Achievements achievements);
        List<Achievements> GetallAchievements();

        bool DisableAchievement(int AchievementId);

        bool AddBreakDuration(BreakDuration duration);
        bool DisableBreakDuration(int BreakDurationid);

        bool AddLanguage(Language language);
        bool DisableLanguage(int Languageid);

        bool AddSocialMedia(SocialMedia media);
        bool DisableSocialMedia(int SocialMediaid);


        Technology GetTechnologyById(int Technologyid);
        List<Technology> GetallTechnologies();


        public List<Profile> GetallProfiles();
        Profile GetProfileById(int ProfileId);

        public bool AddProfileHistory(ProfileHistory profilehistory);

        public List<ProfileHistory> GetallProfileHistories();
        public ProfileStatus GetProfileStatusByProfileId(int Profileid);
        public List<User> GetFilterdProfile(string userName, int designationId, int domainID, int technologyId, int collegeId, int profileStatusId, int maxExperience, int minExperience,int currentdesignation);


    }

    public class ProfileData : IProfileData
    {
        private readonly Context _context;
        private readonly ILogger<ProfileService> _logger;

        public ProfileData(Context context, ILogger<ProfileService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public bool AddProfile(Profile profile)
        {
            profile.IsActive = true;


            if (profile == null)
                throw new ArgumentNullException("personalDetails object is not provided to DAL");

            try
            {
                profile.IsActive = true;
                _context.profile.Add(profile);
                _context.SaveChanges();
                return true;
            }

            catch (Exception exception)
            {
                //log "unknown exception occured"
                _logger.LogError($"ProfileData.cs-AddProfile()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-AddProfile()-{exception.StackTrace}");

                return false;
            }


        }

        public IEnumerable<BreakDuration> GetBreakDurationByPersonalDetailsId(int Personalid)
        {
            try
            {
                return _context.Set<BreakDuration>().Where(nameof => nameof.PersonalDetailsId == Personalid).ToList();
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileData.cs-DisableBreakDuration()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-DisableBreakDuration()-{exception.StackTrace}");
                throw exception;
            }

        }

        public List<PersonalDetails> GetAllPersonalDetails()
        {

            try
            {
                return _context.personalDetails.Include(s => s.language).Include(s => s.breakDuration).Include(s => s.socialmedia).ToList();


            }

            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-GetallPersonalDetails()-{exception.Message}");
                _logger.LogInformation($"UserData.cs-GetallPersonalDetails()-{exception.StackTrace}");
                throw exception;
            }
        }
        public PersonalDetails GetPersonalDetailsById(int Personalid)
        {

            if (Personalid <= 0)

                throw new ValidationException("Profile Id is not provided to DAL");

            try
            {
                var personalDetails = GetAllPersonalDetails().Where(x => x.PersonalDetailsId == Personalid).FirstOrDefault();
                if (personalDetails == null) throw new Exception($"Id not found-{Personalid}");
                return personalDetails;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileData.cs-GetPersonalDetailsById()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-GetPersonalDetailsById()-{exception.StackTrace}");
                throw exception;
            }
        }

        public bool AddPersonalDetail(PersonalDetails personalDetails)
        {


            if (personalDetails == null)
                throw new ArgumentNullException("personalDetails object is not provided to DAL");

            try
            {
                personalDetails.IsActive = true;
                _context.personalDetails.Add(personalDetails);
                _context.SaveChanges();
                return true;
            }

            catch (Exception exception)
            {
                //log "unknown exception occured"
                _logger.LogError($"ProfileData.cs-AddPersonalDetails()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-AddPersonalDetails()-{exception.StackTrace}");

                return false;
            }


        }
        public bool UpdatePersonalDetail(PersonalDetails personalDetails)
        {
            if (personalDetails == null)
                throw new ValidationException("profile's personal detail is not provided to DAL");

            try
            {
                _context.personalDetails.Update(personalDetails);
                _context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                //log " exception occures"
                _logger.LogError($"ProfileData.cs-UpdatePersonalDetail)-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-UpdatePersonalDetail()-{exception.StackTrace}");
                return false;
            }

        }

        public bool DisablePersonalDetails(int PersonalDetailsid)
        {
            if (PersonalDetailsid <= 0)
                throw new ValidationException("PersonalDetails Id is not provided to DAL");

            try
            {
                var personalDetails = _context.personalDetails.Find(PersonalDetailsid);

                //do null validation for personaldetails
                if (personalDetails == null) throw new NullReferenceException($"PersonalDetails Id not found{PersonalDetailsid}");
                personalDetails.IsActive = false;
                _context.personalDetails.Update(personalDetails);
                _context.SaveChanges();
                return true;

            }


            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-DisablePersonalDetails()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-DisablePersonalDetails()-{exception.StackTrace}");
                return false;
            }

        }
        public List<Education> GetallEducationDetails()
        {

            try
            {

                return _context.educations.Include("college").ToList();

            }

            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-GetallEducationDetails()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-GetallEducationDetails()-{exception.StackTrace}");
                throw exception;
            }
        }
        public Education GetEducationDetailsById(int Educationid)
        {
            if (Educationid <= 0)

                throw new ValidationException("Education Id is not provided to DAL");

            try
            {
                var education = GetallEducationDetails().Where(x => x.EducationId == Educationid && x.IsActive).First();
                if (education == null) throw new NullReferenceException($"Id not found-{Educationid}");
                return education;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileData.cs-GetEducationDetailsById()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-GetEducationDetailsById()-{exception.StackTrace}");
                throw exception;
            }
        }

        public bool AddEducation(Education education)
        {


            if (education == null)
                throw new ArgumentNullException("Education detail object is not provided to DAL");


            try
            {
                // var DOB = _context.personalDetails.Find(education.ProfileId).DateOfBirth;
                // if (education.Starting < DOB.Year)
                //     throw new ValidationException("StartingYear should be after DateOfBirth");

                education.IsActive = true;
                _context.educations.Add(education);
                _context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                //log "unknown exception occured"
                _logger.LogError($"ProfileData.cs-AddEducation()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-AddEducation()-{exception.StackTrace}");
                throw;
            }


        }
        public bool UpdateEducation(Education education)
        {
            if (education == null)
                throw new ValidationException("Profile's education details are not provided to DAL");
            try
            {
                _context.educations.Update(education);
                _context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                //log " exception occures"
                _logger.LogError($"ProfileData.cs-UpdateEducation)-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-UpdateEducaion()-{exception.StackTrace}");
                return false;
            }

        }


        public bool DisableEducationalDetails(int Educationid)
        {
            if (Educationid <= 0)

                throw new ValidationException("Education Id is not provided to DAL");

            try
            {
                var education = _context.educations.Find(Educationid);

                //do null validation for education
                if (education == null) throw new NullReferenceException($"Education Id not found{Educationid}");
                education.IsActive = false;
                _context.educations.Update(education);
                _context.SaveChanges();
                return true;

            }


            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-DisableEducationDetails()-{exception.Message}");
                _logger.LogInformation($"ProfileDate.cs-DisableEducationDetails()-{exception.StackTrace}");
                return false;
            }

        }
        public bool AddProjects(Projects project)
        {


            if (project == null)
                throw new ArgumentNullException("project detail object is not provided to DAL");

            try
            {
                // var DateOfJoin = _context.personalDetails.Find(project.ProfileId).DateOfJoining;
                // if (project.StartingYear < DateOfJoin.Year)
                //     throw new ValidationException($"Project starting Year should be after Date of joining");
                project.IsActive = true;
                _context.projects.Add(project);
                _context.SaveChanges();
                return true;
            }

            catch (Exception exception)
            {
                //log "unknown exception occured"
                _logger.LogError($"ProfileData.cs-AddProjects()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-AddProjects()-{exception.StackTrace}");

                return false;
            }


        }
        public List<Projects> GetallProjectDetails()
        {

            try
            {

                return _context.projects.ToList();

            }

            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-GetallProjectDetails()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-GetallProjectDetails()-{exception.StackTrace}");
                throw exception;
            }
        }
        public Projects GetProjectDetailsById(int Projectid)
        {
            if (Projectid <= 0)

                throw new ValidationException("Project Id is not provided to DAL");

            try
            {
                var project = GetallProjectDetails().Where(x => x.ProjectId == Projectid && x.IsActive).First();
                if (project == null) throw new NullReferenceException($"Id not found-{Projectid}");
                return project;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileData.cs-GetProjectDetailsById()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-GetProjectDetailsById()-{exception.StackTrace}");
                throw exception;
            }
        }
        public bool UpdateProjects(Projects projects)
        {
            if (projects == null)
                throw new ValidationException("Profile's Project details are not provided to DAL");


            try
            {
                projects.IsActive = true;
                _context.projects.Update(projects);
                _context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                //log " exception occures"
                _logger.LogError($"ProfileData.cs-UpdatePersonalDetail)-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-UpdatePersonalDetail()-{exception.StackTrace}");
                return false;
            }

        }
        public bool DisableProjectDetails(int Projectid)
        {
            if (Projectid <= 0)

                throw new ValidationException("Project Id is not provided to DAL");

            try
            {
                var projects = _context.projects.Find(Projectid);

                //do null validation for 
                if (projects == null)
                    throw new NullReferenceException($"Project Id not found{Projectid}");

                projects.IsActive = false;
                _context.projects.Update(projects);
                _context.SaveChanges();
                return true;

            }


            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-DisableProjectDetails()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-DisableProjectDetails()-{exception.StackTrace}");
                return false;
            }

        }
        public bool AddBreakDuration(BreakDuration duration)
        {


            if (duration == null)
                throw new ArgumentNullException("Break duration detail object is not provided to DAL");

            try
            {

                _context.breakDurations.Add(duration);
                _context.SaveChanges();
                return true;
            }

            catch (Exception exception)
            {
                //log "unknown exception occured"
                _logger.LogError($"ProfileData.cs-AddBreakDuration()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-AddSBreakDuration()-{exception.StackTrace}");

                return false;
            }


        }


        public bool DisableBreakDuration(int BreakDurationid)
        {
            if (BreakDurationid <= 0)

                throw new ValidationException("BreakDuration Id is not provided to DAL");

            try
            {
                var breakDurations = _context.breakDurations.Find(BreakDurationid);

                //do null validation for user
                if (breakDurations == null) throw new NullReferenceException($"Project Id not found{BreakDurationid}");
                breakDurations.IsActive = false;
                _context.breakDurations.Update(breakDurations);
                _context.SaveChanges();
                return true;

            }


            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-DisableBreakDuration()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-DisableBreakDuration()-{exception.StackTrace}");
                return false;
            }

        }
        public bool AddSkills(Skills skill)
        {


            if (skill == null)
                throw new ArgumentNullException("Skill detail object is not provided to DAL");

            try
            {
                skill.IsActive = true;
                _context.skills.Add(skill);
                _context.SaveChanges();
                return true;
            }

            catch (Exception exception)
            {
                //log "unknown exception occured"
                _logger.LogError($"ProfileData.cs-AddSkills()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-AddSkills()-{exception.StackTrace}");

                return false;
            }


        }
        public List<Skills> GetallSkillDetails()
        {

            try
            {

                return _context.skills.Include("domain").Include("technology").ToList();

            }

            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-GetallSkillDetails()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-GetallSkillDetails()-{exception.StackTrace}");
                throw exception;
            }
        }
        public Skills GetSkillDetailsById(int Skillid)
        {
            if (Skillid <= 0)

                throw new ValidationException("Skill Id is not provided to DAL");

            try
            {
                var skills = GetallSkillDetails().Where(x => x.SkillId == Skillid && x.IsActive).First();
                if (skills == null) throw new NullReferenceException($"Id not found-{Skillid}");
                return skills;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileData.cs-GetSkillDetailsById()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-GetSkillDetailsById()-{exception.StackTrace}");
                throw exception;
            }
        }
        public bool UpdateSkills(Skills skill)
        {
            if (skill == null)
                throw new ValidationException("Profile's skilldetails are not provided to DAL");
            try
            {
                skill.IsActive = true;
                _context.skills.Update(skill);
                _context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                //log " exception occures"
                _logger.LogError($"ProfileData.cs-UpdatePersonalDetail)-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-UpdatePersonalDetail()-{exception.StackTrace}");
                return false;
            }
        }
        public bool DisableSkillDetails(int Skillid)
        {
            if (Skillid <= 0)

                throw new ValidationException("Skill Id is not provided to DAL");

            try
            {
                var skills = _context.skills.Find(Skillid);

                //do null validation for user
                if (skills == null) throw new NullReferenceException($"Skill Id not found{Skillid}");
                skills.IsActive = false;
                _context.skills.Update(skills);
                _context.SaveChanges();
                return true;

            }


            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-DisableSkillDetails()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-DisableSkillDetails()-{exception.StackTrace}");
                return false;
            }

        }
        public bool AddLanguage(Language language)
        {


            if (language == null)
                throw new ArgumentNullException("Language details object is not provided to DAL");

            try
            {
                language.IsActive=true;
                _context.languages.Add(language);
                _context.SaveChanges();
                return true;
            }

            catch (Exception exception)
            {
                //log "unknown exception occured"
                _logger.LogError($"ProfileData.cs-AddLanguage()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-AddLanguage()-{exception.StackTrace}");

                return false;
            }


        }
        public bool DisableLanguage(int Languageid)
        {
            if (Languageid <= 0)

                throw new ValidationException("Language Id is not provided to DAL");

            try
            {
                var languages = _context.languages.Find(Languageid);

                //do null validation for user
                if (languages == null) throw new NullReferenceException($"Language Id not found{Languageid}");
                languages.IsActive = false;
                _context.languages.Update(languages);
                _context.SaveChanges();
                return true;

            }


            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-DisableLanguage()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-DisableLanguage()-{exception.StackTrace}");
                return false;
            }

        }
        public bool AddSocialMedia(SocialMedia media)
        {
            if (media == null)
                throw new ArgumentNullException("social media details object is not provided to DAL");
            try
            {
                media.IsActive=true;
                _context.SocialMedias.Add(media);
                _context.SaveChanges();
                return true;
            }

            catch (Exception exception)
            {
                //log "unknown exception occured"
                _logger.LogError($"ProfileData.cs-AddSocialMedia()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-AddSocialMedia()-{exception.StackTrace}");

                return false;
            }
        }
        public bool DisableSocialMedia(int SocialMediaid)
        {
            if (SocialMediaid <= 0)

                throw new ValidationException("SocialMedia Id is not provided to DAL");

            try
            {
                var SocialMedias = _context.SocialMedias.Find(SocialMediaid);

                //do null validation for user
                if (SocialMedias == null) throw new NullReferenceException($"SocialMedia Id not found{SocialMediaid}");
                SocialMedias.IsActive = false;
                _context.SocialMedias.Update(SocialMedias);
                _context.SaveChanges();
                return true;

            }


            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-DisableSocialMedia()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-DisableSocialMedia()-{exception.StackTrace}");
                return false;
            }

        }
        public List<Technology> GetallTechnologies()
        {

            try
            {

                return _context.Technologies.ToList();

            }

            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-GetallTechnologies()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-GetallTechnologies()-{exception.StackTrace}");
                throw exception;
            }
        }

        public Technology GetTechnologyById(int Technologyid)
        {
            if (Technologyid <= 0)

                throw new ValidationException("Technology Id is not provided to DAL");

            try
            {
                Technology technology = GetallTechnologies().Where(x => x.TechnologyId == Technologyid && x.IsActive).First();
                if (technology == null) throw new NullReferenceException($"Id not found-{technology}");
                return technology;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileData.cs-GetGetTechnologyById()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-GetGetTechnologyById()-{exception.StackTrace}");
                throw exception;
            }
        }
        public bool AddAchievements(Achievements achievements)
        {
            if (achievements == null)
                throw new ArgumentNullException("social media details object is not provided to DAL");
            try
            {
                achievements.IsActive = true;
                _context.achievements.Add(achievements);
                _context.SaveChanges();
                return true;
            }

            catch (Exception exception)
            {

                _logger.LogError($"ProfileData.cs-AddAchievements()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-AddAchievements()-{exception.StackTrace}");

                return false;
            }
        }

        public List<Achievements> GetallAchievements()
        {

            try
            {

                return _context.achievements.Include("achievementtype").ToList();

            }

            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-GetallAchievemets()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-GetallAchievemets()-{exception.StackTrace}");
                throw exception;
            }
        }
        public bool DisableAchievement(int AchievementId)
        {
            if (AchievementId <= 0)

                throw new ArgumentNullException("achievement Id is not provided to DAL");

            try
            {
                var achievement = _context.achievements.Find(AchievementId);

                //do null validation for user
                if (achievement == null) throw new NullReferenceException($"SocialMedia Id not found{AchievementId}");
                achievement.IsActive = false;
                _context.achievements.Update(achievement);
                _context.SaveChanges();
                return true;

            }


            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-RemoveAchievemen()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-RemoveAchievemen()-{exception.StackTrace}");
                return false;
            }

        }
        public List<Profile> GetallProfiles()
        {

            try
            {

                var result = _context.profile.Include("personalDetails").Include("education").Include("projects").Include("skills").Include("achievements").Include(e => e.profilestatus).ToList();
                // foreach (var item in result)
                // {
                //     item.user = item.user;
                // }
                return result;
            }

            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-GetallProfile()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-GetallProfile()-{exception.StackTrace}");
                throw exception;
            }
        }
        public ProfileStatus GetProfileStatusByProfileId(int Profileid)
        {
            if (Profileid <= 0)

                throw new ValidationException("Profile id is not provided to DAL");
            try
            {

                return _context.profile.Where(x => x.ProfileId == Profileid).Include(p => p.profilestatus).Select(p => p.profilestatus).First();
            }
            catch
            {
                System.Console.WriteLine("error");
                throw;
            }

        }
        public Profile GetProfileById(int ProfileId)
        {
            if (ProfileId <= 0)

                throw new ArgumentNullException("Profile id is not provided to DAL");

            try
            {

                Profile profile = GetallProfiles().Where(x => x.ProfileId == ProfileId && x.IsActive).First();
                if (profile == null) throw new NullReferenceException($"Id not found-{ProfileId}");
                return profile;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileData.cs-GetprofileById()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-GetprofileId()-{exception.StackTrace}");
                throw exception;
            }
        }

        public Profile GetProfileIdByUserId(int Userid)
        {
            if (Userid <= 0)
                throw new ArgumentNullException("User id is not provided to DAL");
            try
            {
                Profile profile = GetallProfiles().Where(x => x.UserId == Userid).FirstOrDefault();
                if (profile == null)
                    return new Profile();
                return profile;
            }
            catch (Exception exception)
            {
                System.Console.WriteLine("error");
                throw;
            }
        }
        public bool AddProfileHistory(ProfileHistory profilehistory)
        {
            if (profilehistory == null)
                throw new ArgumentNullException("profilehistory object is not provided to DAL");

            try
            {
                _context.profilehistory.Add(profilehistory);
                _context.SaveChanges();
                return true;
            }

            catch (Exception exception)
            {
                //log "unknown exception occured"
                _logger.LogError($"ProfileData.cs-AddProfileHistory()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-AddProfileHistory()-{exception.StackTrace}");

                return false;
            }


        }
        public List<ProfileHistory> GetallProfileHistories()
        {

            try
            {

                return _context.profilehistory.ToList();

            }

            catch (Exception exception)
            {
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-GetallProfile()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-GetallProfile()-{exception.StackTrace}");
                throw exception;
            }
        }

        public List<User> GetFilterdProfile(string userName, int designationId, int domainID, int technologyId, int collegeId, int profileStatusId, int maxExperience, int minExperience,int currentdesignation)
        {
            try
            {
                return _context.users
                   .Include(e => e.designation)
                   .Include(e => e.profile)
                   .Include(e => e.profile.personalDetails)
                   .Include(e => e.profile.profilestatus)
                   .Where(user => user.profile != null && user.personalDetails != null)
                   .WhereIf(String.IsNullOrEmpty(userName) == false, users => users.UserName.Contains(userName) == true)
                   .WhereIf(designationId != 0,users => users.DesignationId > currentdesignation && users.DesignationId == designationId)
                   .WhereIf(domainID != 0, users => users.DesignationId > currentdesignation && users.profile.skills.Any(s => s.DomainId == domainID) == true)
                   .WhereIf(technologyId != 0, users => users.DesignationId > currentdesignation && users.profile.skills.Any(s => s.TechnologyId == technologyId) == true)
                   .WhereIf(collegeId != 0, users => users.DesignationId > currentdesignation && users.profile.education.Any(s => s.CollegeId == collegeId) == true)
                   .WhereIf(profileStatusId != 0, users => users.DesignationId > currentdesignation && users.profile.ProfileStatusId == profileStatusId)
                   .ToList(); // users.DesignationId > currentdesignation && 
            }

            catch (Exception exception)
            {
                _logger.LogError($"ProfileData.cs-GetFilterdProfile()-{exception.Message}");
                throw;
            }
        }
        public bool AcceptOrRejectProfile(int profileId, int response)
        {
            if (profileId <= 0)
                throw new ValidationException("ProfileId cannot be negative in DAL");

            try
            {
                Profile status = _context.profile.Find(profileId);
                if (response == 2)
                    throw new ValidationException("cannot change to waiting for approval");
                else if (status.ProfileStatusId.Equals(1) || status.ProfileStatusId.Equals(3))
                    throw new ValidationException("Profile Status already Updated");
                status.ProfileStatusId = response;
                _context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileData.cs-AcceptOrRejectProfile()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-AcceptOrRejectProfile()-{exception.StackTrace}");
                throw exception;
            }

        }
        public Profile GetProfile(int ProfileId)
        {

            if (ProfileId <= 0)

                throw new ArgumentNullException("Profile id is not provided to DAL");

            try
            {
                return _context.profile.Find(ProfileId);
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileData.cs-GetprofileById()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-GetprofileId()-{exception.StackTrace}");
                throw exception;
            }
        }
        public bool updateProfileStatus(Profile profile)
        {
            if (profile == null || profile.ProfileId <= 0 || profile.UserId <= 0)
                throw new ValidationException("profileId should not null");

            if (!_context.profile.Any(e => e.ProfileId.Equals(profile.ProfileId)))
                throw new ValidationException("Profile doesnot exists");
            try
            {
                _context.profile.Update(profile);
                _context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileData.cs-AcceptOrRejectProfile()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-AcceptOrRejectProfile()-{exception.StackTrace}");
                throw exception;
            }
        }

    }


}


