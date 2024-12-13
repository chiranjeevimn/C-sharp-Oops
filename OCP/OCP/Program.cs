public abstract class Discount
{
    public abstract decimal ApplyDiscount(decimal total);
}
public class SeasonalDiscount : Discount
{
    public override decimal ApplyDiscount(decimal total)
    {
        return total * 0.9m;
    }
}
public class ClearanceDiscount : Discount
{
    public override decimal ApplyDiscount(decimal total)
    {
        return total * 0.8m; 
    }
}
public class FestiveDiscount : Discount
{
    public override decimal ApplyDiscount(decimal total)
    {
        return total * 0.85m; 
    }
}

public class DiscountCalculator
{
    public decimal CalculateDiscount(Discount discount, decimal total)
    {
        return discount.ApplyDiscount(total);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Discount seasonalDiscount = new SeasonalDiscount();
        DiscountCalculator calculator = new DiscountCalculator();

        decimal seasonalTotal = calculator.CalculateDiscount(seasonalDiscount, 1000m);
        Console.WriteLine($"Total after Seasonal Discount: {seasonalTotal}");

        Discount clearanceDiscount = new ClearanceDiscount();
        decimal clearanceTotal = calculator.CalculateDiscount(clearanceDiscount, 1000m);
        Console.WriteLine($"Total after Clearance Discount: {clearanceTotal}");

        Discount festiveDiscount = new FestiveDiscount();
        decimal festiveTotal = calculator.CalculateDiscount(festiveDiscount, 1000m);
        Console.WriteLine($"Total after Festive Discount: {festiveTotal}");


    }
}
