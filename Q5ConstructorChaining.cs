using System;

class Student
{
    // Fields
    private string name;
    private int age;

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Constructor 1: Default
    public Student() : this("Unknown", 18) // Constructor chaining
    {
        Console.WriteLine("Default constructor called");
    }

    // Constructor 2: Only name
    public Student(string name) : this(name, 18) // Chaining to full constructor
    {
        Console.WriteLine("Constructor with name called");
    }

    // Constructor 3: Name and Age
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
        Console.WriteLine("Constructor with name and age called");
    }

    // Method 1: Display student info
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    // Method 2: Overloaded method with greeting
    public void DisplayInfo(string greeting)
    {
        Console.WriteLine($"{greeting}, Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Default Constructor ===");
        Student student1 = new Student();
        student1.DisplayInfo();
        student1.DisplayInfo("Hello");

        Console.WriteLine("\n=== Constructor with Name ===");
        Student student2 = new Student("Alice");
        student2.DisplayInfo();
        student2.DisplayInfo("Hi");

        Console.WriteLine("\n=== Constructor with Name and Age ===");
        Student student3 = new Student("Bob", 20);
        student3.DisplayInfo();
        student3.DisplayInfo("Welcome");
    }
}
