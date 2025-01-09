public class Program
{
    static void Main(string[] args)
    {
        var circle = new Circle(10);
    }
}


public class Circle
{
    public Circle(double raw)
    {
        this.raw = raw;
    }

    public double raw;
}