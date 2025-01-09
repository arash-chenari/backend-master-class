public class Program
{
    public static void Main()
    {
         Engin bmwEngin = new Engin(4);
         Car bmw = new Car(bmwEngin) { name = "bmw", model = "X6" };
        
        for (; ;)
        {
            if (Console.KeyAvailable)
            {
                var input = Console.ReadKey().Key;

                switch (input)
                {
                    case ConsoleKey.UpArrow:
                        bmw.Accelerate();
                        break;
                    case ConsoleKey.DownArrow:
                        bmw.Break();
                        break;
                }
            }
            else
            {
                Console.WriteLine("----------------------------");
                Console.Write($"Speed: {bmw.Speed()}  EnginRpm : {bmw.engin.Rpm()} \n");
                Console.WriteLine("----------------------------");
                Thread.Sleep(750);
                Console.Clear();
            }
        }
    }
}
