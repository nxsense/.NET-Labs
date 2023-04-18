namespace lab1.Models;

public class Person
{
    private int _id;
    private string _driverLicenseNumber;
    private string _surname;
    private string _name;
    private string _patronymic;
    private DateOnly _birthDate;
    private int _addressId;

    public Person(int id, string driverLicenseNumber, string surname, string name, string patronimic,
        DateOnly birthDate, int addressId)
    {
        _id = id;
        _driverLicenseNumber = driverLicenseNumber ?? throw new ArgumentNullException(nameof(driverLicenseNumber));
        _surname = surname ?? throw new ArgumentNullException(nameof(surname));
        _name = name ?? throw new ArgumentNullException(nameof(name));
        _patronymic = patronimic ?? throw new ArgumentNullException(nameof(patronimic));
        _birthDate = birthDate;
        _addressId = addressId;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string DriverLicenseNumber
    {
        get => _driverLicenseNumber;
        set => _driverLicenseNumber = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Surname
    {
        get => _surname;
        set => _surname = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Patronymic
    {
        get => _patronymic;
        set => _patronymic = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DateOnly BirthDate
    {
        get => _birthDate;
        set => _birthDate = value;
    }

    public int AddressId
    {
        get => _addressId;
        set => _addressId = value;
    }

    public override string ToString()
    {
        return $"{Id} {DriverLicenseNumber} {Surname} {Name} {Patronymic} {BirthDate} {AddressId}";
    }
}