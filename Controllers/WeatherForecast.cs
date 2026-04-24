using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase {
    
    [HttpGet]
    public IActionResult Index()
    {
        return Ok(new
        {
            message = "Hello from controller"
        });
    }
    [HttpGet]
    [Route("GetMessagesTest")]
    public IActionResult GetMessagesTest()
    {
        return Ok(new
        {
            message = "Hello from controller test endpoint"
        });
    }
}