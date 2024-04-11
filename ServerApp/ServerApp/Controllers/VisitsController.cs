using Microsoft.AspNetCore.Mvc;
using ServerApp.Database;
using ServerApp.Models;

namespace ServerApp.Controllers;

[ApiController]
[Route("[controller]")]
public class VisitsController: ControllerBase
{
    //retrieve a list of visits by animal
    [HttpGet]
    public IActionResult GetVisits(Animal a)
    {
        var visits = new MockDB().relatedToAnimal(a);
        return Ok(visits);
    }
    //add new visits
    [HttpPost]
    public IActionResult AddVisit(DateTime date, Animal a, string desc, double price)
    {
        Visit newV = new Visit(date, a, desc, price);
        return Created("", newV);
    }
}