using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Net;

namespace PMS_API;
[Authorize]
[ApiController]
[Route("[controller]/[Action]")]
public class DomainController : ControllerBase
{
    private readonly ILogger _logger;
    private IDomainServices _DomainServices;
    public DomainController(ILogger<DomainController> logger,IDomainServices DomainServices)
    {
        _logger = logger;
        _DomainServices = DomainServices;
    }
    //IDomainServices DomainService = DomainDataFactory.GetDomainServiceObject();
    [HttpGet]
    public IActionResult ViewDomains() //Getting the list of Domains
    {
        try
        {
             _logger.LogInformation("List of Domains......"); //Passing Information to log
            return Ok(_DomainServices.ViewDomains());
           
        }
        catch (Exception exception) // Handling Exception
        {
             _logger.LogError($"DomainController:ViewDomains()-{exception.Message}{exception.StackTrace}");
            return Problem(exception.Message);
           
        }
    }

}