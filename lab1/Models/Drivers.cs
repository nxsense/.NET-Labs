namespace lab1.Models;

public class Drivers
{
    private int _id;
    private int _personId;
    private int _vehicleId;

    public Drivers(int id, int personId, int vehicleId)
    {
        _id = id;
        _personId = personId;
        _vehicleId = vehicleId;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public int PersonId
    {
        get => _personId;
        set => _personId = value;
    }

    public int VehicleId
    {
        get => _vehicleId;
        set => _vehicleId = value;
    }

    public override string ToString()
    {
        return $"{Id} {PersonId} {VehicleId}";
    }
}