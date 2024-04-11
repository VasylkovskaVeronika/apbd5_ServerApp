using ServerApp.Models;

namespace ServerApp.Database;

public class MockDB
{
    public List<Animal> Animals = new List<Animal>();

    public MockDB()
    {
        
    }

    public Animal getAnimalById(int id)
    {
        return Animals[id];
    }

    public int getAnimalId(Animal a)
    {
        int res=Animals.IndexOf(a);
       return res==-1?0:res;
    }

    public string deleteAnimalById(int id)
    {
        try
        {
            Animals.RemoveAt(id);  
        }
        catch (ArgumentOutOfRangeException e)
        {
            return "No such animal in the database";
        }

        return "Deleted successfully";
    }
    public string deleteAnimal(Animal animal)
    {
        return Animals.Remove(animal) ? "Deleted successfully" : "No such animal in the database";
    }
}