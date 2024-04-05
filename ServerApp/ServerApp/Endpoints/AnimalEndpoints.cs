using ServerApp.Models;

namespace ServerApp.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalsEndpoints(this WebApplication app)
    {
        //get
        app.MapGet("/animals-minimalapi/{id}", (int id) =>
        {
            if (id != 1)
            {
                return Results.NotFound();
            }
            //proceed data
            return Results.Ok("I've got animals!"); //status code 200
        });
//status codes 201-created, 400-bad request. More the tutor send on Teams
//post
        app.MapPost("/animals", (Animal animal) =>
        {
            return Results.Created("", animal);
        });
    }
}