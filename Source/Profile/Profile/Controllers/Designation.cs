using Microsoft.AspNetCore.Mvc;
using PROFILE.Models;
using PROFILE.Services;
using System.Net;

namespace PROFILE.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class DesignationController : ControllerBase
{
    private readonly ILogger _logger;
    public DesignationController(ILogger<DesignationController> logger)
    {
        _logger = logger;
    }
    IDesignationServices DesignationService = DataFactory.DesignationDataFactory.GetDesignationServiceObject();
    [HttpGet]
    public IActionResult ViewDesignations() //Getting the list of Designation
    {
        try
        {
             _logger.LogInformation("List of Designations......"); // Passing Information to log
            return Ok(DesignationService.ViewDesignations());
           
        }
         catch (Exception exception) // Handling Exception
        {
             _logger.LogError($"DesignationController:ViewDesignations()-{exception.Message}{exception.StackTrace}");
            return BadRequest(exception.Message);
           
        }
    }

}