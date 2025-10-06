using System;
using System.Collections.Generic;

// ---------------- Class with Property ----------------
public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Implement IComparable<T> to sort by Age
    public int CompareTo(Person other)
    {
        if (other == null) return 1;

        // Custom sorting: ascending by Age
        return this.Age.CompareTo(other.Age);
    }

    public override string ToString()
    {
        return $"{Name}, Age: {Age}";
    }
}

// ---------------- Program ----------------
class Program
{
    static void Main()
    {
        // Create a few Person objects
        List<Person> people = new List<Person>
        {
            new Person("Alice", 30),
            new Person("Bob", 25),
            new Person("Charlie", 35),
            new Person("Diana", 28)
        };

        Console.WriteLine("Before Sorting:");
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }

        // Sort using IComparable<Person>
        people.Sort();

        Console.WriteLine("\nAfter Sorting by Age (ascending):");
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
    }
}
