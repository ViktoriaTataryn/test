using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers;
[ApiController]
[Route("api/test")]
public class TestController:ControllerBase
{
    [HttpGet]
    public ActionResult SayHello()
    {
        return Ok("Hello");
    }
}