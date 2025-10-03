using System;

// Base class
class Vehicle
{
    // Virtual method ? can be overridden in derived classes
    public virtual void Start()
    {
        Console.WriteLine("Vehicle is starting...");
    }
}

// Derived class 1
class Car : Vehicle
{
    // Override the Start method
    public override void Start()
    {
        Console.WriteLine("Car is starting with a key ignition...");
    }
}

// Derived class 2
class SportsCar : Car
{
    // Sealed override ? cannot be overridden further
    public sealed override void Start()
    {
        Console.WriteLine("SportsCar is starting with push button start!");
    }
}

// Derived class 3
class ElectricSportsCar : SportsCar
{
    // ? This will cause error if we try to override Start again
    // public override void Start() { ... }  // Not allowed because it's sealed
}

class Program
{
    static void Main()
    {
        Vehicle v = new Vehicle();
        v.Start();   // Vehicle is starting...

        Car c = new Car();
        c.Start();   // Car is starting with a key ignition...

        SportsCar sc = new SportsCar();
        sc.Start();  // SportsCar is starting with push button start!
    }
}
