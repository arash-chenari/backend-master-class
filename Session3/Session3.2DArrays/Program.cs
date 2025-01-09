public class Program
{
    public static void Main(string[] args)
    {
        int[,] array =
          {
            { 1, 1, 1, 0, 0, 0, 1, 1, 1  },
            { 1, 1, 1, 1, 0, 1, 1, 1, 1 },
            { 0, 1, 1, 1, 1, 1, 1, 1, 0 },
            { 0, 0, 1, 1, 1, 1, 1, 0, 0 },
            { 0, 0, 0, 1, 1, 1, 0, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 0, 0, 0 },
        };

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                switch (array[i, j])
                {
                    case 0:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("  ");
                        break;
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("  ");
                        break;
                }

            }
            Console.WriteLine();
        }

    }
}
/* 
 */