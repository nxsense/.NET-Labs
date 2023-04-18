namespace lab1.Models;

public class Address
{
    private int _id;
    private string _city;
    private string _street;
    private string _houseNumber;

    public Address(int id, string city, string street, string houseNumber)
    {
        _id = id;
        _city = city;
        _street = street;
        _houseNumber = houseNumber;
    }

    public string City
    {
        get => _city;
        set => _city = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Street
    {
        get => _street;
        set => _street = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string HouseNumber
    {
        get => _houseNumber;
        set => _houseNumber = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public override string ToString()
    {
        return $"{this.City}, {this.Street} {this.HouseNumber}";
    }
}