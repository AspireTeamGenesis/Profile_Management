using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Net;

namespace PMS_API;
[Authorize]
[ApiController]
[Route("[controller]/[Action]")]
public class TechnologyController : ControllerBase
{
    private readonly ILogger _logger;
    private ITechnologyServices _TechnologyServices;
    public TechnologyController(ILogger<TechnologyController> logger,ITechnologyServices TechnologyServices)
    {
        _logger = logger;
        _TechnologyServices = TechnologyServices;
    }
    //ITechnologyServices technologyService = TechnologyDataFactory.GetTechnologyServiceObject();
    [HttpGet]
    public IActionResult ViewTechnologies() //Getting the list of Technologies
    {
        try
        {
             _logger.LogInformation("List of Technologies......"); //Passing the Information to log
            return Ok(_TechnologyServices.ViewTechnologies());
           
        }
        catch (Exception exception) // Handling Exception
        {
             _logger.LogError($"TechnologyController:ViewTechnologies()-{exception.Message}{exception.StackTrace}");
            return Problem(exception.Message);
           
        }
    }

}