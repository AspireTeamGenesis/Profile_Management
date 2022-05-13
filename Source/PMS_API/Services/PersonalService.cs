using PMS_API;

namespace PMS_API
{
    public interface IPersonalService
    {
        bool AddPersonalDetail(PersonalDetails personalDetails);
        bool DisablePersonalDetails(int PersonalDetailsid);
        bool UpdatePersonalDetail(PersonalDetails personalDetails);
        bool AddEducation(Education education);
        bool UpdateEducation(Education education);
        bool DisableEducationalDetails(int Educationid);
        bool AddProjects(Projects project);
        bool UpdateProjects(Projects projects);
         bool DisableProjectDetails(int Projectid);
        bool AddSkills(Skills skill);
        bool UpdateSkills(Skills skill);
        bool DisableSkillDetails(int Skillid);
        bool AddBreakDuration(BreakDuration duration,int userID);
        bool DisableBreakDuration(int BreakDurationid);
        bool AddLanguage(Language language);
        bool DisableLanguage(int Languageid);
        bool AddSocialMedia(SocialMedia media);
        bool DisableSocialMedia(int SocialMediaid);
        IEnumerable<PersonalDetails> GetallPersonalDetails();
        object GetPersonalDetailsById(int id);
        IEnumerable<Education> GetallEducationDetails();
        object GetEducationDetailsById(int Educationid);
        IEnumerable<Projects> GetallProjectDetails();
        object GetProjectDetailsById(int Projectid);
        IEnumerable<Skills> GetallSkillDetails();
        object GetSkillDetailsById(int Skillid,int Technologyid);
        public IEnumerable<Object> GetAllEducationDetailsByPersonalDetailsId(int PersonalDetailid);
         public IEnumerable<Object> GetAllProjectDetailsByPersonalDetailsId(int PersonalDetailid);
         public IEnumerable<Object> GetAllSkillDetailsByPersonalDetailsId(int PersonalDetailid);
         object GetTechnologyById(int Technologyid);

        IEnumerable<Technology> GetallTechnologies();
    }

    public class PersonalService : IPersonalService
    {

        ProfileData profileData;
        private ILogger<PersonalService> _logger;

