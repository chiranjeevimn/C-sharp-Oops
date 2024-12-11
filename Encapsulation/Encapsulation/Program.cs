class BankAccount
{
    private decimal balance;

    public string AccountHolder { get; set; }
    public int AccountNumber { get; private set; }

    public BankAccount(int accountNumber, string accountHolder, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew: {amount}. New Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {balance}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(12345, "John Doe", 1000m);
        account.DisplayBalance();
        account.Deposit(500m);
        account.Withdraw(300m);
        account.DisplayBalance();
    }
}