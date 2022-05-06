using Microsoft.AspNetCore.Mvc;
using PROFILE.Models;
using PROFILE.Services;
using System.Net;

namespace PROFILE.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CollegeController : ControllerBase
{
    private readonly ILogger _logger;
    public CollegeController(ILogger<CollegeController> logger)
    {
        _logger = logger;
    }
    ICollegeServices collegeService = DataFactory.CollegeDataFactory.GetCollegeServiceObject(); //Calling Object
    [HttpGet]
    public IActionResult ViewColleges() //Getting The List of Colleges
    {
        try
        {
             _logger.LogInformation("List of Colleges......"); //Passing Information to log
            return Ok(collegeService.ViewColleges());
           
        }
        catch (Exception exception) // Handling Exception
        {
             _logger.LogError($"CollegeController:ViewColleges()-{exception.Message}{exception.StackTrace}");
            return BadRequest(exception.Message);
           
        }
    }

}