        public PersonalService(ILogger<PersonalService> logger)
        {
            _logger = logger;
            profileData = ProfileDataFactory.GetProfileData(logger);

        }
        public IEnumerable<PersonalDetails> GetallPersonalDetails()
        {
            try{
                // IEnumerable<User> userDetails = new List<User>();
             
                return from  personalDetails in profileData.GetallPersonalDetails() where personalDetails.IsActive==true select personalDetails;
                
            
            
            }
            catch(Exception exception){
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"PersonalServices:GetallPersonalDetails()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public bool AddPersonalDetail(PersonalDetails personalDetails)
        {
            if (personalDetails == null) throw new ArgumentNullException($"Values cannot be null values are {personalDetails}");
            try
            {
                
                personalDetails.CreatedBy = personalDetails.UserId;
                personalDetails.CreatedOn = DateTime.Now;
                return profileData.AddPersonalDetail(personalDetails) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddPersonalDetail()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }

        }
        public object GetPersonalDetailsById(int id)
        {
            if(id<=0)
                throw new ArgumentNullException($"ID is not provided{id}");
            try
            {
                var getpersonaldetails= profileData. GetPersonalDetailsById(id); 
                return new {
                    personaldetailsid=getpersonaldetails.PersonalDetailsId,
                    objective=getpersonaldetails.Objective,
                    dateofbirth=getpersonaldetails.DateOfBirth,
                    nationality=getpersonaldetails.Nationality,
                    dateofjoining=getpersonaldetails.DateOfJoining,
                    educationdetails=GetAllEducationDetailsByPersonalDetailsId(getpersonaldetails.PersonalDetailsId),
                    projectdetails=GetAllProjectDetailsByPersonalDetailsId(getpersonaldetails.PersonalDetailsId),
                    skilldetails=GetAllSkillDetailsByPersonalDetailsId(getpersonaldetails.PersonalDetailsId)


                };
            }
            catch(Exception exception){
                _logger.LogError($"UserServices:GetUser()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public bool UpdatePersonalDetail(PersonalDetails personalDetails)
        {
            if (personalDetails == null) throw new ArgumentNullException($" PersonalService:Update()-Personal values not be null{personalDetails}");

            try
            {
                personalDetails.UpdatedBy = personalDetails.CreatedBy;
                personalDetails.UpdatedOn = DateTime.Now;
                return profileData.UpdatePersonalDetail(personalDetails);
            }
            catch( Exception exception) 
            {
                _logger.LogInformation($"PersonalServices:Update()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
            
        }

        
        public bool DisablePersonalDetails(int PersonalDetailid)
        {
            if(PersonalDetailid<=0)
                throw new ArgumentNullException($"ID is not provided{PersonalDetailid}");

            
            try
            {

                return profileData.DisablePersonalDetails(PersonalDetailid)?true:false;
                
            }
            
            catch(Exception exception){
                _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }
          
        public bool AddEducation(Education education)
        {
            if (education == null) throw new ArgumentNullException($"Values cannot be null values are {education}");
            try
            {
                education.Starting = education.Starting_Year.Year;
                education.Ending = education.Ending_Year.Year;
                education.CreatedBy = education.personaldetailsid;
                education.CreatedOn = DateTime.Now;
                return profileData.AddEducation(education) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddEducation()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }
       
         public object GetEducationDetailsById(int Educationid)
        {
            if(Educationid<=0)
                throw new ArgumentNullException($"ID is not provided{Educationid}");
            try
            {
                var geteducationdetails= profileData.GetEducationDetailsById(Educationid); 
                return new {
                    educationid=geteducationdetails.EducationId,
                    degree =geteducationdetails.Degree,
                    course=geteducationdetails.Course,
                    college=geteducationdetails.college.CollegeName,
                    startingyear=geteducationdetails.Starting,
                    endingyear=geteducationdetails.Ending,
                    percentage=geteducationdetails.Percentage

                };
            }
            catch(Exception exception){
                _logger.LogError($"UserServices:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
         public IEnumerable<Education> GetallEducationDetails()
        {
            try{
                // IEnumerable<User> userDetails = new List<User>();
             
                return from educations in profileData.GetallEducationDetails() where educations.IsActive==true select educations;
                
            
            
            }
            catch(Exception exception){
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"PersonalServices:GetallPersonalDetails()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public IEnumerable<Object> GetAllEducationDetailsByPersonalDetailsId(int PersonalDetailId)
        {
            if(PersonalDetailId<=0)
                throw new ArgumentNullException($"ID is not provided{PersonalDetailId}");
            try
            {
                var geteducationdetailsbypersonalid= profileData.GetallEducationDetails().Where(item=> item.personaldetailsid==PersonalDetailId).Select(item =>
                 new {
                    educationid=item.EducationId,
                    degree =item.Degree,
                    course=item.Course,
                    college=item.college?.CollegeName,
                    startingyear=item.Starting,
                    endingyear=item.Ending,
                    percentage=item.Percentage

                });return geteducationdetailsbypersonalid;
            }
            catch(Exception exception){
                _logger.LogError($"UserServices:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public bool UpdateEducation(Education education)
        {
            if (education == null) throw new ArgumentNullException($" PersonalServices:UpdateEducation()-Education values not be null{education}");

            try
            {
                education.UpdatedBy = education.CreatedBy;
                education.UpdatedOn = DateTime.Now;
                return profileData.UpdateEducation(education);

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:UpdateEduaction()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
        }
        public bool DisableEducationalDetails(int EducationalDetailid)
        {
            if(EducationalDetailid<=0)
                throw new ArgumentNullException($"ID is not provided{EducationalDetailid}");

            
            try
            {

                return profileData.DisableEducationalDetails(EducationalDetailid)?true:false;
                
            }
            
            catch(Exception exception){
                _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }    

        public bool AddProjects(Projects project)
        {
            if (project == null) throw new ArgumentNullException($"Values cannot be null values are {project}");
            try
            {
                project.StartingMonth=project.ProjectStartingMonth.Month.ToString("MMM");
                project.StartingYear=project.ProjectStartingYear.Year;
                project.EndingMonth=project.ProjectEndingMonth.Month.ToString("MMM");
                project.EndingYear=project.ProjectEndingYear.Year;
                project.CreatedBy = project.PersonalDetailsId;
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
            if(Projectid<=0)
                throw new ArgumentNullException($"ID is not provided{Projectid}");
            try
            {
                var getprojectdetails= profileData. GetProjectDetailsById(Projectid); 
                return new {
                    projectid=getprojectdetails.ProjectId,
                    projectname=getprojectdetails.ProjectName,
                    projectdescription=getprojectdetails.ProjectDescription,
                    startingMonth=getprojectdetails.StartingMonth,
                    startingYear=getprojectdetails.StartingYear,
                    endingMonth=getprojectdetails.EndingMonth,
                    endingYear=getprojectdetails.EndingYear,
                    role=getprojectdetails.Designation,
                    toolsused=getprojectdetails.ToolsUsed,

                };
            }
            catch(Exception exception){
                _logger.LogError($"UserServices:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public IEnumerable<Projects> GetallProjectDetails()
        {
            try{
                // IEnumerable<User> userDetails = new List<User>();
             
                return from projects in profileData.GetallProjectDetails() where projects.IsActive==true select projects;
                
            
            
            }
            catch(Exception exception){
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"PersonalServices:GetallProjectDetails()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public IEnumerable<Object> GetAllProjectDetailsByPersonalDetailsId(int PersonalDetailid)
        {
            if(PersonalDetailid<=0)
                throw new ArgumentNullException($"ID is not provided{PersonalDetailid}");
            try
            {
                var getallprojectdetailsbypersonalid= profileData.GetallProjectDetails().Where(item=> item.PersonalDetailsId==PersonalDetailid).Select(item =>
                 new {
                     projectid=item.ProjectId,
                     projectname=item.ProjectName,
                     projectdescription=item.ProjectDescription,
                    startingMonth=item.StartingMonth,
                    startingYear=item.StartingYear,
                    endingMonth=item.EndingMonth,
                    endingYear=item.EndingYear,
                    role=item.Designation,
                    toolsused=item.ToolsUsed

                    

                });return  getallprojectdetailsbypersonalid;
            }
            catch(Exception exception){
                _logger.LogError($"UserServices:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public bool UpdateProjects(Projects projects)
        {
            if (projects == null) throw new ArgumentNullException($" PersonalServices:UpdateProjcts()-Project values not be null{projects}");

            try
            {
                projects.UpdatedBy = projects.CreatedBy;
                projects.UpdatedOn = DateTime.Now;
                return profileData.UpdateProjects(projects);

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:UpdateProject()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
        }
        public bool DisableProjectDetails(int ProjectDetailid)
        {
            if(ProjectDetailid<=0)
                throw new ArgumentNullException($"ID is not provided{ProjectDetailid}");

            
            try
            {

                return profileData.DisableProjectDetails(ProjectDetailid)?true:false;
                
            }
            
            catch(Exception exception){
                _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }   

        public bool AddSkills(Skills skill)
        {
            if (skill == null) throw new ArgumentNullException($"Values cannot be null values are {skill}");
            try
            {
                skill.CreatedBy = skill.PersonalDetailsId;
                skill.CreatedOn = DateTime.Now;
                return profileData.AddSkills(skill) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddSkills()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }
       
         public object GetSkillDetailsById(int Skillid,int Technologyid)
        {
            if(Skillid<=0)
                throw new ArgumentNullException($"ID is not provided{Skillid}");
            try
            {
                var getskilldetails= profileData.GetSkillDetailsById(Skillid); 
                return new {
                    skillid=getskilldetails.SkillId,
                    domainname=getskilldetails.domain.DomainName,
                    technology = profileData.GetTechnologyById(Technologyid).TechnologyName
                    

                };
            }
            catch(Exception exception){
                _logger.LogError($"UserServices:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
         public IEnumerable<Skills> GetallSkillDetails()
        {
            try{
                // IEnumerable<User> userDetails = new List<User>();
             
                return from skills in profileData.GetallSkillDetails() where skills.IsActive==true select skills;
                
            
            
            }
            catch(Exception exception){
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"PersonalServices:GetallSkillDetails()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public IEnumerable<Object> GetAllSkillDetailsByPersonalDetailsId(int PersonalDetailid)
        {
            if(PersonalDetailid<=0)
                throw new ArgumentNullException($"ID is not provided{PersonalDetailid}");
            try
            {
                var getallskilldetailsbypersonalid= profileData.GetallSkillDetails().Where(item=> item.PersonalDetailsId==PersonalDetailid).Select(item =>
                 new {
                     skillid=item.SkillId,
                    domainname=item.domain.DomainName
                     

                    

                });return  getallskilldetailsbypersonalid;
            }
            catch(Exception exception){
                _logger.LogError($"UserServices:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public bool UpdateSkills(Skills skill)
        {
            if (skill == null) throw new ArgumentNullException($" PersonalServices:Update()-skill values not be null{skill}");

            try
            {
                skill.UpdatedBy = skill.CreatedBy;
                skill.UpdatedOn = DateTime.Now;
                return profileData.UpdateSkills(skill);

            }

            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:Update()-{exception.Message}\n{exception.StackTrace}");
                return false;

            }
        }
         public bool DisableSkillDetails(int SkillDetailid)
        {
            if(SkillDetailid<=0)
                throw new ArgumentNullException($"ID is not provided{SkillDetailid}");

            
            try
            {

                return profileData.DisableSkillDetails(SkillDetailid)?true:false;
                
            }
            
            catch(Exception exception){
                _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }   
        public bool AddBreakDuration(BreakDuration duration,int userID)
        {
            if (duration == null) throw new ArgumentNullException($"Values cannot be null values are {duration}");
            try
            {
                duration.CreatedBy = userID;
                duration.CreatedOn = DateTime.Now;
                return profileData.AddBreakDuration(duration) ? true : false;
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServices:AddSkills()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }


        }
         public bool DisableBreakDuration(int BreakDurationid)
        {
            if(BreakDurationid<=0)
                throw new ArgumentNullException($"ID is not provided{BreakDurationid}");

            
            try
            {

                return profileData.DisableBreakDuration(BreakDurationid)?true:false;
                
            }
            
            catch(Exception exception){
                _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }    
        public bool AddLanguage(Language language,int userId)
        {
            if (language == null) throw new ArgumentNullException($"Values cannot be null values are {language}");
            try
            {
                language.CreatedBy = userId; 
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
            if(Languageid<=0)
                throw new ArgumentNullException($"ID is not provided{Languageid}");

            
            try
            {

                return profileData.DisableLanguage(Languageid)?true:false;
                
            }
            
            catch(Exception exception){
                _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }    
        public bool AddSocialMedia(SocialMedia media,int userId)
        {
            if (media == null) throw new ArgumentNullException($"Values cannot be null values are {media}");
            try
            {
                media.CreatedBy = userId;
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
            if(SocialMediaid<=0)
                throw new ArgumentNullException($"ID is not provided{SocialMediaid}");

            
            try
            {

                return profileData.DisableSocialMedia(SocialMediaid)?true:false;
                
            }
            
            catch(Exception exception){
                _logger.LogInformation($"PersonalServices:Delete()-{exception.Message}\n{exception.StackTrace}");
                return false;
            }
        }

        
        public object GetTechnologyById(int Technologyid)
        {
            if(Technologyid<=0)
                throw new ArgumentNullException($"ID is not provided{Technologyid}");
            try
            {
                var gettechnologydetails= profileData.GetTechnologyById(Technologyid); 
                return new {
                   technologyname=gettechnologydetails.TechnologyName
                };
            }
            catch(Exception exception){
                _logger.LogError($"UserServices:GetEducationDetailsById()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }
        public IEnumerable<Technology> GetallTechnologies()
        {
            try{
                // IEnumerable<User> userDetails = new List<User>();
             
                return from Technologies in profileData.GetallTechnologies() where Technologies.IsActive==true select Technologies;
                
            
            
            }
            catch(Exception exception){
                // Log Exception occured in DAL while fetching users
                _logger.LogError($"PersonalServices:GetallPersonalDetails()-{exception.Message}\n{exception.StackTrace}");
                throw exception;
            }
        }

        
    }
}