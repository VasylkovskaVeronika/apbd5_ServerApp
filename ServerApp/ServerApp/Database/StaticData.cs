using ServerApp.Models;
namespace ServerApp.Database;

public class StaticData
{
    public List<Animal> Animals { get; set; } = new List<Animal>()
    {
        new Animal(0, "a", "cat", 5,"ginger"),
        new Animal(1, "b", "dog", 20, "brown")
    };

    public List<Visit> Visits { get; set; } = new List<Visit>();

    public StaticData()
    {
        Visits.Add(new Visit(new DateTime(2024, 2, 4), Animals[0],
            "...", 200.67));
        Visits.Add(new Visit(new DateTime(), Animals[0], "...", 250));
    }
}