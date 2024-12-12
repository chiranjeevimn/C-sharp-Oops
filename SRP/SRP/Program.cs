public class Invoice
{
    public int Id { get; set; }
    public string? Customer { get; set; }
    public decimal Amount { get; set; }
    public decimal Tax { get; set; }

    public decimal CalculateTotal()
    {
        return Amount + Tax;
    }
}

public class InvoiceRepository
{
    public void SaveToDatabase(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Id} saved to the database.");
    }
}
public class InvoiceReportGenerator
{
    public void GenerateReport(Invoice invoice)
    {
        Console.WriteLine("Invoice Report:");
        Console.WriteLine($"ID: {invoice.Id}");
        Console.WriteLine($"Customer: {invoice.Customer}");
        Console.WriteLine($"Total Amount: {invoice.CalculateTotal()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Invoice invoice = new Invoice
        {
            Id = 1,
            Customer = "John Doe",
            Amount = 1000m,
            Tax = 100m
        };
        decimal total = invoice.CalculateTotal();
        Console.WriteLine("SRP(single responsibility principle):  Each class should have only one reason to change, " +
            "meaning it should have only one responsibility or focus.");
        Console.WriteLine($"Total Amount: {total}");

        InvoiceRepository repository = new InvoiceRepository();
        repository.SaveToDatabase(invoice);

        InvoiceReportGenerator reportGenerator = new InvoiceReportGenerator();
        reportGenerator.GenerateReport(invoice);

    }
}
