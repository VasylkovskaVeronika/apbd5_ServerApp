using Microsoft.AspNetCore.Mvc;
using ServerApp.Database;

namespace ServerApp.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController: ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDB().Animals;
        return Ok(animals);
    }
}