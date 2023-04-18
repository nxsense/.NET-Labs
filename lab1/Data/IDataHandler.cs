using System.Collections;
using lab1.Models;

namespace lab1.Data;

public interface IDataHandler
{
    IEnumerable<Vehicle> GetAllVehicles();
    IEnumerable<string> GetVehiclesByBrand(string brandName);
    IEnumerable<Person> GetFilteredPeopleListByBirthDate(string year);
    IEnumerable<Model> GetModelsListByYear();
    IEnumerable<Person> GetSortedPeopleListByBirthDate();
    IEnumerable<string> GetBrandsAndCarModels();
    IEnumerable GetVehiclesAndOwners();
    IEnumerable GetAllVehiclesInfo();
    IEnumerable<Person> GetPeopleSurnameStartsWith(string letters);
    int AmountOfVehiclesMadeInCountryX(string country);
    double GetAveragePeoplesAge();
    bool AnyDriverLivesOnStreetX(string street);
    IEnumerable ConcatenateTwoLists();
    IEnumerable ConcatenateTwoListsWithoutRepeating();
    IEnumerable<Person> GetTopNDriversByAlphabet(int amount);
    IEnumerable GetAmountOfEachCarOwners();
    IEnumerable GetAmountOfCarsEachDriverHas();
    IEnumerable GetTopOfOwnersOfCars();
    double GetAverageVehicleCondition();
    int GetNumberOfRegisteredCars();

    void Print<T>(IEnumerable<T> data);
    void Print(IEnumerable data);

}