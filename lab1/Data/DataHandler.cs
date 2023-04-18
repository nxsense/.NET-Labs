using System.Collections;
using System.Collections.Immutable;
using lab1.Models;

namespace lab1.Data;

public class DataHandler:IDataHandler
{
    private readonly DataContext _dataContext;

    public DataHandler(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public IEnumerable<Vehicle> GetAllVehicles()
    {
        return _dataContext.Vehicles;
    }

    public IEnumerable<string> GetVehiclesByBrand(string brandName)
    {
        var vehicles = from vehicle in _dataContext.Vehicles
            join model in _dataContext.CarModel
                on vehicle.ModelId equals model.Id
            join brand in _dataContext.Brands
                on model.BrandId equals brand.Id
            where brand.Name == brandName
            select ($"Vehicle {vehicle} - Brand {brand.Name}");
        return vehicles;
    }

    public IEnumerable<Model> GetModelsListByYear()
    { var models = _dataContext.CarModel.OrderByDescending(model => model.Year)
            .ThenBy(model => model.ModelName);
        return models;
    }

    public IEnumerable<Person> GetFilteredPeopleListByBirthDate(string year)
    {
        return _dataContext.People.Where(person => person.BirthDate.Year > Convert.ToInt32(year));
    }

    public IEnumerable<Person> GetSortedPeopleListByBirthDate()
    {
        var people = _dataContext.People.OrderByDescending(person => person.BirthDate);
        return people;
    }

    public IEnumerable<string> GetBrandsAndCarModels()
    {
        var brandsAndModels = from model in _dataContext.CarModel
            join brand in _dataContext.Brands
                on model.BrandId equals brand.Id
            select $"Model: {model.ModelName} - Brand: {brand.Name}";
        return brandsAndModels;
    }

    public IEnumerable GetVehiclesAndOwners()
    {
        var brandsAndModels = from model in _dataContext.CarModel
            join brand in _dataContext.Brands
                on model.BrandId equals brand.Id
            select new
            {
                Id = model.Id, Brand = brand.Name, ModelName = model.ModelName, BodyType = model.BodyType,
                Manufacturer = brand.Manufacturer, Year = model.Year
            };
        var vehiclesAndModels = _dataContext.Vehicles.Join(brandsAndModels, vehicle => vehicle.ModelId,
            model => model.Id,
            (vehicle, model) =>
                new
                {
                    Id = vehicle.Id, Brand = model.Brand, Model = model.ModelName, BodyType = model.BodyType,
                    Manufacturer = model.Manufacturer, Year = model.Year, model, VINCode = vehicle.VinCode,
                    Color = vehicle.Color, License = vehicle.LicensePlate, Condition = vehicle.TechnicalCondition,
                    OwnerId = vehicle.CurrentOwnerId
                });
        var vehiclesAndOwners = vehiclesAndModels.Join(_dataContext.People, veihcle => veihcle.OwnerId,
            owner => owner.Id,
            (vehicle, owner) =>
                new
                {
                    Id = vehicle.Id,
                    Brand = vehicle.Brand,
                    Model = vehicle.Model,
                    OwnerName = owner.Name,
                    OwnerSurname = owner.Surname
                }).ToImmutableList();
        return vehiclesAndOwners;
    }

    public IEnumerable GetAllVehiclesInfo()
    {
        var brandsAndModels = from model in _dataContext.CarModel
            join brand in _dataContext.Brands
                on model.BrandId equals brand.Id
            select new
            {
                Id = model.Id, Brand = brand.Name, ModelName = model.ModelName, BodyType = model.BodyType,
                Manufacturer = brand.Manufacturer, Year = model.Year
            };
        var vehiclesAndModels = _dataContext.Vehicles.Join(brandsAndModels, vehicle => vehicle.ModelId,
            model => model.Id,
            (vehicle, model) =>
                new
                {
                    Id = vehicle.Id, Brand = model.Brand, Model = model.ModelName, BodyType = model.BodyType,
                    Manufacturer = model.Manufacturer, Year = model.Year, model, VINCode = vehicle.VinCode,
                    Color = vehicle.Color, License = vehicle.LicensePlate, Condition = vehicle.TechnicalCondition,
                    OwnerId = vehicle.CurrentOwnerId
                });
        return vehiclesAndModels;
    }

    public IEnumerable<Person> GetPeopleSurnameStartsWith(string letters)
    {
        var people = _dataContext.People.Where(person => person.Surname.StartsWith(letters)) 
                     ?? throw new ArgumentException($"No clients found for");
        return people;
    }

    public int AmountOfVehiclesMadeInCountryX(string country)
    {
        var brandsAndModels = from model in _dataContext.CarModel
            join brand in _dataContext.Brands
                on model.BrandId equals brand.Id
            select new
            {
                Id = model.Id, Brand = brand.Name, ModelName = model.ModelName, BodyType = model.BodyType,
                Manufacturer = brand.Manufacturer, Year = model.Year
            };
        var vehiclesAndModels = _dataContext.Vehicles.Join(brandsAndModels, vehicle => vehicle.ModelId,
            model => model.Id,
            (vehicle, model) =>
                new
                {
                    Id = vehicle.Id, Brand = model.Brand, Model = model.ModelName, BodyType = model.BodyType,
                    Manufacturer = model.Manufacturer, Year = model.Year, model, VINCode = vehicle.VinCode,
                    Color = vehicle.Color, License = vehicle.LicensePlate, Condition = vehicle.TechnicalCondition,
                    OwnerId = vehicle.CurrentOwnerId
                });
        return vehiclesAndModels.Count(vehicle => vehicle.Manufacturer == country);
    }

    public double GetAveragePeoplesAge()
    {
        double age = _dataContext.People.Average(person => DateTime.Now.Year - person.BirthDate.Year);
        return age;
    }

    public bool AnyDriverLivesOnStreetX(string street)
    {
        var drivresAndAddresses = _dataContext.People.Join(_dataContext.Addresses, person => person.AddressId,
            address => address.Id, (person, address) =>
                new
                {
                    Id = person.Id,
                    AddressId = address.Id,
                    City = address.City,
                    Street = address.Street,
                    HouseNumber = address.HouseNumber
                });
        bool res = drivresAndAddresses.Any(address => address.Street == street);
        return res;
    }

    public IEnumerable ConcatenateTwoLists()
    {
        return _dataContext.Vehicles.Concat(_dataContext.Vehicles);
    }

    public IEnumerable ConcatenateTwoListsWithoutRepeating()
    {
        return _dataContext.Vehicles.Union(_dataContext.Vehicles);
    }

    public IEnumerable<Person> GetTopNDriversByAlphabet(int amount)
    {
        var drivers = _dataContext.People.OrderBy(driver => driver.Surname)
            .Take(amount);
        return drivers;
    }

    public IEnumerable GetAmountOfEachCarOwners()
    {
        var carOwnersCount = from cars in _dataContext.Vehicles
            join owner in _dataContext.Drivers on cars.Id equals owner.VehicleId
            group owner by cars into carGroup
            select new { Car = carGroup.Key, OwnersCount = carGroup.Count() };
        return carOwnersCount;
    }

    public IEnumerable GetAmountOfCarsEachDriverHas()
    {
        var ownerCarCount = from owner in _dataContext.People
            join carOwner in _dataContext.Drivers on owner.Id equals carOwner.PersonId
            group carOwner by owner into ownerGroup
            select new { Owner = ownerGroup.Key, CarCount = ownerGroup.Count() };
        return ownerCarCount;
    }

    public IEnumerable GetTopOfOwnersOfCars()
    {
        var topOwners = from owner in _dataContext.People
            join carOwner in _dataContext.Drivers on owner.Id equals carOwner.PersonId
            group owner by owner into ownerGroup
            orderby ownerGroup.Count() descending
            select new { Owner = ownerGroup.Key, CarCount = ownerGroup.Count() };
        return topOwners;
    }

    public double GetAverageVehicleCondition()
    {
        double res =_dataContext.Vehicles.Count(vehicle => vehicle.TechnicalCondition == TechnicalCondition.Satisfactory)/_dataContext.Vehicles.Count;
        return res;
    }

    public int GetNumberOfRegisteredCars()
    {
        return _dataContext.Vehicles.Count;
    }


    public void Print<T>(IEnumerable<T> data)
    {
        foreach (var element in data)
        {
            Console.WriteLine(element);
        }
    }

    public void Print(IEnumerable data)
    {
        foreach (var e in data)
        {
            Console.WriteLine(e);
        }
    }
}