using System.ComponentModel.DataAnnotations;
using PMS_API;

namespace PMS_API
{
    public class ProfileService : IProfileService
    {

        ProfileData profileData;
        private ILogger<ProfileService> _logger;
        private static ProfileValidation _profileValidate = ProfileDataFactory.GetProfileVaidationObject();

        public ProfileService(ILogger<ProfileService> logger)
        {
            _logger = logger;
            profileData = ProfileDataFactory.GetProfileData(logger);

        }
        public double calculateExperience(int personalId)
        {
            if (personalId <= 0)
            {
                throw new ArgumentNullException($"ID is not provided : {personalId}");
            }
            try
            {
                var breakDuration = profileData.GetBreakDurationByPersonalDetailsId(personalId);
                var personalDetail = profileData.GetPersonalDetailsById(personalId);
                var exp = (DateTime.Now - personalDetail.DateOfJoining).TotalDays;
                double diff = 0;
                foreach (var item in breakDuration)
                {
                    diff += (item.EndingDuration - item.StartingDuration).TotalDays;
                }

                double var = Math.Round((exp - diff) / 365, 1);
                return var;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileServices:calculateExperience()-{exception.Message}\n{exception.StackTrace}");
                throw exception;

            }
        }
        public bool AddProfile(Profile profile)
        {
            if (profile == null) throw new ArgumentNullException($"Values cannot be null values are {profile}");
            try
            {
                return profileData.AddProfile(profile) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"ProfileService:AddProfile()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }

        }

        public bool AddPersonalDetail(PersonalDetails personalDetails)
        {
            if (personalDetails == null) throw new ArgumentNullException($"Values cannot be null values are {personalDetails}");
            _profileValidate.PersonalDetailsvalidate(personalDetails);
            try
            {

                personalDetails.CreatedBy = personalDetails.UserId;
                personalDetails.CreatedOn = DateTime.Now;
                string Imagedate = "";
                Imagedate = ImageService.Getbase64String(personalDetails.base64header);

                personalDetails.base64header = ImageService.Getbase64Header(personalDetails.base64header);

                personalDetails.Image = System.Convert.FromBase64String(Imagedate);
                return profileData.AddPersonalDetail(personalDetails) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"ProfileService:AddPersonalDetail()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }

        }
        public IEnumerable<PersonalDetails> GetAllPersonalDetails()
        {
            try
            {
                // IEnumerable<User> userDetails = new List<User>();

                return from personalDetails in profileData.GetAllPersonalDetails() where personalDetails.IsActive == true select personalDetails;



            }
            catch (Exception exception)
            {
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"ProfileService:GetallPersonalDetails()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public object GetPersonalDetailsById(int Personalid)
        {
            if (Personalid <= 0)
                throw new ArgumentNullException($"ID is not provided{Personalid}");
            try
            {
                var getpersonaldetails = profileData.GetPersonalDetailsById(Personalid);
                return new
                {
                    personaldetailsid = getpersonaldetails.PersonalDetailsId,
                    Image = getpersonaldetails.Image,
                    objective = getpersonaldetails.Objective,
                    dateofbirth = getpersonaldetails.DateOfBirth,
                    nationality = getpersonaldetails.Nationality,
                    dateofjoining = getpersonaldetails.DateOfJoining,
                    language = getpersonaldetails.language,
                    socialmedia = getpersonaldetails.socialmedia,
                    breakduration = getpersonaldetails.breakDuration,

                };
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileService:GetPersonalDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public object GetPersonalDetailsByProfileId(int Profileid)
        {
            if (Profileid <= 0)
                throw new ArgumentNullException($"ID is not provided{Profileid}");
            try
            {
                var getpersonaldetailsbyprofileid = profileData.GetAllPersonalDetails().Where(item => item.ProfileId == Profileid).Select(item =>
                 new
                 {
                     personaldetailsid = item.PersonalDetailsId,
                     Image = item.Image,
                     objective = item.Objective,
                     dateofbirth = item.DateOfBirth,
                     nationality = item.Nationality,
                     dateofjoining = item.DateOfJoining,
                     language = removeAdditionalDetailsExceptLanguage(item.language),
                     socialmedia = removeAdditionalDetailsExceptSocialMedia(item.socialmedia),
                     breakduration = removeAdditionalDetailsExceptBreakDuration(item.breakDuration),



                 }); return getpersonaldetailsbyprofileid;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileService:GetPersonalDetailsByProfileId()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        private ICollection<Language> removeAdditionalDetailsExceptLanguage(ICollection<Language> languages)
        {
            foreach (var item in languages)
            {
                item.personalDetails = null;
            }
            return languages;
        }
        private ICollection<BreakDuration> removeAdditionalDetailsExceptBreakDuration(ICollection<BreakDuration> breakDurations)
        {
            foreach (var item in breakDurations)
            {
                item.personalDetails = null;
            }
            return breakDurations;
        }
        private ICollection<SocialMedia> removeAdditionalDetailsExceptSocialMedia(ICollection<SocialMedia> socialMedias)
        {
            foreach (var item in socialMedias)
            {
                item.personalDetails = null;
            }
            return socialMedias;
        }
        public PersonalDetails GetPersonalById(int PersonalDetailsId)//fetch PersonalDetail based on PersonaldetailsId, used for update operation
        {
            try
            {
                if (PersonalDetailsId <= 0)
                    throw new ArgumentNullException($"ID is not provided{PersonalDetailsId}");
                PersonalDetails personalDetails = profileData.GetPersonalDetailsById(PersonalDetailsId);
                return personalDetails;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileService:GetPersonalById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public bool UpdatePersonalDetail(PersonalDetails personalDetails)
        {
            if (personalDetails == null) throw new ArgumentNullException($" ProfileService:UpdatePersonalDetail()-Personal values not be null{personalDetails}");
            _profileValidate.PersonalDetailsvalidate(personalDetails);
            try
            {
                var Profile = GetPersonalById(personalDetails.PersonalDetailsId);
                if (Profile.Objective != personalDetails.Objective)
                    Profile.Objective = personalDetails.Objective;
                if (Profile.DateOfBirth != personalDetails.DateOfBirth)
                    Profile.DateOfBirth = personalDetails.DateOfBirth;
                if (Profile.DateOfJoining != personalDetails.DateOfJoining)
                    Profile.DateOfJoining = personalDetails.DateOfJoining;
                if (Profile.Nationality != personalDetails.Nationality)
                    Profile.Nationality = personalDetails.Nationality;
                if (Profile.base64header != personalDetails.base64header)
                    Profile.base64header = personalDetails.base64header;
                if (Profile.Image != personalDetails.Image)
                    Profile.Image = personalDetails.Image;

                Profile.UpdatedBy = personalDetails.CreatedBy;
                Profile.UpdatedOn = DateTime.Now;
                return profileData.UpdatePersonalDetail(Profile);
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"ProfileService:UpdatePersonalDetail()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }

        }


        public bool DisablePersonalDetails(int PersonalDetailid)
        {
            if (PersonalDetailid <= 0)
                throw new ArgumentNullException($"ID is not provided{PersonalDetailid}");


            try
            {

                return profileData.DisablePersonalDetails(PersonalDetailid) ? true : false;

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"ProfileService:DisablePersonalDetails()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }

        public bool AddEducation(Education education)
        {
            if (education == null) throw new ArgumentNullException($"Values cannot be null values are {education}");
            _profileValidate.Educationdetailvalidation(education);
            try
            {
                // education.Starting = education.Starting;
                // education.Ending = education.Ending;
                education.CreatedBy = education.ProfileId;
                education.CreatedOn = DateTime.Now;
                return profileData.AddEducation(education) ? true : false;
            }
            catch (ValidationException exception)
            {
                _logger.LogError($"ProfileService:AcceptOrRejectProfile()-{exception.Message}\n{exception.StackTrace}");
                throw;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"ProfileService:AddEducation()-{exception.Message}\n{exception.StackTrace}");
                throw;
                
            }
            return false;

        }

        public Object GetEducationDetailsById(int Educationid)
        {
            if (Educationid <= 0)
                throw new ArgumentNullException($"ID is not provided{Educationid}");
            try
            {
                var geteducationdetails = profileData.GetEducationDetailsById(Educationid);
                return new
                {
                    educationid = geteducationdetails.EducationId,
                    degree = geteducationdetails.Degree,
                    course = geteducationdetails.Course,
                    college = geteducationdetails.college.CollegeName,
                    collegeid = geteducationdetails.CollegeId,
                    starting = geteducationdetails.Starting,
                    ending = geteducationdetails.Ending,
                    percentage = geteducationdetails.Percentage

                };
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileService:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public IEnumerable<Education> GetallEducationDetails()
        {
            try
            {
                // IEnumerable<User> userDetails = new List<User>();

                return from educations in profileData.GetallEducationDetails() where educations.IsActive == true select educations;



            }
            catch (Exception exception)
            {
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"ProfileService:GetallEducationDetails()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public IEnumerable<Object> GetAllEducationDetailsByProfileId(int Profileid)
        {
            if (Profileid <= 0)
                throw new ArgumentNullException($"ID is not provided{Profileid}");
            try
            {
                var geteducationdetailsbyprofileid = profileData.GetallEducationDetails().Where(item => item.ProfileId == Profileid && item.IsActive == true).Select(item =>
                 new
                 {
                     educationid = item.EducationId,
                     degree = item.Degree,
                     course = item.Course,
                     college = item.college?.CollegeName,
                     startingyear = item.Starting,
                     endingyear = item.Ending,
                     percentage = item.Percentage

                 }); return geteducationdetailsbyprofileid;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileService:GetAllEducationDetailsByProfileId()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public Education GetEducationById(int EducationId)//Return EducationDetails based on EducationId
        {
            try
            {
                if (EducationId <= 0)
                    throw new ArgumentNullException($"ID is not provided{EducationId}");
                Education education = profileData.GetEducationDetailsById(EducationId);
                return education;
            }
            catch (Exception exception)
            {
                _logger.LogError($"UserServices:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }

        }
        public bool UpdateEducation(Education education)
        {
            if (education == null) throw new ArgumentNullException($" PersonalServices:UpdateEducation()-Education values not be null{education}");
            _profileValidate.Educationdetailvalidation(education);
            try
            {
                Education Profile = GetEducationById(education.EducationId);

                if (Profile.Degree != education.Degree)
                    Profile.Degree = education.Degree;
                if (Profile.Course != education.Course)
                    Profile.Course = education.Course;
                if (Profile.CollegeId != education.CollegeId)
                    Profile.CollegeId = education.CollegeId;
                if (Profile.Starting != education.Starting)
                    Profile.Starting = education.Starting;
                if (Profile.Ending != education.Ending)
                    Profile.Ending = education.Ending;
                if (Profile.Percentage != education.Percentage)
                    Profile.Percentage = education.Percentage;
                Profile.UpdatedBy = education.CreatedBy;
                Profile.UpdatedOn = DateTime.Now;

                return profileData.UpdateEducation(Profile);

            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:UpdateEduaction()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }
        public bool DisableEducationalDetails(int EducationalDetailid)
        {
            if (EducationalDetailid <= 0)
                throw new ArgumentNullException($"ID is not provided{EducationalDetailid}");


            try
            {

                return profileData.DisableEducationalDetails(EducationalDetailid) ? true : false;

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }

        public bool AddProjects(Projects project)
        {
            if (project == null) throw new ArgumentNullException($"Values cannot be null values are {project}");
            _profileValidate.ProjectDetailvalidation(project);
            try
            {
                project.IsActive = true;
                project.CreatedBy = project.ProfileId;
                project.CreatedOn = DateTime.Now;
                return profileData.AddProjects(project) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddProjects()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }

        public object GetProjectDetailsById(int Projectid)
        {
            if (Projectid <= 0)
                throw new ArgumentNullException($"ID is not provided{Projectid}");
            try
            {
                var getprojectdetails = profileData.GetProjectDetailsById(Projectid);
                return new
                {
                    projectid = getprojectdetails.ProjectId,
                    projectname = getprojectdetails.ProjectName,
                    projectdescription = getprojectdetails.ProjectDescription,
                    startingMonth = getprojectdetails.StartingMonth,
                    startingYear = getprojectdetails.StartingYear,
                    endingMonth = getprojectdetails.EndingMonth,
                    endingYear = getprojectdetails.EndingYear,
                    role = getprojectdetails.Designation,
                    toolsused = getprojectdetails.ToolsUsed,

                };
            }
            catch (Exception exception)
            {
                _logger.LogError($"UserServices:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public IEnumerable<Projects> GetallProjectDetails()
        {
            try
            {
                // IEnumerable<User> userDetails = new List<User>();

                return from projects in profileData.GetallProjectDetails() where projects.IsActive == true select projects;



            }
            catch (Exception exception)
            {
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"PersonalServices:GetallProjectDetails()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public IEnumerable<Object> GetAllProjectDetailsByProfileId(int Profileid)
        {
            if (Profileid <= 0)
                throw new ArgumentNullException($"ID is not provided{Profileid}");
            try
            {

                var getallprojectdetailsbyprofileid = profileData.GetallProjectDetails().Where(item => item.ProfileId == Profileid && item.IsActive == true).Select(item =>
                 new
                 {

                     projectid = item.ProjectId,
                     projectname = item.ProjectName,
                     projectdescription = item.ProjectDescription,
                     startingMonth = item.StartingMonth,
                     startingYear = item.StartingYear,
                     endingMonth = item.EndingMonth,
                     endingYear = item.EndingYear,
                     role = item.Designation,
                     toolsused = item.ToolsUsed




                 }); return getallprojectdetailsbyprofileid;


            }
            catch (Exception exception)
            {
                _logger.LogError($"UserServices:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public Projects GetProjectById(int ProjectId)//fetch Projects based on ProjectId,used for Update Operation
        {
            try
            {
                if (ProjectId <= 0)
                    throw new ArgumentNullException($"ProjectID is invalid{ProjectId}");
                Projects project = profileData.GetProjectDetailsById(ProjectId);
                return project;
            }
            catch (Exception exception)
            {
                _logger.LogError($"UserServices:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }

        }
        public bool UpdateProjects(Projects projects)
        {
            if (projects == null) throw new ArgumentNullException($" PersonalServices:UpdateProjcts()-Project values not be null{projects}");
            _profileValidate.ProjectDetailvalidation(projects);
            try
            {
                var Profile = GetProjectById(projects.ProjectId);

                if (Profile.ProjectName != projects.ProjectName)
                    Profile.ProjectName = projects.ProjectName;
                if (Profile.ProjectDescription != projects.ProjectDescription)
                    Profile.ProjectDescription = projects.ProjectDescription;
                if (Profile.StartingMonth != projects.StartingMonth)
                    Profile.StartingMonth = projects.StartingMonth;
                if (Profile.StartingYear != projects.StartingYear)
                    Profile.StartingYear = projects.StartingYear;
                if (Profile.EndingMonth != projects.EndingMonth)
                    Profile.EndingMonth = projects.EndingMonth;
                if (Profile.EndingYear != projects.EndingYear)
                    Profile.EndingYear = projects.EndingYear;
                if (Profile.Designation != projects.Designation)
                    Profile.Designation = projects.Designation;
                if (Profile.ToolsUsed != projects.ToolsUsed)
                    Profile.ToolsUsed = projects.ToolsUsed;

                Profile.IsActive = projects.IsActive;
                Profile.UpdatedBy = projects.CreatedBy;
                Profile.UpdatedOn = DateTime.Now;
                return profileData.UpdateProjects(Profile);

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:UpdateProject()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
        }
        public bool DisableProjectDetails(int ProjectDetailid)
        {
            if (ProjectDetailid <= 0)
                throw new ArgumentNullException($"ID is not provided{ProjectDetailid}");


            try
            {

                return profileData.DisableProjectDetails(ProjectDetailid) ? true : false;

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }

        public bool AddSkills(Skills skill)
        {
            if (skill == null) throw new ArgumentNullException($"Values cannot be null values are {skill}");
            _profileValidate.SkillDetailValidation(skill);
            try
            {
                skill.CreatedBy = skill.ProfileId;
                skill.CreatedOn = DateTime.Now;
                return profileData.AddSkills(skill) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddSkills()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }

        public object GetSkillDetailsById(int Skillid)
        {
            if (Skillid <= 0)
                throw new ArgumentNullException($"ID is not provided{Skillid}");
            try
            {
                var getskilldetails = profileData.GetSkillDetailsById(Skillid);
                return new
                {
                    skillid = getskilldetails.SkillId,
                    domainname = getskilldetails.domain.DomainName,
                    technologyname = getskilldetails.technology.TechnologyName
                };
            }
            catch (Exception exception)
            {
                _logger.LogError($"UserServices:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public IEnumerable<Skills> GetallSkillDetails()
        {
            try
            {
                // IEnumerable<User> userDetails = new List<User>();

                return from skills in profileData.GetallSkillDetails() where skills.IsActive == true select skills;



            }
            catch (Exception exception)
            {
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"PersonalServices:GetallSkillDetails()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public IEnumerable<Object> GetAllSkillDetailsByProfileId(int Profileid)
        {
            if (Profileid <= 0)
                throw new ArgumentNullException($"ID is not provided{Profileid}");
            try
            {
                var getallskilldetailsbyprofileid = profileData.GetallSkillDetails().Where(item => item.ProfileId == Profileid && item.IsActive == true).Select(item =>
                new
                {
                    skillid = item.SkillId,
                    domainname = item.domain.DomainName,
                    technologyname = item.technology.TechnologyName
                }); return getallskilldetailsbyprofileid;
            }
            catch (Exception exception)
            {
                _logger.LogError($"UserServices:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public Skills GetSkillById(int SkillId)//fetch Skills based on SkillId,used for Update Operation
        {
            try
            {
                if (SkillId <= 0)
                    throw new ArgumentNullException($"SkillID is not provided{SkillId}");
                var skills = profileData.GetSkillDetailsById(SkillId);
                return skills;
            }
            catch (Exception exception)
            {
                _logger.LogError($"UserServices:GetSkillById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }

        }
        public bool UpdateSkills(Skills skill)
        {
            if (skill == null) throw new ArgumentNullException($" PersonalServices:Update()-skill values not be null{skill}");
            _profileValidate.SkillDetailValidation(skill);
            try
            {
                var skills = GetSkillById(skill.SkillId);

                if (skills.DomainId != skill.DomainId)
                    skills.DomainId = skill.DomainId;
                if (skills.TechnologyId != skill.TechnologyId)
                    skills.TechnologyId = skill.TechnologyId;
                skills.UpdatedBy = skill.CreatedBy;
                skills.UpdatedOn = DateTime.Now;

                return profileData.UpdateSkills(skills);
            }

            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:Update()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
        }

        public bool DisableSkillDetails(int SkillDetailid)
        {
            if (SkillDetailid <= 0)
                throw new ArgumentNullException($"ID is not provided{SkillDetailid}");


            try
            {

                return profileData.DisableSkillDetails(SkillDetailid) ? true : false;

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }
        public bool AddBreakDuration(BreakDuration duration)
        {
            if (duration == null) throw new ArgumentNullException($"Values cannot be null values are {duration}");
            _profileValidate.BreakDurationValidation(duration);
            try
            {
                duration.CreatedBy = duration.PersonalDetailsId;
                duration.CreatedOn = DateTime.Now;
                return profileData.AddBreakDuration(duration) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddBreakDuration()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }
        public bool DisableBreakDuration(int BreakDurationid)
        {
            if (BreakDurationid <= 0)
                throw new ArgumentNullException($"ID is not provided{BreakDurationid}");


            try
            {

                return profileData.DisableBreakDuration(BreakDurationid) ? true : false;

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }
        public bool AddLanguage(Language language)
        {
            if (language == null) throw new ArgumentNullException($"Values cannot be null values are {language}");
            _profileValidate.languageValidation(language);
            try
            {
                language.CreatedBy = language.PersonalDetailsId;
                language.CreatedOn = DateTime.Now;
                return profileData.AddLanguage(language) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddSkills()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }


        public bool DisableLanguage(int Languageid)
        {
            if (Languageid <= 0)
                throw new ArgumentNullException($"ID is not provided{Languageid}");


            try
            {

                return profileData.DisableLanguage(Languageid) ? true : false;

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"ProfileServices:DisableLanguage()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }
        public bool AddSocialMedia(SocialMedia media)
        {
            if (media == null) throw new ArgumentNullException($"Values cannot be null values are {media}");
            _profileValidate.SocialMediaDetailValidation(media);
            try
            {
                media.CreatedBy = media.PersonalDetailsId;
                media.CreatedOn = DateTime.Now;
                return profileData.AddSocialMedia(media) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddSkills()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }
        public bool DisableSocialMedia(int SocialMediaid)
        {
            if (SocialMediaid <= 0)
                throw new ArgumentNullException($"ID is not provided{SocialMediaid}");


            try
            {

                return profileData.DisableSocialMedia(SocialMediaid) ? true : false;

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }


        public object GetTechnologyById(int Technologyid)
        {
            if (Technologyid <= 0)
                throw new ArgumentNullException($"ID is not provided{Technologyid}");
            try
            {
                var gettechnologydetails = profileData.GetTechnologyById(Technologyid);
                return new
                {
                    technologyname = gettechnologydetails.TechnologyName
                };
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileServices:GetTechnologyById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public IEnumerable<Technology> GetallTechnologies()
        {
            try
            {
                // IEnumerable<User> userDetails = new List<User>();

                return from Technologies in profileData.GetallTechnologies() where Technologies.IsActive == true select Technologies;



            }
            catch (Exception exception)
            {
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"PersonalServices:GetallPersonalDetails()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public bool AddAchievements(Achievements achievement)
        {
            if (achievement == null) throw new ArgumentNullException($"Values cannot be null values are {achievement}");
            _profileValidate.AchievementValidation(achievement);
            try
            {
                string Imagedate = "";
                Imagedate = ImageService.Getbase64String(achievement.base64header);
                achievement.base64header = ImageService.Getbase64Header(achievement.base64header);
                achievement.AchievementImage = System.Convert.FromBase64String(Imagedate);


                achievement.CreatedOn = DateTime.Now;
                return profileData.AddAchievements(achievement) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"ProfileServices:AddAchievements()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }
        public IEnumerable<Achievements> GetallAchievements()
        {
            try
            {
                // IEnumerable<User> userDetails = new List<User>();

                return from achievements in profileData.GetallAchievements() where achievements.IsActive == true select achievements;



            }
            catch (Exception exception)
            {
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"PersonalServices:GetallSkillDetails()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public IEnumerable<Object> GetAllAchievementDetailsByProfileId(int Profileid)
        {
            if (Profileid <= 0)
                throw new ArgumentNullException($"ID is not provided{Profileid}");
            try
            {
                var getachievementsbypersonalid = profileData.GetallAchievements().Where(item => item.ProfileId == Profileid && item.IsActive == true).Select(item =>
                 new
                 {
                     achievementid = item.AchievementId,
                     achievementtype = item.achievementtype.AchievementTypeName,
                     achievementimage = item.AchievementImage

                 }); return getachievementsbypersonalid;
            }
            catch (Exception exception)
            {
                _logger.LogError($"UserServices:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public bool DisableAchievement(int achievementId)
        {
            if (achievementId <= 0)
                throw new ArgumentNullException($"Achievement ID is not provided{achievementId}");


            try
            {

                return profileData.DisableAchievement(achievementId) ? true : false;

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:RemoveAchievemen()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }
        public IEnumerable<Profile> GetallProfiles()
        {
            try
            {
                var result = from profile in profileData.GetallProfiles() where profile.IsActive == true select profile;
                foreach (var item in result)
                {
                    if(item.personalDetails!=null)
                    item.year = calculateExperience(item.personalDetails.PersonalDetailsId);

                }
                return result;


            }
            catch (Exception exception)
            {

                _logger.LogError($"ProfileService:GetallProfiles()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public object GetProfileStatusByProfileId(int Profileid)
        {
            if (Profileid <= 0)
                throw new ArgumentNullException($"ID is not provided{Profileid}");
            try
            {
                return profileData.GetProfileStatusByProfileId(Profileid);
            }
            catch (Exception exception)
            {

                _logger.LogError($"ProfileService:GetProfileStatusByProfileId()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public object GetProfileById(int Profileid)
        {
            if (Profileid <= 0)
                throw new ArgumentNullException($"ID is not provided{Profileid}");
            try
            {
                // var getviewdetails= profileData.GetallProfiles().Where(item => item.ProfileId==Profileid && item.IsActive==true).Select(item =>
                var getviewdetails =
                new
                {
                    personaldetails = GetPersonalDetailsByProfileId(Profileid),
                    educationdetails = GetAllEducationDetailsByProfileId(Profileid),
                    projectdetails = GetAllProjectDetailsByProfileId(Profileid),
                    skilldetails = GetAllSkillDetailsByProfileId(Profileid),
                    achievementdetails = GetAllAchievementDetailsByProfileId(Profileid),
                    profilestatus = GetProfileStatusByProfileId(Profileid),
                    // updateddate=profileData.GetProfileById(Profileid).UpdatedOn

                };
                //); 
                return getviewdetails;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileService:GetProfileById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public object GetSpecificProfile()
        {

            try
            {
                var getprofile = profileData.GetallProfiles().Select(item =>
                new
                {
                    Status = item.profilestatus.ProfileStatusName,
                    Name = item.personalDetails.users.Name,
                    Designation = item.personalDetails.users.designation.DesignationName,
                    ReportingPerson = item.personalDetails.users.ReportingPersonUsername,



                }); return getprofile;

            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileServices:GetSpecificProfile()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public object GetProfileIdByUserId(int Userid)
        {
            if (Userid <= 0)
                throw new ArgumentNullException($"ID is not provided{Userid}");
            try
            {
                var getprofile = profileData.GetProfileIdByUserId(Userid);

                if (getprofile.IsActive)
                {
                    return new
                    {
                        profilestatus = getprofile.profilestatus.ProfileStatusName,
                        profileId = getprofile.ProfileId
                    };
                }
                return getprofile;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileServices:GetProfileIdByUserId()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }

        }
        public bool AddProfileHistory(ProfileHistory profilehistory)
        {
            if (profilehistory == null)
                throw new ArgumentNullException($"Values cannot be null values are {profilehistory}");

            profilehistory.profile = profileData.GetProfileById(profilehistory.ProfileId);
            if (profilehistory.profile.ProfileStatusId != 1)
                throw new ValidationException("Status should be Approved by Reporting Person");
            try
            {
                return profileData.AddProfileHistory(profilehistory) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"ProfileService:AddProfileHistory()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }

        }
        public IEnumerable<object> GetallProfileHistories()
        {
            try
            {
                // IEnumerable<User> userDetails = new List<User>();
                // var lastFiveProducts = (from p in products 
                //         orderby p.ProductDate descending
                //         select p).Take(5);


                return profileData.GetallProfileHistories().Where(item => item.IsActive).OrderByDescending(item => item.ApprovedDate).Select(item => new
                {
                    profileHistory = item,
                    Profile = GetProfileById(item.ProfileId)

                });



            }
            catch (Exception exception)
            {
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"ProfileServices:GetallProfiles()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public IEnumerable<object> GetProfileHistoryById(int Profileid)

        {

            if (Profileid <= 0)

                throw new ArgumentNullException($"ID is not provided{Profileid}");

            try

            {

                return profileData.GetallProfileHistories().Where(item => item.ProfileId == Profileid).OrderByDescending(item => item.ApprovedDate).Take(3).Select(item =>

                new
                {

                    profileHistory = item,

                    Profile = GetProfileById(item.ProfileId)

                });



            }

            catch (Exception exception)

            {

                _logger.LogError($"ProfileService:GetProfileHistoryById()-{exception.Message}\n{exception.StackTrace}");

                throw exception;

            }
        }

        public object GetProfileCount()
        {
            try
            {
                var profile = GetallProfiles();
                var Approved = profile.Where(p => p.ProfileStatusId == 1).Count();
                var Rejected = profile.Where(p => p.ProfileStatusId == 3).Count();
                var Waiting = profile.Where(p => p.ProfileStatusId == 2).Count();
                var total = profile.Count();
                var result = new Dictionary<string, int>();
                result.Add("Approved Profiles", Approved);
                result.Add("Rejected Profiles", Rejected);
                result.Add("Waiting Profiles", Waiting);
                result.Add("Total Profiles", total);
                return result;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileService:GetProfileCount()-{exception.Message}\n{exception.StackTrace}");

                throw exception;
            }

        }

        public object GetFilterdProfile(string userName, int designationId, int domainID, int technologyId, int collegeId, int profileStatusId, int maxExperience, int minExperience)
        {
            try
            {
                
                return profileData.GetFilterdProfile(userName,designationId, domainID, technologyId, collegeId, profileStatusId,maxExperience, minExperience)
                // .WhereIf(
                //     (user=>user.personalDetails!=null &&  maxExperience!=0 && minExperience!=0 ),
                //     ( minExperience<=calculateExperience(user=>user.personalDetails.PersonalDetailsId) && maxExperience>=calculateExperience(user.personalDetails.PersonalDetailsId))
                //     )
                .Select(user => new
                {
                    profileId = user.profile.ProfileId,
                    profileStatus = user.profile.profilestatus.ProfileStatusName,
                    name = user.Name,
                    designation = user.designation.DesignationName,
                    repotingPerson = user.ReportingPersonUsername,
                    image = user.personalDetails.Image
                });
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileService : GetFilterdProfile()-{exception.Message}\n{exception.StackTrace}");
                throw;
            }
        }
        public bool AcceptOrRejectProfile(int profileId, int response)
        {
            if (profileId <= 0)
                throw new ValidationException($"ProfileId cannot be negative:");

            try
            {
                return profileData.AcceptOrRejectProfile(profileId, response) ? true : false;
            }
            catch (ValidationException exception)
            {
                _logger.LogError($"ProfileService:AcceptOrRejectProfile()-{exception.Message}\n{exception.StackTrace}");
                throw;
            }
            catch (Exception exception)
            {
                _logger.LogError($"ProfileService:AcceptOrRejectProfile()-{exception.Message}\n{exception.StackTrace}");
                throw;
            }
        }
    }
}