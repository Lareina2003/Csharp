using System;

class Student
{
	// const field ? must be assigned at declaration time
	public const string SchoolName = "ABC School";

	// readonly field ? can be assigned at declaration OR inside constructor
	public readonly int RollNumber;

	// Constructor to initialize readonly field
	public Student(int roll)
	{
		RollNumber = roll; // ? Allowed: readonly can be set in constructor
	}

	public void DisplayInfo(string name)
	{
		Console.WriteLine($"Name: {name}, Roll No: {RollNumber}, School: {SchoolName}");
	}
}

class Program
{
	static void Main()
	{
		// Create two students with different roll numbers
		Student s1 = new Student(101);
		Student s2 = new Student(102);

		s1.DisplayInfo("Alice");
		s2.DisplayInfo("Bob");

		// s1.RollNumber = 200;  // ? ERROR: readonly cannot be changed after constructor
		// Student.SchoolName = "XYZ School"; // ? ERROR: const cannot be changed
	}
}
