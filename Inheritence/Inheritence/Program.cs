class Vehicle
{
    public string? Make { get; set; }
    public string? Model { get; set; }

    public void Start()
    {
        Console.WriteLine($"The {Make} {Model} is starting.");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public void DisplayCarInfo()
    {
        Console.WriteLine($"Car: {Make} {Model}, Doors: {NumberOfDoors}");
    }
}

class Bike : Vehicle
{
    public bool HasCarrier { get; set; }

    public void DisplayBikeInfo()
    {
        Console.WriteLine($"Bike: {Make} {Model}, Carrier: {(HasCarrier ? "Yes" : "No")}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car { Make = "Tata", Model = "EV", NumberOfDoors = 4 };
        car.Start();
        car.DisplayCarInfo();

        Bike bike = new Bike { Make = "Yamaha", Model = "R15", HasCarrier = false };
        bike.Start();
        bike.DisplayBikeInfo();
    }
}