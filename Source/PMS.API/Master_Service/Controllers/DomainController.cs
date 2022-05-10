using Microsoft.AspNetCore.Mvc;
using PROFILE.Models;
using PROFILE.Services;
using System.Net;

namespace PROFILE.Controllers;

[ApiController]
[Route("[Domain]/[action]")]
public class DomainController : ControllerBase
{
    private readonly ILogger _logger;
    public DomainController(ILogger<DomainController> logger)
    {
        _logger = logger;
    }
    IDomainServices DomainService = DataFactory.DomainDataFactory.GetDomainServiceObject();
    [HttpGet]
    public IActionResult ViewDomains() //Getting the list of Domains
    {
        try
        {
             _logger.LogInformation("List of Domains......"); //Passing Information to log
            return Ok(DomainService.ViewDomains());
           
        }
        catch (Exception exception) // Handling Exception
        {
             _logger.LogError($"DomainController:ViewDomains()-{exception.Message}{exception.StackTrace}");
            return BadRequest(exception.Message);
           
        }
    }

}