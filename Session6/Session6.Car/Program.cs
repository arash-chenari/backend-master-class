using Session6.Car;
using System.Net.Http.Headers;
public class Program
{
    public static void Main(string[] args)
    {
        var tier = new Tier
        {
            height = 100,
            pressure = 500,
            width = 10
        };

        Car prado = new();

        Car mycar = new Car();
        mycar.name = "Pride";
        mycar.model = "111";
        mycar.color = "White";
        mycar.FrontLeft = tier;
        mycar.FrontLeft.pressure = 1000;
        mycar.BackLeft = new Tier() { width = 1000, height = 100, pressure = 20 };

        Console.WriteLine($"the car is {mycar.name} with model {mycar.model} and with color {mycar.color}");
        Console.WriteLine($"the car leftfront tier pressure is {mycar.FrontLeft.pressure} ");
        Console.WriteLine($"the car leftfront tier pressure is {mycar.BackLeft.pressure} ");
       
    }
}