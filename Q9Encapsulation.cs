using System;
class bankaccount
{
	private double balance;

	public bankaccount(double initialbalance)
	{
		if(initialbalance >= 0)
		{
			balance = initialbalance;
		}
		else
		{
			balance = 0;
		}
	}
	public void deposit(double amount)
	{
		balance += amount;
		Console.WriteLine($"Deposited; {amount},New Balance{balance}");
	}
	public void Withdraw(double amount)
	{
		if (amount > 0 && amount <= balance)
		{
			balance -= amount;
			Console.WriteLine($"Withdraw;{amount},New Balance:{balance}");
		}
		else
		{
			Console.WriteLine("Invalid Withdrawal amount or Insufficient Bank Balance");
		}
	}
		public double getbalance()
		{
			return balance;
		}
	}
	class Program
	{
		static void Main()
		{
			bankaccount account = new bankaccount(500);
			account.Withdraw(100);
			account.deposit(200);
		Console.WriteLine($"Final Balance:{account.getbalance()}");
		}
	}
