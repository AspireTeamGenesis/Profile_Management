using Microsoft.AspNetCore.Mvc;
using PROFILE.Models;
using PROFILE.Services;
using System.Net;

namespace PROFILE.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CollegeController : ControllerBase
{
    //creating logger reference
    private readonly ILogger _logger;
    public CollegeController(ILogger<CollegeController> logger)
    {
        _logger = logger;
    }
    //calling college object using factory
    ICollegeServices collegeService = DataFactory.CollegeDataFactory.GetCollegeServiceObject();

    //Creating new college
    [HttpPost,ActionName("Create")]
    public IActionResult CreateNewCollege(string collegeName)
    {
        if (collegeName == null) 
            return BadRequest("College name is required");

        try
        {
            return collegeService.CreateCollege(collegeName) ? Ok("College Added Successfully") : BadRequest("Sorry internal error occured");
        }
        catch (Exception ex)
        {
            
            return BadRequest($"Sorry some internal error occured  while adding the collegename{collegeName}");
            _logger.LogError($"{ex.Message}\n {ex.StackTrace}");
        }
    }
    //Disabling the college
    [HttpDelete,ActionName("Disable")]
    public IActionResult RemoveCollege(int collegeId)
    {
        if (collegeId == 0) return BadRequest("College Id is not provided");

        try
        {
            return collegeService.RemoveCollege(collegeId) ? Ok("College Removed Successfully") : BadRequest("Sorry internal error occured");
        }
        catch (Exception ex)
        {
            
            return BadRequest($"Sorry some internal error occured while disabling{collegeId}");
            _logger.LogError($"{ex.Message}\n {ex.StackTrace}");
        }
    }
    //Getting all colleges
    [HttpGet,ActionName("GetAllColleges")]
    public IActionResult ViewColleges()
    {
        try
        {
            
            return Ok(collegeService.ViewColleges());
            _logger.LogInformation("List of Colleges......");
        }
        catch (Exception ex)
        {
            
            return BadRequest("Sorry some internal error occured");
            _logger.LogError($"{ex.Message}\n {ex.StackTrace}");
        }
    }

}