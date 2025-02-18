using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers;
[ApiController]
[Route("api/test")]
public class TestController:ControllerBase
{
    //new
    [HttpGet]
    public ActionResult SayHello2()
    {
        return Ok("Hello");
    }
    //origin
    [HttpGet]
    public ActionResult SayHello()
    {
        return Ok("Hello");
    }
    
}