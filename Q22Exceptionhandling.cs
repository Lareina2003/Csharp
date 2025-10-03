using System;

// Define a custom exception
public class InvalidSalaryException : Exception
{
    public InvalidSalaryException(string message) : base(message) { }
}

public class Employee
{
    public string Name { get; set; }
    private double salary;

    public double Salary
    {
        get => salary;
        set
        {
            if (value < 0)
            {
                // Throw custom exception if salary is negative
                throw new InvalidSalaryException("Salary cannot be negative!");
            }
            salary = value;
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Employee emp = new Employee();
            emp.Name = "Alice";

            // This will throw our custom exception
            emp.Salary = -5000;

            Console.WriteLine($"Employee Salary: {emp.Salary}");
        }
        catch (InvalidSalaryException ex)
        {
            Console.WriteLine($"Custom Exception Caught: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General Exception Caught: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block executed: Cleanup if necessary.");
        }

        Console.WriteLine("Program continues after exception handling.");
    }
}
