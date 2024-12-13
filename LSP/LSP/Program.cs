public abstract class PaymentProcessor
{
    public abstract void ProcessPayment(decimal amount);
}

public class CreditCardProcessor : PaymentProcessor
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }
}

public class PayPalProcessor : PaymentProcessor
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount}");
    }
}

// Usage
class Program
{
    static void Main(string[] args)
    {
        PaymentProcessor payment = new CreditCardProcessor();
        payment.ProcessPayment(100.00m);

        payment = new PayPalProcessor();
        payment.ProcessPayment(200.00m); 
    }
}
