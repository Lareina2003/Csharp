using System;

class MathOperations
{
    // Compile-time Polymorphism → Method Overloading
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Animal
{
    // Runtime Polymorphism → Method Overriding
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main()
    {
        // -------- Compile-time Polymorphism --------
        MathOperations math = new MathOperations();
        Console.WriteLine("Add(int,int): " + math.Add(5, 10));
        Console.WriteLine("Add(double,double): " + math.Add(2.5, 3.7));
        Console.WriteLine("Add(int,int,int): " + math.Add(1, 2, 3));

        Console.WriteLine();

        // -------- Runtime Polymorphism --------
        Animal a;

        a = new Dog();   // Object is Dog
        a.Speak();       // Dog barks

        a = new Cat();   // Object is Cat
        a.Speak();       // Cat meows
    }
}
