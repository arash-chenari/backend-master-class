using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        Print("please enter first number");
        var firstNumber = GetInputNumbrFromUser();
        Print("please enter second number");
        var secondNumber = GetInputNumbrFromUser();
        
        var sum = firstNumber + secondNumber;
        
        Print(sum.ToString());
    }


    public static void Print(string message)
    {
        Console.WriteLine(message);
    }

    public static int GetInputNumbrFromUser()
    {
        var input = Console.ReadLine();
        var intValue = Convert.ToInt32(input);
        return intValue;
    }
}
