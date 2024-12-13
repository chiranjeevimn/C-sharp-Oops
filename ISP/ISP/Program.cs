public interface IPrinter
{
    void Print(string content);
}

public interface IScanner
{
    void Scan(string content);
}

public interface IFax
{
    void Fax(string content);
}

// Multi-function printer 
public class MultiFunctionPrinter : IPrinter, IScanner, IFax
{
    public void Print(string content)
    {
        Console.WriteLine("Printing: " + content);
    }

    public void Scan(string content)
    {
        Console.WriteLine("Scanning: " + content);
    }

    public void Fax(string content)
    {
        Console.WriteLine("Faxing: " + content);
    }
}

// Basic printer that only implements printing
public class BasicPrinter : IPrinter
{
    public void Print(string content)
    {
        Console.WriteLine("Printing: " + content);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Multi-function printer
        IPrinter multiPrinter = new MultiFunctionPrinter();
        multiPrinter.Print("Document1");

        IScanner scanner = new MultiFunctionPrinter();
        scanner.Scan("Document1");

        IFax fax = new MultiFunctionPrinter();
        fax.Fax("Document1");

        // Basic printer
        IPrinter basicPrinter = new BasicPrinter();
        basicPrinter.Print("Document2");

        // BasicPrinter does not implement Scan or Fax, so it avoids unnecessary methods.
        // No exceptions are thrown, and responsibilities are cleanly separated.
    }
}
