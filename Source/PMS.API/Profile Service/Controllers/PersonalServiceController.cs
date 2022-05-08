using Microsoft.AspNetCore.Mvc;
namespace PMS.API
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class PersonalServiceController:Controller
    {
        private IPersonalService _personalService;
        private ILogger _logger;
        public PersonalServiceController(IPersonalService personalService,ILogger<PersonalServiceController> logger)
        {
            _personalService=personalService;
            _logger=logger;
        }

        [HttpPost]
        public IActionResult AddPersonalDetail(PersonalDetails personalDetails)
        {
            if(User==null){
                _logger.LogError("PersonalServiceController:AddPersonalDetail():User tries to enter null values");
                return BadRequest("PersonalDetails not be null");
            }
            try{
                return _personalService.AddPersonalDetail(personalDetails)?Ok("PersonalDetails added"):Problem("Some internal Error occured");
            }
            catch(Exception exception)
            {
                 _logger.LogInformation($"PersonalServiceControllerController :AddPersonalDetail()-{exception.Message}{exception.StackTrace}");
                
                 return BadRequest(exception.Message);
            }
            


        } 
        [HttpPost]
        public IActionResult AddEducation(Education education)
        {
            if(education==null)
            {
                _logger.LogError("PersonalServiceController:AddEducation():user tries to enter null values");
                return BadRequest("Education details not be null");
            }
            try
            {
                return _personalService.AddEducation(education)?Ok("Education details added"):Problem("Some internal Error occured");   
            }
             catch(Exception exception)
            {
                 _logger.LogInformation($"PersonalServiceControllerController :AddEducation()-{exception.Message}{exception.StackTrace}");
                
                 return BadRequest(exception.Message);
            }


        }
        [HttpPost]
        public IActionResult AddProjects(Projects projects)
        {
            if(projects==null)
            {
                _logger.LogError("PersonalServiceController:AddProjects():user tries to enter null values");
                return BadRequest("Education details not be null");
            }
            try
            {
                return _personalService.AddProjects(projects)?Ok("project details added"):Problem("Some internal Error occured");   
            }
             catch(Exception exception)
            {
                 _logger.LogInformation($"PersonalServiceControllerController :AddProjects()-{exception.Message}{exception.StackTrace}");
                
                 return BadRequest(exception.Message);
            }

        }
        [HttpPost]
        public IActionResult AddSkills(Skills skill)
        {
            if(skill==null)
            {
                _logger.LogError("PersonalServiceController:AddSkills():user tries to enter null values");
                return BadRequest("Education details not be null");
            }
            try
            {
                return _personalService.AddSkills(skill)?Ok("Skill details added"):Problem("Some internal Error occured");   
            }
             catch(Exception exception)
            {
                 _logger.LogInformation($"PersonalServiceControllerController :AddSkills()-{exception.Message}{exception.StackTrace}");
                
                 return BadRequest(exception.Message);
            }

        }
        [HttpPost]
        public IActionResult AddBreakDuration(BreakDuration duration)
        {
            if(duration==null)
            {
                _logger.LogError("PersonalServiceController:AddBreakDuration():user tries to enter null values");
                return BadRequest("BreakDuration details not be null");
            }
            try
            {
                return _personalService.AddBreakDuration(duration)?Ok("BreakDuration details added"):Problem("Some internal Error occured");   
            }
             catch(Exception exception)
            {
                 _logger.LogInformation($"PersonalServiceControllerController :AddBreakDuration()-{exception.Message}{exception.StackTrace}");
                
                 return BadRequest(exception.Message);
            }

        }
        [HttpPost]
        public IActionResult AddLanguage(Language language)
        {
            if(language==null)
            {
                _logger.LogError("PersonalServiceController:AddLanguage():user tries to enter null values");
                return BadRequest("Language details not be null");
            }
            try
            {
                return _personalService.AddLanguage(language)?Ok("Language details added"):Problem("Some internal Error occured");   
            }
             catch(Exception exception)
            {
                 _logger.LogInformation($"PersonalServiceControllerController :AddSkills()-{exception.Message}{exception.StackTrace}");
                
                 return BadRequest(exception.Message);
            }

        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia media)
        {
            if(media==null)
            {
                _logger.LogError("PersonalServiceController:AddSocialMedia():user tries to enter null values");
                return BadRequest("social media details not be null");
            }
            try
            {
                return _personalService.AddSocialMedia(media)?Ok("Social media details added"):Problem("Some internal Error occured");   
            }
             catch(Exception exception)
            {
                 _logger.LogInformation($"PersonalServiceControllerController :AddSocialMedia()-{exception.Message}{exception.StackTrace}");
                
                 return BadRequest(exception.Message);
            }

        }
        
      
    }
}