using lab1.Data;

namespace lab1;

public class Program
{
    private static readonly DataContext DataContext = new DataContext();
    private static readonly DataInitializer DataInitializer = new DataInitializer(DataContext);
    private static readonly IDataHandler DataHandler = new DataHandler(DataContext);
    public static void Main(string[] args)
    {
        DataInitializer.Initialize();
        DataInitializer.DisplayAllTables();
        InvokeAllCommands();
    }

    private static void InvokeAllCommands()
    {
        Console.WriteLine("1. Get all vehicles list:");
        DataHandler.Print(DataHandler.GetAllVehicles());
        Console.WriteLine();
        
        Console.WriteLine("2. Get all vehicles by certain brand:");
        DataHandler.Print(DataHandler.GetVehiclesByBrand("Tesla"));
        Console.WriteLine();
        
        Console.WriteLine("3. Get vehicles sorted by year:");
        DataHandler.Print(DataHandler.GetModelsListByYear());
        Console.WriteLine();
        
        Console.WriteLine("4. Get people filtered by their birth date:");
        DataHandler.Print(DataHandler.GetFilteredPeopleListByBirthDate("1990"));
        Console.WriteLine();
        
        Console.WriteLine("5. Get people sorted by their birth date:");
        DataHandler.Print(DataHandler.GetSortedPeopleListByBirthDate());
        Console.WriteLine();
        
        Console.WriteLine("6. Get joined brands and models:");
        DataHandler.Print(DataHandler.GetBrandsAndCarModels());
        Console.WriteLine();
        
        Console.WriteLine("7. Get vehicles and their owners:");
        DataHandler.Print(DataHandler.GetVehiclesAndOwners());
        Console.WriteLine();
        
        Console.WriteLine("8. Get all information about vehicle:");
        DataHandler.Print(DataHandler.GetAllVehiclesInfo());
        Console.WriteLine();
        
        Console.WriteLine("9. Get people, whose surname starts with certain letters:");
        DataHandler.Print(DataHandler.GetPeopleSurnameStartsWith("Ga"));
        Console.WriteLine();
        
        Console.WriteLine("10. Get amount of vehicles made in country X:");
        Console.WriteLine(DataHandler.AmountOfVehiclesMadeInCountryX("USA"));
        Console.WriteLine();
        
        Console.WriteLine("11. Average age of people:");
        Console.WriteLine(DataHandler.GetAveragePeoplesAge());
        Console.WriteLine();
        
        Console.WriteLine("12. If any of drivers lives on street X:");
        Console.WriteLine(DataHandler.AnyDriverLivesOnStreetX("Akademika Yanhelia"));
        Console.WriteLine();
        
        Console.WriteLine("13. Concatenate two lists of cars: ");
        DataHandler.Print(DataHandler.ConcatenateTwoLists());
        Console.WriteLine();
        
        Console.WriteLine("14. Concatenate two lists of cars without repeating: ");
        DataHandler.Print(DataHandler.ConcatenateTwoListsWithoutRepeating());
        Console.WriteLine();
        
        Console.WriteLine("15. Get top N drivers by alphabet: ");
        DataHandler.Print(DataHandler.GetTopNDriversByAlphabet(3));
        Console.WriteLine();
        
        Console.WriteLine("16. Get amount of each car owner`s: ");
        DataHandler.Print(DataHandler.GetAmountOfEachCarOwners());
        Console.WriteLine();
        
        Console.WriteLine("17. Get amount of cars each driver has: ");
        DataHandler.Print(DataHandler.GetAmountOfCarsEachDriverHas());
        Console.WriteLine();
        
        Console.WriteLine("18. Get top of owners of cars: ");
        DataHandler.Print(DataHandler.GetTopOfOwnersOfCars());
        Console.WriteLine();
        
        Console.WriteLine("19. Get average vehicle`s condition:");
        Console.WriteLine(DataHandler.GetAverageVehicleCondition());
        Console.WriteLine();
        
        Console.WriteLine("20. Get number of registered cars:");
        Console.WriteLine(DataHandler.GetNumberOfRegisteredCars());
        
    }
}
