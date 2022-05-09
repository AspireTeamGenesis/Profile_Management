using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace PMS.API
{
    public interface IPersonalDetails
    {
        
    }
    public class ProfileData
    {
        private ProfileContext _context;
        private ILogger<PersonalService> _logger;
        
        public ProfileData(ProfileContext context,ILogger<PersonalService> logger)
        {
            _context=context;
            _logger=logger;
        }
        public List<PersonalDetails> GetallPersonalDetails()
        {
            
            try{

                return _context.personalDetails.ToList();
                
            }
            
            catch(Exception exception){
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-GetallPersonalDetails()-{exception.Message}");
                _logger.LogInformation($"UserData.cs-GetallPersonalDetails()-{exception.StackTrace}");
                throw exception;
            }
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
        public bool RemovePersonalDetail(int PersonalDetailsId)
        {
            if(PersonalDetailsId<=0)
                throw new ValidationException("PersonalDetails Id is not provided to DAL");
            
            try{
                var personalDetails = _context.personalDetails.Find(PersonalDetailsId);
                
            //do null validation for personaldetails
            if(personalDetails==null)throw new NullReferenceException($"PersonalDetails Id not found{PersonalDetailsId}");
                personalDetails.IsActive=false;
                _context.personalDetails.Update(personalDetails);
                _context.SaveChanges();
                return true;
            
            }
           
          
            catch(Exception exception){
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-Disable()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-Disable()-{exception.StackTrace}");
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
        public bool RemoveEducation(int Education_Id)
        {
            if(Education_Id<=0)
               
                throw new ValidationException("Education Id is not provided to DAL");
            
            try{
                var educations = _context.educations.Find(Education_Id);
                
            //do null validation for education
            if(educations==null)throw new NullReferenceException($"Education Id not found{Education_Id}");
                educations.IsActive=false;
                _context.educations.Update(educations);
                _context.SaveChanges();
                return true;
            
            }
           
          
            catch(Exception exception){
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-Disable()-{exception.Message}");
                _logger.LogInformation($"ProfileDate.cs-Disable()-{exception.StackTrace}");
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
        public bool RemoveProjects(int Project_Id)
        {
            if(Project_Id<=0)
               
                throw new ValidationException("Project Id is not provided to DAL");
            
            try{
                var projects = _context.projects.Find(Project_Id);
                
            //do null validation for 
            if(projects==null)
                throw new NullReferenceException($"Project Id not found{Project_Id}");

                projects.IsActive=false;
                _context.projects.Update(projects);
                _context.SaveChanges();
                return true;
            
            }
           
          
            catch(Exception exception){
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-Disable()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-Disable()-{exception.StackTrace}");
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
        public bool RemoveBreakDuration(int BreakDuration_Id)
        {
            if(BreakDuration_Id<=0)
               
                throw new ValidationException("BreakDuration Id is not provided to DAL");
            
            try{
                var breakDurations = _context.breakDurations.Find(BreakDuration_Id);
                
            //do null validation for user
            if(breakDurations==null)throw new NullReferenceException($"Project Id not found{BreakDuration_Id}");
                breakDurations.IsActive=false;
                _context.breakDurations.Update(breakDurations);
                _context.SaveChanges();
                return true;
            
            }
           
          
            catch(Exception exception){
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-Disable()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-Disable()-{exception.StackTrace}");
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
        public bool RemoveSkills(int Skill_Id)
        {
            if(Skill_Id<=0)
               
                throw new ValidationException("Skill Id is not provided to DAL");
            
            try{
                var skills = _context.skills.Find(Skill_Id);
                
            //do null validation for user
            if(skills==null)throw new NullReferenceException($"Skill Id not found{Skill_Id}");
                skills.IsActive=false;
                _context.skills.Update(skills);
                _context.SaveChanges();
                return true;
            
            }
           
          
            catch(Exception exception){
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-Disable()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-Disable()-{exception.StackTrace}");
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
         public bool RemoveLanguage(int Language_Id)
        {
            if(Language_Id<=0)
               
                throw new ValidationException("Language Id is not provided to DAL");
            
            try{
                var languages = _context.languages.Find(Language_Id);
                
            //do null validation for user
            if(languages==null)throw new NullReferenceException($"Language Id not found{Language_Id}");
                languages.IsActive=false;
                _context.languages.Update(languages);
                _context.SaveChanges();
                return true;
            
            }
           
          
            catch(Exception exception){
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-Disable()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-Disable()-{exception.StackTrace}");
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
         public bool RemoveSocialMedia(int SocialMedia_Id)
        {
            if(SocialMedia_Id<=0)
               
                throw new ValidationException("SocialMedia Id is not provided to DAL");
            
            try{
                var SocialMedias = _context.SocialMedias.Find(SocialMedia_Id);
                
            //do null validation for user
            if(SocialMedias==null)throw new NullReferenceException($"SocialMedia Id not found{SocialMedia_Id}");
                SocialMedias.IsActive=false;
                _context.SocialMedias.Update(SocialMedias);
                _context.SaveChanges();
                return true;
            
            }
           
          
            catch(Exception exception){
                //log "if exception occures"
                _logger.LogError($"ProfileData.cs-Disable()-{exception.Message}");
                _logger.LogInformation($"ProfileData.cs-Disable()-{exception.StackTrace}");
                 return false;
            }
            
        }


    }
}