using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Net;


namespace PMS_API;
[Authorize]
[ApiController]
[Route("[controller]/[Action]")]
public class CollegeController : ControllerBase
{
    private readonly ILogger _logger;
    private ICollegeServices  _CollegeServices;
    public CollegeController(ILogger<CollegeController> logger,ICollegeServices CollegeServices)
    {
        _logger = logger;
        _CollegeServices = CollegeServices;
    }
    //ICollegeServices collegeService = CollegeDataFactory.GetCollegeServiceObject(); //Calling Object
    [HttpGet]
    public IActionResult ViewColleges() //Getting The List of Colleges
    {
        try
        {
             _logger.LogInformation("List of Colleges......"); //Passing Information to log
            return Ok(_CollegeServices.ViewColleges());
           
        }
        catch (Exception exception) // Handling Exception
        {
             _logger.LogError($"CollegeController:ViewColleges()-{exception.Message}{exception.StackTrace}");
            return Problem(exception.Message);
           
        }
    }

}