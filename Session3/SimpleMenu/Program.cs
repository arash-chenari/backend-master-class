public class Program
{
    public static void Main(string[] args)
    {
        string[] menuItem = { "File", "Edit", "Help", "update" };
        int menuItemIndex = 0;
        Console.CursorVisible = false;
        Console.Title = "SimpleMenu";
        for(;;)
        {
            Console.Clear();
            for (int i = 0; i < menuItem.Length; i++)
            {
                if (i == menuItemIndex)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write($"{menuItem[i]}   ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write($"{menuItem[i]}   ");
                }
            }

            var key = Console.ReadKey().Key;
            if(key == ConsoleKey.RightArrow)
            {
                menuItemIndex = (menuItemIndex + 1) % menuItem.Length;
            }else if(key == ConsoleKey.LeftArrow)
            {
                menuItemIndex--;
                if(menuItemIndex < 0)
                {
                    menuItemIndex = menuItem.Length -1 ;
                }
            }
        }
    }
}