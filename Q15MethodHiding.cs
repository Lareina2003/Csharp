using System;

class BaseClass
{
    public void Display()
    {
        Console.WriteLine("Display method from BaseClass");
    }
}

class DerivedClass : BaseClass
{
    // Hides the base class method
    public new void Display()
    {
        Console.WriteLine("Display method from DerivedClass");
    }
}

class Program
{
    static void Main()
    {
        BaseClass baseObj = new BaseClass();
        baseObj.Display();  // Calls BaseClass method

        DerivedClass derivedObj = new DerivedClass();
        derivedObj.Display();  // Calls DerivedClass method

        BaseClass obj = new DerivedClass();
        obj.Display();  // Calls BaseClass method because reference is BaseClass
    }
}
