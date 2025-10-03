using System;

// Step 1: Declare a delegate
delegate double MathOperation(double a, double b);

class Program
{
    // Step 2: Methods that match the delegate signature
    static double Add(double x, double y)
    {
        return x + y;
    }

    static double Subtract(double x, double y)
    {
        return x - y;
    }

    static double Multiply(double x, double y)
    {
        return x * y;
    }

    static double Divide(double x, double y)
    {
        if (y != 0)
            return x / y;
        else
        {
            Console.WriteLine("Cannot divide by zero!");
            return 0;
        }
    }

    static void Main()
    {
        // Step 3: Create delegate instances
        MathOperation op;

        // Using delegate for Addition
        op = Add;
        Console.WriteLine("Add: " + op(10, 5));

        // Using delegate for Subtraction
        op = Subtract;
        Console.WriteLine("Subtract: " + op(10, 5));

        // Using delegate for Multiplication
        op = Multiply;
        Console.WriteLine("Multiply: " + op(10, 5));

        // Using delegate for Division
        op = Divide;
        Console.WriteLine("Divide: " + op(10, 5));
    }
}
