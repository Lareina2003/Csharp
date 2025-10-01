using System;

namespace IdentifierExample
{
    // 'Student' is a class identifier
    class Student
    {
        // 'name' and 'age' are field identifiers
        private string name;
        private int age;

        // Constructor (Student is also used here as identifier)
        public Student(string studentName, int studentAge)
        {
            // 'studentName' and 'studentAge' are parameter identifiers
            name = studentName;
            age = studentAge;
        }

        // 'DisplayInfo' is a method identifier
        public void DisplayInfo()
        {
            Console.WriteLine("Student Name: " + name + "\n");
            Console.WriteLine("Student Age: " + age + "\n");
        }
    }

    class Program
    {
        static void Main()
        {
            // 's1' is an object identifier
            Student s1 = new Student("Alice", 20);
            s1.DisplayInfo();
        }
    }
}
