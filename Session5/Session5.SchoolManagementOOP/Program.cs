public class Program
{
    public static void Main(string[] args)
    {
        Student[] students = new Student[10];

        int studentsNumber = 0;

        for (; ;)
        {
            Console.WriteLine("Please choose from menu");
            Console.WriteLine("1: Add new student");
            Console.WriteLine("2: List students");
            Console.WriteLine("0: Exit");
            var ChoosedmenuItem = Console.ReadLine(); 
            
            switch (ChoosedmenuItem)
            {
                case "1":
                    var tempStudent = new Student();

                    Console.WriteLine("plese enter FirstName");
                    tempStudent.firstName = Console.ReadLine();

                    Console.WriteLine("plese enter LastName");
                    tempStudent.lastName = Console.ReadLine();

                    Console.WriteLine("plese enter nationalCode");
                    tempStudent.nationalCode = Console.ReadLine();

                    students[studentsNumber] = tempStudent;
                    studentsNumber++;

                    break;
                case "2":
                    for (int i = 0; i < studentsNumber; i++)
                    {
                        Console.WriteLine("__________________________________________________");

                        Console.WriteLine($"{i}: FirstName: {students[i].firstName}" +
                                              $" LastName: {students[i].lastName} " +
                                              $" NationalCode: {students[i].nationalCode}");

                        Console.WriteLine("_________________________________________________");
                    }
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                
                default:
                    break;
            }
        }
    }
}
