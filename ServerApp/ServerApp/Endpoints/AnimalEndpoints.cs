using ServerApp.Database;
using ServerApp.Models;

namespace ServerApp.Endpoints;

public static class AnimalEndpoints
{
    private static MockDB Data = new MockDB();
   
    public static void MapAnimalsEndpoints(this WebApplication app)
    {
        
        //get
        //retrieve a specific animal by id
        app.MapGet("/animals-minimalapi/{id}", (int id) =>
        {
            if (id > Data.Animals.Capacity) //our last existing id
            {
                return Results.NotFound();
            }
            else
            {
                return Results.Ok(Data.getAnimalById(id));
            }
            //proceed data
            return Results.Ok("I've got animals!"); //status code 200
        });
//status codes 201-created, 400-bad request. More the tutor send on Teams
//post
//add an animal
        app.MapPost("/animals", (Animal animal) =>
        {
            return Results.Created("", animal);
        });
        //put is implemented through AnimalsController ->
        //delete
        //delete an animal by id
        app.MapDelete("/animals-minimalapi/{id}", (int id) =>
        {
            return Results.Ok(Data.deleteAnimalById(id));
        });
        //delete an animal by all the details
        app.MapDelete("animals-minimalapi/{id&name&category&weight&fur}",
            (int id, string name, string category, double weight, string fur) =>
            {
                Animal a = new Animal(id, name, category, weight, fur);
                return Results.Ok(Data.deleteAnimal(a));
            });
    }
    
    
}