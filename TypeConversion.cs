using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Implicit Conversion ===");
        int num = 100;
        double d = num; // int ? double
        Console.WriteLine($"int {num} ? double {d}");

        Console.WriteLine("\n=== Explicit Conversion (Casting) ===");
        double pi = 9.78;
        int intPi = (int)pi; // double ? int
        Console.WriteLine($"double {pi} ? int {intPi}");

        Console.WriteLine("\n=== as Operator ===");
        object obj1 = "Hello World";
        string str1 = obj1 as string; // safe cast
        Console.WriteLine(str1);

        object obj2 = 123;
        string str2 = obj2 as string; // fails safely
        Console.WriteLine(str2 == null ? "Conversion failed" : str2);

        Console.WriteLine("\n=== is Operator ===");
        object obj3 = 456;
        if (obj3 is int)
        {
            int number = (int)obj3;
            Console.WriteLine($"obj3 is int: {number}");
        }
        else
        {
            Console.WriteLine("obj3 is not int");
        }

        Console.WriteLine("\n=== Convert Class ===");
        string strNum = "500";
        int num2 = Convert.ToInt32(strNum); // string ? int
        Console.WriteLine($"string '{strNum}' ? int {num2}");

        string strDouble = "12.34";
        double d2 = Convert.ToDouble(strDouble); // string ? double
        Console.WriteLine($"string '{strDouble}' ? double {d2}");

        bool boolValue = Convert.ToBoolean("true"); // string ? bool
        Console.WriteLine($"string 'true' ? bool {boolValue}");
    }
}
