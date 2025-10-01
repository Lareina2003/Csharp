using System;

class Program
{
    static void Main()
    {
        // Non-nullable type
        int nonNullable = 10;
        // nonNullable = null; // ? Not allowed

        // Nullable type using '?'
        int? nullableInt = null; // ? Can hold null
        Console.WriteLine($"Nullable before assignment: {nullableInt}");

        nullableInt = 25; // Assign a value
        Console.WriteLine($"Nullable after assignment: {nullableInt}");

        // Checking for null
        if (nullableInt.HasValue)
        {
            Console.WriteLine($"Nullable has value: {nullableInt.Value}");
        }
        else
        {
            Console.WriteLine("Nullable is null");
        }

        // Nullable reference type example (C# 8+)
        string? nullableString = null; // Can hold null
        string nonNullableString = "Hello"; // Cannot hold null
        Console.WriteLine($"Nullable string: {nullableString}");
        Console.WriteLine($"Non-nullable string: {nonNullableString}");
    }
}
