using System;

// Part 1 of the partial class
public partial class Student
{
	public string Name;

	// Declare a partial method (no body here)
	partial void ShowSecret();

	// Normal method that will call the partial method
	public void Display()
	{
		Console.WriteLine($"Student Name: {Name}");
		ShowSecret(); // Will call the partial method (if implemented)
	}
}

// Part 2 of the partial class
public partial class Student
{
	// Implement the partial method here
	partial void ShowSecret()
	{
		Console.WriteLine("This is a secret message from the partial method!");
	}
}

class Program
{
	static void Main()
	{
		Student s1 = new Student();
		s1.Name = "Alice";
		s1.Display();
	}
}
