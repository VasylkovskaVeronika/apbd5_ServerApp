using Microsoft.AspNetCore.Mvc;
using ServerApp.Database;
using ServerApp.Models;

namespace ServerApp.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController: ControllerBase
{
    //retrieve a list of animals
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDB().Animals;
        return Ok(animals);
    }

    //edit an animal
    [HttpPut]
    public IActionResult EditAnimal(Animal animal)
    {
        new MockDB().Animals[new MockDB().getAnimalId(animal)] = animal;
        return Ok(animal);
    }
}