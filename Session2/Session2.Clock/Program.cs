using System.Globalization;

public static class Prgram
{
    public static void Main(string[] args)
    {   
        int hour, minute, second;
            
        Console.WriteLine("please enter hour");
        string input = Console.ReadLine();
        hour = Convert.ToInt32(input);

        Console.WriteLine("please enter minute");
        input = Console.ReadLine();
        minute = Convert.ToInt32(input);

        Console.WriteLine("please enter secend");
        input = Console.ReadLine();
        second = Convert.ToInt32(input);

        second += 1;
        minute = minute + second / 60;
        second = second % 60;

        hour = hour + minute / 60;
        minute = minute % 60;

        hour = hour % 24;

        Console.WriteLine($"The Time is {hour}:{minute}:{second}");
    }
}



/*
 * 
 * please get hour and minute and secend from user
 * !!!!!! important Dont use if !!!!!!
 * we have a time for example => 10:46:23
 * Add one secend to this given time and print answer
 */


/*
 * frist algorithm
 *         int hour, minute, second;
       
        Console.WriteLine("please enter hour");
        string input = Console.ReadLine();
        hour = Convert.ToInt32(input);
        
        Console.WriteLine("please enter minute");
        input = Console.ReadLine();
        minute = Convert.ToInt32(input);
        
        Console.WriteLine("please enter secend");
        input = Console.ReadLine();
        second = Convert.ToInt32(input);

        int totalSecends = (hour * 3600) + (minute * 60) + second ;
        totalSecends += 1;
        hour = totalSecends / 3600;
        totalSecends = totalSecends % 3600;

        minute = totalSecends / 60;
        second = totalSecends % 60;

        Console.WriteLine($"The Time is {hour}:{minute}:{second}");
 */