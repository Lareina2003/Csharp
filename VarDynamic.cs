using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== var Example ===");
        var number = 10;  // Compiler infers type int
        Console.WriteLine($"var number = {number} (Type: {number.GetType()})");
        // number = "Hello"; // ? Compile-time error: cannot assign string to int

        Console.WriteLine("\n=== dynamic Example ===");
        dynamic data = 10; // currently int
        Console.WriteLine($"dynamic data = {data} (Type: {data.GetType()})");

        data = "Hello";    // now string
        Console.WriteLine($"dynamic data = {data} (Type: {data.GetType()})");

        data = 3.14;       // now double
        Console.WriteLine($"dynamic data = {data} (Type: {data.GetType()})");
    }
}
