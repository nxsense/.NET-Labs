using lab1.Models;

namespace lab1.Data;

public class DataContext
{
    public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    public List<Person> People { get; set; } = new List<Person>();
    public List<Drivers> Drivers { get; set; } = new List<Drivers>();
    public List<Address> Addresses { get; set; } = new List<Address>();
    public List<Brand> Brands { get; set; } = new List<Brand>();
    public List<Model> CarModel { get; set; } = new List<Model>();
}