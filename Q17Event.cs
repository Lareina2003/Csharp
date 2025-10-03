using System;

// Step 1: Publisher
class AlarmClock
{
    // Declare a delegate for the event
    public delegate void AlarmEventHandler(string time);

    // Declare the event based on the delegate
    public event AlarmEventHandler Ring;

    // Method to trigger the alarm
    public void StartAlarm(string time)
    {
        Console.WriteLine($"Alarm set for {time}...");

        // Trigger the event
        OnRing(time);
    }

    // Protected virtual method to raise the event
    protected virtual void OnRing(string time)
    {
        if (Ring != null)  // Check if there are subscribers
        {
            Ring(time);  // Call all subscriber methods
        }
    }
}

// Step 2: Subscriber
class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    // Method to handle the alarm event
    public void WakeUp(string time)
    {
        Console.WriteLine($"{Name} is waking up! Alarm rang at {time}");
    }
}

class Program
{
    static void Main()
    {
        // Create publisher
        AlarmClock alarm = new AlarmClock();

        // Create subscribers
        Person alice = new Person("Alice");
        Person bob = new Person("Bob");

        // Subscribe to the event
        alarm.Ring += alice.WakeUp;
        alarm.Ring += bob.WakeUp;

        // Trigger the alarm
        alarm.StartAlarm("7:00 AM");
    }
}
