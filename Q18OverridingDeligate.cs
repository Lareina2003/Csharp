using System;

// Base class
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Derived class
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

// Delegate that matches Speak method signature
delegate void SpeakDelegate();

class Program
{
    static void Main()
    {
        // Base class object
        Animal a1 = new Animal();
        SpeakDelegate del1 = a1.Speak;
        del1();  // Output: Animal makes a sound

        // Derived class object
        Animal a2 = new Dog();
        SpeakDelegate del2 = a2.Speak;
        del2();  // Output: Dog barks → overridden method called
    }
}
