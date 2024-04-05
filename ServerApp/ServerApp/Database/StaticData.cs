using ServerApp.Models;
namespace ServerApp.Database;

public class StaticData
{
    public List<Animal> animals { get; set; } = new List<Animal>()
    {
        new Animal(),
        new Animal()
    };
}