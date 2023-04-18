using lab1.Models;

namespace lab1.Data;

public class DataInitializer
{
    private readonly DataContext _dataContext;

    public DataInitializer(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public void Initialize()
    {
        _dataContext.Addresses.AddRange(new List<Address>()
        {
            new (1, "Kyiv", "Akademika Yanhelia", "20"),
            new (2,"Kyiv", "Velyka Vasylkivska", "35"),
            new (3,"Kyiv", "Baseyna", "1"),
            new (4, "Kyiv", "Metalistiv", "5"),
        });
        
        _dataContext.Brands.AddRange(new List<Brand>()
        {
            new(1, "Tesla", "USA"),
            new(2, "Audi", "Germany"),
            new(3, "BMW", "Germany"),
            new(4, "Toyota", "Japan"),
            new(5, "Chevrolet", "USA")
        });
        
        _dataContext.CarModel.AddRange(new List<Model>()
        {
            new (1, 1, "Model S", BodyType.Sedan, 2019),
            new (2, 2, "R8", BodyType.Sedan, 2010),
            new (3, 3, "I8", BodyType.Sedan, 2020),
            new (4, 4, "Corolla", BodyType.Sedan, 2019),
            new (5, 5, "Tahoe", BodyType.Jeep, 2019),
            new (6, 1, "Model X", BodyType.Sedan, 2021),
            new (7, 2, "Vezel", BodyType.Van, 2008),
            new (8, 3, "X5", BodyType.Jeep, 2019),
            new (9, 4, "Sienna", BodyType.Van, 2015),
            new (10, 5, "Express", BodyType.Van, 2000),
        });
        _dataContext.People.AddRange(new List<Person>()
        {
            new (1, "DL12345", "Smith", "John", "Michael", new DateOnly(1990, 5, 15), 1),
            new (2, "DL67890", "Johnson", "Emily", "Ann", new DateOnly(1985, 9, 2), 2),
            new (3, "DL24680", "Williams", "Jessica", "Marie", new DateOnly(1995, 2, 28), 3),
            new (4, "DL13579", "Brown", "David", "Lee", new DateOnly(1992, 11, 11), 4),
            new (5, "DL86420", "Garcia", "Maria", "Isabel", new DateOnly(1988, 7, 3), 4)
        });
        _dataContext.Vehicles.AddRange(new List<Vehicle>()
        {
            new (1, 1, "1G4HD5723J4853960", "ВА9432ВІ", "Black", TechnicalCondition.Satisfactory, 1),
            new (2, 2, "5NMSH4AG7JH050844", "МІ2775ЕК", "Black", TechnicalCondition.Satisfactory, 2),
            new (3, 3, "1C6RR7LT6GS244818", "ВА9432ВІ", "Black", TechnicalCondition.Satisfactory, 3),
            new (4, 4, "WBA7E2C56GG547213", "НТ2847ЕВ", "Black", TechnicalCondition.Satisfactory, 4),
            new (5, 5, "1C4PJMBSXFW663689", "ВА9432ВІ", "Black", TechnicalCondition.Satisfactory, 5),
            new (6, 6, "5UXCR6C56M9F93517", "ТК3994СХ", "Black", TechnicalCondition.Satisfactory, 1),
            new (7, 7, "1GNSKJKC9JR213612", "АТ8881ВХ", "Black", TechnicalCondition.Satisfactory, 2),
            new (8, 8, "1FMCU0G61LUA20461", "ВС6488АМ", "Black", TechnicalCondition.Satisfactory, 3),
            new (9, 9, "5TDYZ3DC3LS032155", "СС7421СТ", "Black", TechnicalCondition.Satisfactory, 4),
            new (10, 10, "WBA5A7C51ED615790", "ВК5735ЕА", "Black", TechnicalCondition.Satisfactory, 5),
            
        });
        _dataContext.Drivers.AddRange(new List<Drivers>()
        {
            new Drivers(1, 1, 1),
            new Drivers(2, 2, 2),
            new Drivers(3, 3, 3),
            new Drivers(4, 4, 4),
            new Drivers(5, 5, 5),
            new Drivers(6, 1, 6),
            new Drivers(7, 2, 7),
            new Drivers(8, 3, 8),
            new Drivers(9, 4, 9),
            new Drivers(10, 5, 10),
            
        }); }

    public void DisplayAllTables()
    {
        Console.WriteLine("Brands:");
        _dataContext.Brands.ForEach(brand => Console.WriteLine(brand.ToString()));
        Console.WriteLine();

        Console.WriteLine("Models");
        _dataContext.CarModel.ForEach(model => Console.WriteLine(model.ToString()));
        Console.WriteLine();

        Console.WriteLine("People:");
        _dataContext.People.ForEach(driver => Console.WriteLine(driver.ToString()));
        Console.WriteLine();

        Console.WriteLine("Vehicles:");
        _dataContext.Vehicles.ForEach(vehicle => Console.WriteLine(vehicle.ToString()));
        Console.WriteLine();

        Console.WriteLine("Drivers:");
        _dataContext.Drivers.ForEach(driver => Console.WriteLine(driver.ToString()));
        Console.WriteLine();
    }
}