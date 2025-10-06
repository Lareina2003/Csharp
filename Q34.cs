using System;

namespace Demo
{
    // ---------------- Interface ----------------
    // Defines a contract: any class implementing it must provide an implementation.
    public interface IShape
    {
        double Area(); // Must be implemented
    }

    // ---------------- Abstract Class ----------------
    // Can provide common implementation + force derived classes to implement some methods
    public abstract class ShapeBase : IShape
    {
        public string Name { get; set; }

        // Abstract method: must be implemented in derived class
        public abstract double Area();

        // Instance method: can use object state
        public void Display()
        {
            Console.WriteLine($"{Name} has area {Area()}");
        }

        // Static method: belongs to class, not object
        public static void Info()
        {
            Console.WriteLine("Shapes are geometric objects with area.");
        }
    }

    // ---------------- Concrete Class ----------------
    public class Circle : ShapeBase
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            Name = "Circle";
        }

        // Implement abstract method
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : ShapeBase
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
            Name = "Rectangle";
        }

        public override double Area()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main()
        {
            // ---------------- Interface usage ----------------
            IShape circleShape = new Circle(5);
            IShape rectangleShape = new Rectangle(4, 6);

            Console.WriteLine($"Circle area (via interface): {circleShape.Area()}");
            Console.WriteLine($"Rectangle area (via interface): {rectangleShape.Area()}");

            // ---------------- Abstract class usage ----------------
            Circle circle = new Circle(3);
            Rectangle rectangle = new Rectangle(2, 5);

            circle.Display();      // Instance method
            rectangle.Display();   // Instance method

            ShapeBase.Info();      // Static method
        }
    }
}
