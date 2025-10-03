using System;

// Abstract base class
abstract class Shape
{
	// Abstract method → no body, must be implemented in child classes
	public abstract double CalculateArea();

	// Normal method (optional, can be shared by all shapes)
	public void Display()
	{
		Console.WriteLine("This is a shape.");
	}
}

// Derived class: Circle
class Circle : Shape
{
	public double Radius;

	public Circle(double radius)
	{
		Radius = radius;
	}

	// Implement abstract method
	public override double CalculateArea()
	{
		return Math.PI * Radius * Radius;
	}
}

// Derived class: Rectangle
class Rectangle : Shape
{
	public double Length;
	public double Width;

	public Rectangle(double length, double width)
	{
		Length = length;
		Width = width;
	}

	// Implement abstract method
	public override double CalculateArea()
	{
		return Length * Width;
	}
}

class Program
{
	static void Main()
	{
		Shape circle = new Circle(5);
		Shape rectangle = new Rectangle(4, 6);

		circle.Display();
		Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

		rectangle.Display();
		Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
	}
}
