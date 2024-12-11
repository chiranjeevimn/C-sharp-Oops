abstract class Employee
{
    public string? Name { get; set; }
    public int EmployeeId { get; set; }

    public abstract decimal CalculatePay();

    public void DisplayInfo()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}, Name: {Name}");
    }
}

class FullTimeEmployee : Employee
{
    public decimal MonthlySalary { get; set; }

    public override decimal CalculatePay()
    {
        return MonthlySalary;
    }
}

class Contractor : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public override decimal CalculatePay()
    {
        return HourlyRate * HoursWorked;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee fullTime = new FullTimeEmployee { EmployeeId = 1, Name = "Chiranjeevi", MonthlySalary = 20000m };
        fullTime.DisplayInfo();
        Console.WriteLine($"Pay: {fullTime.CalculatePay()}");

        Employee contractor = new Contractor { EmployeeId = 2, Name = "Manoj", HourlyRate = 100m, HoursWorked = 150 };
        contractor.DisplayInfo();
        Console.WriteLine($"Pay: {contractor.CalculatePay()}");
    }
}