using System;

// Step 1: Product Interface
public interface ICreditCard
{
	string GetCardType();
	int GetCreditLimit();
	int GetAnnualCharge();
}

// Step 2: Concrete Products
public class SilverCard : ICreditCard
{
	public string GetCardType() => "Silver Card";
	public int GetCreditLimit() => 50000;
	public int GetAnnualCharge() => 1000;
}

public class GoldCard : ICreditCard
{
	public string GetCardType() => "Gold Card";
	public int GetCreditLimit() => 100000;
	public int GetAnnualCharge() => 2000;
}

public class PlatinumCard : ICreditCard
{
	public string GetCardType() => "Platinum Card";
	public int GetCreditLimit() => 200000;
	public int GetAnnualCharge() => 3000;
}

// Step 3: Creator (Factory) Abstract Class
public abstract class CreditCardFactory
{
	public abstract ICreditCard CreateCard();
}

// Step 4: Concrete Factories
public class SilverFactory : CreditCardFactory
{
	public override ICreditCard CreateCard() => new SilverCard();
}

public class GoldFactory : CreditCardFactory
{
	public override ICreditCard CreateCard() => new GoldCard();
}

public class PlatinumFactory : CreditCardFactory
{
	public override ICreditCard CreateCard() => new PlatinumCard();
}

// Step 5: Client Code
class Program
{
	static void Main()
	{
		// Instead of "new SilverCard()", we use the Factory
		CreditCardFactory factory;

		factory = new SilverFactory();
		ICreditCard silver = factory.CreateCard();
		PrintCardDetails(silver);

		factory = new GoldFactory();
		ICreditCard gold = factory.CreateCard();
		PrintCardDetails(gold);

		factory = new PlatinumFactory();
		ICreditCard platinum = factory.CreateCard();
		PrintCardDetails(platinum);

		Console.WriteLine("\nPress Enter to exit...");
		Console.ReadLine(); //
	}

	static void PrintCardDetails(ICreditCard card)
	{
		Console.WriteLine($"Card Type: {card.GetCardType()}, " +
						  $"Limit: {card.GetCreditLimit()}, " +
						  $"Annual Charge: {card.GetAnnualCharge()}");
	}
}
