namespace ServerApp.Models;

public class Visit
{
    public DateTime DateOfVisit { get; set; }
    public Animal Animal { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public Visit(DateTime dateOfVisit, Animal animal, string description, double price)
    {
        DateOfVisit = dateOfVisit;
        Animal = animal;
        Description = description;
        Price = price;
    }
}