namespace PMS.API
{
    public class ProfileData
    {
        private ProfileContext _context;
        private ILogger<PersonalService> _logger;
        
        public ProfileData(ProfileContext context,ILogger<PersonalService> logger)
        {
            _context=context;
            _logger=logger;
        }

         public bool AddPersonalDetail(PersonalDetails personalDetails)
        {
            
            
            if (personalDetails == null)
                throw new ArgumentNullException("personalDetails object is not provided to DAL");
           
            try{
            
            _context.personalDetails.Add(personalDetails);
            _context.SaveChanges();
            return true;
            }
            
            catch(Exception exception){
                //log "unknown exception occured"
                 _logger.LogError($"ProfileData.cs-AddPersonalDetails()-{exception.Message}");
                 _logger.LogInformation($"ProfileData.cs-AddPersonalDetails()-{exception.StackTrace}");
                 
                 return false;
            }
            
            
        }
         public bool AddEducation(Education education)
        {
            
            
            if (education == null)
                throw new ArgumentNullException("Education detail object is not provided to DAL");
           
            try{
            
            _context.educations.Add(education);
            _context.SaveChanges();
            return true;
            }
            
            catch(Exception exception){
                //log "unknown exception occured"
                 _logger.LogError($"ProfileData.cs-AddEducation()-{exception.Message}");
                 _logger.LogInformation($"ProfileData.cs-AddEducation()-{exception.StackTrace}");
                 
                 return false;
            }
            
            
        }
         public bool AddProjects(Projects projects)
        {
            
            
            if (projects == null)
                throw new ArgumentNullException("project detail object is not provided to DAL");
           
            try{
            
            _context.projects.Add(projects);
            _context.SaveChanges();
            return true;
            }
            
            catch(Exception exception){
                //log "unknown exception occured"
                 _logger.LogError($"ProfileData.cs-AddProjects()-{exception.Message}");
                 _logger.LogInformation($"ProfileData.cs-AddProjects()-{exception.StackTrace}");
                 
                 return false;
            }
            
            
        }
         public bool AddBreakDuration(BreakDuration duration)
        {
            
            
            if (duration == null)
                throw new ArgumentNullException("Break duration detail object is not provided to DAL");
           
            try{
            
            _context.breakDurations.Add(duration);
            _context.SaveChanges();
            return true;
            }
            
            catch(Exception exception){
                //log "unknown exception occured"
                 _logger.LogError($"ProfileData.cs-AddBreakDuration()-{exception.Message}");
                 _logger.LogInformation($"ProfileData.cs-AddSBreakDuration()-{exception.StackTrace}");
                 
                 return false;
            }
            
            
        }
         public bool AddSkills(Skills skill)
        {
            
            
            if (skill == null)
                throw new ArgumentNullException("Education detail object is not provided to DAL");
           
            try{
            
            _context.skills.Add(skill);
            _context.SaveChanges();
            return true;
            }
            
            catch(Exception exception){
                //log "unknown exception occured"
                 _logger.LogError($"ProfileData.cs-AddSkills()-{exception.Message}");
                 _logger.LogInformation($"ProfileData.cs-AddSkills()-{exception.StackTrace}");
                 
                 return false;
            }
            
            
        }
         public bool AddLanguage(Language language)
        {
            
            
            if (language == null)
                throw new ArgumentNullException("Language details object is not provided to DAL");
           
            try{
            
            _context.languages.Add(language);
            _context.SaveChanges();
            return true;
            }
            
            catch(Exception exception){
                //log "unknown exception occured"
                 _logger.LogError($"ProfileData.cs-AddLanguage()-{exception.Message}");
                 _logger.LogInformation($"ProfileData.cs-AddLanguage()-{exception.StackTrace}");
                 
                 return false;
            }
            
            
        }
        public bool AddSocialMedia(SocialMedia media)
        {
            if(media ==null)
                throw new ArgumentNullException("social media details object is not provided to DAL");
            try{
            
            _context.SocialMedias.Add(media);
            _context.SaveChanges();
            return true;
            }
            
            catch(Exception exception){
                //log "unknown exception occured"
                 _logger.LogError($"ProfileData.cs-AddSocialMedia()-{exception.Message}");
                 _logger.LogInformation($"ProfileData.cs-AddSocialMedia()-{exception.StackTrace}");
                 
                 return false;
            }
        }


    }
}