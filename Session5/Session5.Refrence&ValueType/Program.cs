public class Program
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b = a;
        b = 5;
        Console.WriteLine($"a  = {a} , b = {b}");

        var p1 = new Person();
        var p2 = new Person();
        var p3 = p2;
        var p4 = p3;

        p4.age = 10;
    }
}

public class Person
{
    public int age;
}
