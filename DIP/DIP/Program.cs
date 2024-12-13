public interface IMessageService
{
    void SendMessage(string message);
}
public class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}

public class SMSService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}
public class OrderService
{
    private readonly IMessageService _messageService;

    public OrderService(IMessageService messageService)
    {
        _messageService = messageService; // Dependency injection
    }

    public void PlaceOrder(string orderDetails)
    {
        Console.WriteLine($"Order placed: {orderDetails}");
        _messageService.SendMessage("Order confirmation sent.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Injecting EmailService
        IMessageService emailService = new EmailService();
        OrderService orderServiceWithEmail = new OrderService(emailService);
        orderServiceWithEmail.PlaceOrder("Laptop");

        // Injecting SMSService
        IMessageService smsService = new SMSService();
        OrderService orderServiceWithSMS = new OrderService(smsService);
        orderServiceWithSMS.PlaceOrder("Mobile Phone");
    }
}
