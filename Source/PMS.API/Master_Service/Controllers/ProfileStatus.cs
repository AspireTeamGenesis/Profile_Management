using Microsoft.AspNetCore.Mvc;
using PROFILE.Models;
using PROFILE.Services;
using System.Net;

namespace PROFILE.Controllers;

[ApiController]
[Route("[ProfileStatus]/[action]")]
public class ProfileStatusController : ControllerBase
{
    private readonly ILogger _logger;
   public ProfileStatusController(ILogger<ProfileStatusController> logger)
    {
        _logger = logger;
    }
     IProfileStatusServices ProfileStatusService = DataFactory.ProfileStatusDataFactory.GetProfileStatusServiceObject();
    [HttpGet]
    public IActionResult ViewProfileStatuss() //Getting the list of ProfileStatuss
    {
        try
        {
             _logger.LogInformation("List of ProfileStatuss......"); //Passing Information to log
            return Ok(ProfileStatusService.ViewProfileStatuss());
           
        }
        catch (Exception exception) // Handling Exception
        {
              _logger.LogError($"ProfileStatusController:ViewProfileStatuss()-{exception.Message}{exception.StackTrace}");
            return BadRequest(exception.Message);
           
        }
    }

}