using System;

// Define a namespace
namespace MyApplication
{
    // Class inside the namespace
    class Student
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Hello! I am a student.");
        }
    }
}

// Another namespace
namespace DemoApp
{
    class Program
    {
        static void Main()
        {
            // To use Student class, we need the namespace name
            MyApplication.Student s1 = new MyApplication.Student();
            s1.DisplayInfo();
        }
    }
}
