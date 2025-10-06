using System;

// Step 1: Define Strategy interface
public interface IPaymentStrategy
{
    void Pay(int amount);
}

// Step 2: Concrete Strategies
public class CreditCardPayment : IPaymentStrategy
{
    private string cardNumber;
    public CreditCardPayment(string cardNumber)
    {
        this.cardNumber = cardNumber;
    }

    public void Pay(int amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card [{cardNumber}]");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    private string email;
    public PayPalPayment(string email)
    {
        this.email = email;
    }

    public void Pay(int amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal [{email}]");
    }
}

public class UpiPayment : IPaymentStrategy
{
    private string upiId;
    public UpiPayment(string upiId)
    {
        this.upiId = upiId;
    }

    public void Pay(int amount)
    {
        Console.WriteLine($"Paid {amount} using UPI [{upiId}]");
    }
}

// Step 3: Context (uses a strategy)
public class ShoppingCart
{
    private IPaymentStrategy paymentStrategy;

    // Set strategy at runtime
    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        paymentStrategy = strategy;
    }

    public void Checkout(int amount)
    {
        if (paymentStrategy == null)
        {
            Console.WriteLine("No payment method selected!");
            return;
        }

        paymentStrategy.Pay(amount);
    }
}

// Step 4: Test
class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        // Choose strategy at runtime
        cart.SetPaymentStrategy(new CreditCardPayment("1234-5678-9876"));
        cart.Checkout(500);

        cart.SetPaymentStrategy(new PayPalPayment("user@example.com"));
        cart.Checkout(1200);

        cart.SetPaymentStrategy(new UpiPayment("arun@upi"));
        cart.Checkout(300);

    }
}
