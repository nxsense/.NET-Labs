namespace lab1.Models;

public class Vehicle
{
    private int _id;
    private int _modelId;
    private string _vinCode;
    private string _licensePlate;
    private string _color;
    private TechnicalCondition _technicalCondition;
    private int _currentOwnerId;

    public Vehicle(int id, int modelId, string vinCode, string licensePlate, string color, TechnicalCondition technicalCondition, int currentOwnerId)
    {
        _id = id;
        _modelId = modelId;
        _vinCode = vinCode;
        _licensePlate = licensePlate;
        _color = color;
        _technicalCondition = technicalCondition;
        _currentOwnerId = currentOwnerId;
    }

    public int ModelId
    {
        get => _modelId;
        set => _modelId = value;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string VinCode
    {
        get => _vinCode;
        set => _vinCode = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string LicensePlate
    {
        get => _licensePlate;
        set => _licensePlate = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Color
    {
        get => _color;
        set => _color = value ?? throw new ArgumentNullException(nameof(value));
    }

    public TechnicalCondition TechnicalCondition
    {
        get => _technicalCondition;
        set => _technicalCondition = value;
    }

    public int CurrentOwnerId
    {
        get => _currentOwnerId;
        set => _currentOwnerId = value;
    }

    public override string ToString()
    {
        return $"{Id} {ModelId} {VinCode} {LicensePlate} {Color} {TechnicalCondition} {CurrentOwnerId}";
    }
}