using System;
using System.Linq;
using System.Collections.Generic;


public interface IVehicle
{
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    void Start();
    void Stop();
}
public interface IsWheeled
{
    int Wheels { get; set; }
}
public interface ISeaCraft
{
    double MaxWaterSpeed { get; set; }
    void Sail();
}
public interface IAirCraft
{
    double MaxAirSpeed{ get; set; }
    bool Winged {get; set; }
    void Fly();
}
public interface ILandCraft
{
    double MaxLandSpeed { get; set; }
    void Drive();
}
public class JetSki : IVehicle, ISeaCraft
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Sail()
    {
        Console.WriteLine("Jetski moves along the water");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class CruiseShip : IVehicle, ISeaCraft
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Sail()
    {
        Console.WriteLine("Cruise Ship moves along the water");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Motorcycle : IVehicle, IsWheeled, ILandCraft
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxLandSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("Motercyle drives on the road");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class PickupTruck : IVehicle, IsWheeled, ILandCraft
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxLandSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("Truck drives on the road");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Cessna : IVehicle, IAirCraft, IsWheeled
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxAirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool Winged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Fly()
    {
        Console.WriteLine("Cessna flys through the air");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class Boing747 : IVehicle, IsWheeled, IAirCraft
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxAirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool Winged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Fly()
    {
        Console.WriteLine("747 flys through the air");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}


public class Program
{

    public static void Main() {

        Cessna myPlane = new Cessna();
        Boing747 myTransport = new Boing747();

        // Build a collection of all vehicles that fly
        List<IAirCraft> flyingVics = new List<IAirCraft>();
        flyingVics.Add(myPlane);
        flyingVics.Add(myTransport);

        // With a single `foreach`, have each vehicle Fly()
        foreach(var vic in flyingVics)
        {
            vic.Fly();
        }

        Motorcycle harly = new Motorcycle();
        PickupTruck f150 = new PickupTruck();

        // Build a collection of all vehicles that operate on roads
        List<ILandCraft> roadVics = new List<ILandCraft>
        {
            harly,
            f150
        };

        // With a single `foreach`, have each road vehicle Drive()
        foreach(var vic in roadVics)
        {
            vic.Drive();
        }

        Cessna privateJet = new Cessna();
        Boing747 passengerJet = new Boing747();
        // Build a collection of all vehicles that operate on water
        List<IAirCraft> airVics = new List<IAirCraft>();
        airVics.Add(privateJet);
        airVics.Add(passengerJet);
        // With a single `foreach`, have each water vehicle Drive()

        foreach(var vic in airVics)
        {
            vic.Fly();
        }
    }

}