namespace lab1.Models;

public class Brand
{
    private int _id;
    private string _name;
    private string _manufacturer;

    public Brand(int id, string name, string manufacturer)
    {
        _id = id;
        _name = name;
        _manufacturer = manufacturer;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Manufacturer
    {
        get => _manufacturer;
        set => _manufacturer = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return $"Brand: {Id} {Name} {Manufacturer}";
    }
}