using System;
using System.Collections.Generic;

// ---------------- Singleton ----------------
public class Logger
{
    private static Logger _instance;
    private Logger() { }

    public static Logger Instance => _instance ??= new Logger();

    public void Log(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}

// ---------------- Strategy ----------------
public interface INotificationSender
{
    void Send(string message, string recipient);
}

public class EmailSender : INotificationSender
{
    public void Send(string message, string recipient)
    {
        Console.WriteLine($"Email to {recipient}: {message}");
    }
}

public class SmsSender : INotificationSender
{
    public void Send(string message, string recipient)
    {
        Console.WriteLine($"SMS to {recipient}: {message}");
    }
}

// ---------------- Factory ----------------
public abstract class Notification
{
    protected INotificationSender _sender;
    public string Recipient { get; set; }
    public string Message { get; set; }

    public abstract void Notify();
}

public class EmailNotification : Notification
{
    public EmailNotification(INotificationSender sender)
    {
        _sender = sender;
    }

    public override void Notify()
    {
        _sender.Send(Message, Recipient);
        Logger.Instance.Log($"Email sent to {Recipient}");
    }
}

public class SmsNotification : Notification
{
    public SmsNotification(INotificationSender sender)
    {
        _sender = sender;
    }

    public override void Notify()
    {
        _sender.Send(Message, Recipient);
        Logger.Instance.Log($"SMS sent to {Recipient}");
    }
}

public class NotificationFactory
{
    public static Notification CreateNotification(string type, INotificationSender sender)
    {
        return type.ToLower() switch
        {
            "email" => new EmailNotification(sender),
            "sms" => new SmsNotification(sender),
            _ => throw new ArgumentException("Invalid notification type")
        };
    }
}

// ---------------- Observer ----------------
public class User
{
    public string Name { get; set; }
    public void Update(string message)
    {
        Console.WriteLine($"{Name} received notification: {message}");
    }
}

public class NotificationService
{
    private readonly List<User> _subscribers = new();

    public void Subscribe(User user) => _subscribers.Add(user);
    public void Unsubscribe(User user) => _subscribers.Remove(user);

    public void NotifyAll(string message)
    {
        foreach (var user in _subscribers)
        {
            user.Update(message);
        }
    }
}

// ---------------- Client ----------------
class Program
{
    static void Main()
    {
        // Strategy
        INotificationSender emailSender = new EmailSender();
        INotificationSender smsSender = new SmsSender();

        // Factory + Strategy
        var emailNotification = NotificationFactory.CreateNotification("email", emailSender);
        emailNotification.Recipient = "alice@example.com";
        emailNotification.Message = "Welcome Alice!";
        emailNotification.Notify();

        var smsNotification = NotificationFactory.CreateNotification("sms", smsSender);
        smsNotification.Recipient = "123-456-7890";
        smsNotification.Message = "Your OTP is 1234";
        smsNotification.Notify();

        // Observer
        var notificationService = new NotificationService();
        var user1 = new User { Name = "Bob" };
        var user2 = new User { Name = "Carol" };

        notificationService.Subscribe(user1);
        notificationService.Subscribe(user2);

        notificationService.NotifyAll("System maintenance at 10 PM");
    }
}
