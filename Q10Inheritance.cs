using System;

// Base Class
class Vehicle
{
    public string Brand;
    public int Speed;

    public void Start()
    {
        Console.WriteLine($"{Brand} started!");
    }

    public void Stop()
    {
        Console.WriteLine($"{Brand} stopped!");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}

// Derived Class 1
class Car : Vehicle
{
    public int Doors;

    public void ShowCarInfo()
    {
        ShowInfo();
        Console.WriteLine($"Doors: {Doors}");
    }
}

// Derived Class 2
class Bike : Vehicle
{
    public bool HasGear;

    public void ShowBikeInfo()
    {
        ShowInfo();
        Console.WriteLine($"Has Gear: {HasGear}");
    }
}

class Program
{
    static void Main()
    {
        // Create a Car object
        Car myCar = new Car();
        myCar.Brand = "Toyota";
        myCar.Speed = 180;
        myCar.Doors = 4;
        myCar.Start();
        myCar.ShowCarInfo();
        myCar.Stop();

        Console.WriteLine();

        // Create a Bike object
        Bike myBike = new Bike();
        myBike.Brand = "Yamaha";
        myBike.Speed = 120;
        myBike.HasGear = true;
        myBike.Start();
        myBike.ShowBikeInfo();
        myBike.Stop();
    }
}
