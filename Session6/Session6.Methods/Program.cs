public class Program
{
    static void Main(string[] args)
    {
        var circle = new Circle(10);
        var circle2 = new Circle(11);

        Console.WriteLine(circle.Area());
        Console.WriteLine(circle2.Area());

    }
}


public class Circle
{
    public Circle(double raw)
    {
        this.raw = raw;
    }

    public double raw;
    public double Area()
    {
       return  Math.Pow(raw, 2) * Math.PI;
    }
}