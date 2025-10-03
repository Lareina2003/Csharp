using System;

class BankAccount
{
    // Private field (cannot be accessed directly from outside)
    private double balance;

    // Constructor
    public BankAccount(double initialBalance)
    {
        if (initialBalance >= 0)
            balance = initialBalance;
        else
            balance = 0;
    }

    // Public method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive!");
        }
    }

    // Public method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}, Remaining Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance!");
        }
    }

    // Public method to check balance (only read, no modify)
    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(500);

        // balance cannot be accessed directly
        // account.balance = 1000;  // ❌ ERROR (private field)

        account.Deposit(200);      // ✅ Allowed
        account.Withdraw(100);     // ✅ Allowed
        Console.WriteLine($"Final Balance: {account.GetBalance()}");
    }
}
