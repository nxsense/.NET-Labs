namespace lab1.Models;

public class Model
{
    private int _id;
    private int _brandId;
    private string _modelName;
    private BodyType _bodyType;
    private int _year;

    public Model(int id, int brandId, string modelName, BodyType bodyType, int year)
    {
        _id = id;
        _brandId = brandId;
        _modelName = modelName;
        _bodyType = bodyType;
        _year = year;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public int BrandId
    {
        get => _brandId;
        set => _brandId = value;
    }

    public string ModelName
    {
        get => _modelName;
        set => _modelName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public BodyType BodyType
    {
        get => _bodyType;
        set => _bodyType = value;
    }

    public int Year
    {
        get => _year;
        set => _year = value;
    }

    public override string ToString()
    {
        return $"{Id} {BrandId} {ModelName} {BodyType} {Year}";
    }
}