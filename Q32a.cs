using System;

// ---------------- Adapter ------------------
// Target interface expected by new system
public interface IPaymentProcessor
{
    void Pay(decimal amount);
}

// Legacy payment gateway (incompatible interface)
public class LegacyPaymentGateway
{
    public void MakePayment(double money)
    {
        Console.WriteLine($"Legacy payment processed: ${money}");
    }
}

// Adapter to make LegacyPaymentGateway compatible
public class PaymentAdapter : IPaymentProcessor
{
    private readonly LegacyPaymentGateway _legacyGateway;

    public PaymentAdapter(LegacyPaymentGateway legacyGateway)
    {
        _legacyGateway = legacyGateway;
    }

    public void Pay(decimal amount)
    {
        // Convert decimal to double and call legacy method
        _legacyGateway.MakePayment((double)amount);
    }
}

// ---------------- Facade ------------------
public class InventoryService
{
    public bool CheckStock(string product)
    {
        Console.WriteLine($"Checking stock for {product}");
        return true;
    }
}

public class ShippingService
{
    public void ShipProduct(string product, string address)
    {
        Console.WriteLine($"Shipping {product} to {address}");
    }
}

// Facade class to simplify ordering process
public class OrderFacade
{
    private readonly InventoryService _inventory;
    private readonly IPaymentProcessor _payment;
    private readonly ShippingService _shipping;

    public OrderFacade(IPaymentProcessor paymentProcessor)
    {
        _inventory = new InventoryService();
        _shipping = new ShippingService();
        _payment = paymentProcessor;
    }

    public void PlaceOrder(string product, string address, decimal amount)
    {
        if (_inventory.CheckStock(product))
        {
            _payment.Pay(amount);
            _shipping.ShipProduct(product, address);
            Console.WriteLine("Order placed successfully!");
        }
        else
        {
            Console.WriteLine("Product out of stock!");
        }
    }
}

// ---------------- Client ------------------
class Program
{
    static void Main(string[] args)
    {
        // Legacy payment system
        var legacyPayment = new LegacyPaymentGateway();

        // Adapter wraps legacy system
        IPaymentProcessor paymentAdapter = new PaymentAdapter(legacyPayment);

        // Facade simplifies order placement
        var orderFacade = new OrderFacade(paymentAdapter);

        // Client just calls one method
        orderFacade.PlaceOrder("Laptop", "123 Main St", 1200m);
    }
}
