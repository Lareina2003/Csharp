using System;

class BaseClass
{
    // Different access modifiers
    public string PublicField = "I am PUBLIC (anyone can access me)";
    private string PrivateField = "I am PRIVATE (only inside this class)";
    protected string ProtectedField = "I am PROTECTED (Base + Derived class)";
    internal string InternalField = "I am INTERNAL (any class in same assembly)";

    public void ShowFields()
    {
        Console.WriteLine("Base Class");
        Console.WriteLine(PublicField);
        Console.WriteLine(PrivateField);
        Console.WriteLine(ProtectedField);
        Console.WriteLine(InternalField);
    }
}

// Derived class (can access protected members)
class DerivedClass : BaseClass
{
    public void ShowDerived()
    {
        Console.WriteLine("Derived Class:");
        Console.WriteLine(PublicField);      // ? Allowed
        // Console.WriteLine(PrivateField);  // ? Not allowed
        Console.WriteLine(ProtectedField);   // ? Allowed
        Console.WriteLine(InternalField);    // ? Allowed (same assembly)
    }
}

// Another class in same assembly
class OtherClass
{
    public void ShowOther()
    {
        Console.WriteLine("Other Class:");
        BaseClass obj = new BaseClass();
        Console.WriteLine("From Other Class:");
        Console.WriteLine(obj.PublicField);     // ? Allowed
        // Console.WriteLine(obj.PrivateField); // ? Not allowed
        // Console.WriteLine(obj.ProtectedField);// ? Not allowed
        Console.WriteLine(obj.InternalField);   // ? Allowed (same assembly)
    }
}

class Program
{
    static void Main()
    {
        BaseClass baseObj = new BaseClass();
        Console.WriteLine("From Base Class method:");
        baseObj.ShowFields();

        DerivedClass derivedObj = new DerivedClass();
        derivedObj.ShowDerived();

        OtherClass otherObj = new OtherClass();
        otherObj.ShowOther();
    }
}
