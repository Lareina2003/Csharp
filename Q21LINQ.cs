using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 5000 },
            new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 7000 },
            new Employee { Id = 3, Name = "Charlie", Department = "HR", Salary = 5500 },
            new Employee { Id = 4, Name = "David", Department = "IT", Salary = 8000 },
            new Employee { Id = 5, Name = "Eva", Department = "Finance", Salary = 6000 }
        };

        // 1. Filter: Employees with salary > 6000
        var highSalary = employees.Where(e => e.Salary > 6000);

        Console.WriteLine("Employees with salary > 6000:");
        foreach (var emp in highSalary)
            Console.WriteLine($"{emp.Name} - {emp.Salary}");

        // 2. Group: Employees by Department
        var groupByDept = employees.GroupBy(e => e.Department);

        Console.WriteLine("\nEmployees grouped by Department:");
        foreach (var group in groupByDept)
        {
            Console.WriteLine($"Department: {group.Key}");
            foreach (var emp in group)
                Console.WriteLine($"  {emp.Name}");
        }

        // 3. Order: Employees by Salary descending
        var ordered = employees.OrderByDescending(e => e.Salary);

        Console.WriteLine("\nEmployees ordered by Salary descending:");
        foreach (var emp in ordered)
            Console.WriteLine($"{emp.Name} - {emp.Salary}");

        // 4. Select: Project employee names and departments
        var projection = employees.Select(e => new { e.Name, e.Department });

        Console.WriteLine("\nEmployee names and departments:");
        foreach (var emp in projection)
            Console.WriteLine($"{emp.Name} - {emp.Department}");
    }
}
