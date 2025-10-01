using System;

enum Colors { Red, Green, Blue } // Enum (value type)

class Person // Reference type
{
	public string Name;
}

class Program
{
	static void Main()
	{
		// Value type example
		int a = 10;
		int b = a; 
		b = 20;
		Console.WriteLine($"a = {a}, b = {b}"); // a = 10, b = 20

		// Enum example
		Colors color1 = Colors.Green;
		Colors color2 = color1; 
		color2 = Colors.Blue;
		Console.WriteLine($"color1 = {color1}, color2 = {color2}"); // color1 = Green, color2 = Blue

		// Reference type example
		Person p1 = new Person { Name = "Alice" };
		Person p2 = p1; // same reference
		p2.Name = "Bob";
		Console.WriteLine($"p1.Name = {p1.Name}, p2.Name = {p2.Name}"); // both = Bob
	}
}
