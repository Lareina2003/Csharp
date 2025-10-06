using System;
using System.Collections.Generic;

// Step 1: Define Observer interface
public interface ISubscriber
{
    void Update(string message);
}

// Step 2: Concrete Subscribers
public class EmailSubscriber : ISubscriber
{
    private string _name;
    public EmailSubscriber(string name) => _name = name;

    public void Update(string message)
    {
        Console.WriteLine($"{_name} received Email: {message}");
    }
}

public class SmsSubscriber : ISubscriber
{
    private string _name;
    public SmsSubscriber(string name) => _name = name;

    public void Update(string message)
    {
        Console.WriteLine($"{_name} received SMS: {message}");
    }
}

// Step 3: Publisher (Subject)
public class Publisher
{
    private List<ISubscriber> subscribers = new List<ISubscriber>();

    // Add subscriber
    public void Subscribe(ISubscriber subscriber)
    {
        subscribers.Add(subscriber);
        Console.WriteLine("Subscriber added.");
    }

    // Remove subscriber
    public void Unsubscribe(ISubscriber subscriber)
    {
        subscribers.Remove(subscriber);
        Console.WriteLine("Subscriber removed.");
    }

    // Notify all subscribers
    public void Notify(string message)
    {
        foreach (var sub in subscribers)
        {
            sub.Update(message);
        }
    }
}

// Step 4: Test the Observer Pattern
class Program
{
    static void Main()
    {
        Publisher newsChannel = new Publisher();

        // Subscribers
        ISubscriber s1 = new EmailSubscriber("Arun");
        ISubscriber s2 = new SmsSubscriber("Kumar");
        ISubscriber s3 = new EmailSubscriber("Latha");

        // Subscribe them
        newsChannel.Subscribe(s1);
        newsChannel.Subscribe(s2);
        newsChannel.Subscribe(s3);

        Console.WriteLine("\n--- Sending News Update ---");
        newsChannel.Notify("Breaking News: IPO opens tomorrow!");

        // Unsubscribe one
        newsChannel.Unsubscribe(s2);

        Console.WriteLine("\n--- Sending Another Update ---");
        newsChannel.Notify("Update: IPO oversubscribed 5x!");

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
