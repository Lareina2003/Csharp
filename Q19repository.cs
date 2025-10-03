using System;
using System.Collections.Generic;
using System.Linq;

public class Repository<T> where T : class
{
    private readonly List<T> _items = new List<T>();

    public void Add(T item)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item));
        _items.Add(item);
    }

    public void Update(T oldItem, T newItem)
    {
        if (oldItem == null || newItem == null)
            throw new ArgumentNullException("Items cannot be null");

        int index = _items.IndexOf(oldItem);
        if (index == -1)
            throw new InvalidOperationException("Item not found");

        _items[index] = newItem;
    }

    public void Delete(T item)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item));
        _items.Remove(item);
    }

    public List<T> GetAll()
    {
        return _items.ToList();
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Program
{
    // Main must be static
    public static void Main(string[] args)
    {
        var userRepository = new Repository<User>();

        var user1 = new User { Id = 1, Name = "Alice" };
        var user2 = new User { Id = 2, Name = "Bob" };

        userRepository.Add(user1);
        userRepository.Add(user2);

        Console.WriteLine("All users:");
        foreach (var user in userRepository.GetAll())
        {
            Console.WriteLine($"{user.Id}: {user.Name}");
        }

        var updatedUser = new User { Id = 1, Name = "Alice Smith" };
        userRepository.Update(user1, updatedUser);

        userRepository.Delete(user2);

        Console.WriteLine("After update and delete:");
        foreach (var user in userRepository.GetAll())
        {
            Console.WriteLine($"{user.Id}: {user.Name}");
        }
    }
}
