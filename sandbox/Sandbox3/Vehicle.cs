public class Vehicle
{
    private int _numberOfWheels;
    private int _numberOfDoors;
    private string _vehicleName;

    public Vehicle(int numberOfWheels, int numberOfDoors, string vehicleName)
    {
        _numberOfWheels = numberOfWheels;
        _numberOfDoors = numberOfDoors;
        _vehicleName = vehicleName;
    }

    public int GetNumberOfWheels()
    {
        return _numberOfWheels;
    }

    public int GetNumberOfDoors()
    {
        return _numberOfDoors;
    }

    public string GetVehicleName()
    {
        return _vehicleName;
    }

    public void DisplayVehicleInfo()
    {
        Console.WriteLine($"Your {_vehicleName} has {_numberOfDoors} doors and {_numberOfWheels} wheels.");
    }
}