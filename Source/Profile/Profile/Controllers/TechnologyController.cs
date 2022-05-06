using Microsoft.AspNetCore.Mvc;
using PROFILE.Models;
using PROFILE.Services;
using System.Net;

namespace PROFILE.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class TechnologyController : ControllerBase
{
    private readonly ILogger _logger;
    public TechnologyController(ILogger<TechnologyController> logger)
    {
        _logger = logger;
    }
    ITechnologyServices technologyService = DataFactory.TechnologyDataFactory.GetTechnologyServiceObject();
    [HttpGet]
    public IActionResult ViewTechnologies() //Getting the list of Technologies
    {
        try
        {
             _logger.LogInformation("List of Technologies......"); //Passing the Information to log
            return Ok(technologyService.ViewTechnologies());
           
        }
        catch (Exception exception) // Handling Exception
        {
             _logger.LogError($"TechnologyController:ViewTechnologies()-{exception.Message}{exception.StackTrace}");
            return BadRequest(exception.Message);
           
        }
    }

}