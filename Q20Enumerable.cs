using System;
using System.Collections.Generic;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class UserRepository
{
    private readonly List<User> _users = new List<User>();

    public void Add(User user)
    {
        _users.Add(user);
    }

    // Return all users using yield
    public IEnumerable<User> GetAllUsers()
    {
        foreach (var user in _users)
        {
            yield return user; // returns one user at a time
        }
    }

    // Return users with name containing specific text
    public IEnumerable<User> GetUsersByName(string name)
    {
        foreach (var user in _users)
        {
            if (user.Name.Contains(name))
            {
                yield return user;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        var repo = new UserRepository();
        repo.Add(new User { Id = 1, Name = "Alice" });
        repo.Add(new User { Id = 2, Name = "Bob" });
        repo.Add(new User { Id = 3, Name = "Alicia" });

        Console.WriteLine("All Users:");
        foreach (var user in repo.GetAllUsers())
        {
            Console.WriteLine($"{user.Id}: {user.Name}");
        }

        Console.WriteLine("\nUsers with 'Ali' in name:");
        foreach (var user in repo.GetUsersByName("Ali"))
        {
            Console.WriteLine($"{user.Id}: {user.Name}");
        }
    }
}
