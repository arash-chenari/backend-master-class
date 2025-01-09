public class Program
{
    public static void Main(string[] args)
    {
        string[] firstName = { "arash" , "mehdi" , "sara"};
        string[] lastName = { "chenari", "mohammadi", "rajaie" };
        string[] natinalCode = { "111", "222", "333" };

        int studentsNumber = 3;
        for (; ;)
        {
            Menu();
            int menuInput = Convert.ToInt32(Console.ReadLine());
            switch (menuInput)
            {
                case 1:
                    studentsNumber = AddStudent(firstName, lastName, natinalCode, studentsNumber);
                    break;
                case 2:
                    ShowStudents(firstName, lastName, natinalCode, studentsNumber);
                    break;
                case 4:
                    SearchStudent(natinalCode, studentsNumber);
                    break;
                case 5:
                    var studentIndex = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"{firstName[studentIndex]} {lastName[studentIndex]}");
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
    }

    private static void SearchStudent(string[] natinalCode, int studentsNumber)
    {
        Console.WriteLine("please enter national code");
        string inputNationalCode = Console.ReadLine();
        for (int i = 0; i < studentsNumber; i++)
        {
            if (natinalCode[i] == inputNationalCode)
            {
                Console.WriteLine($"the student number is {i}");
                break;
            }
        }
    }

    private static void ShowStudents(string[] firstName, string[] lastName, string[] natinalCode, int studentsNumber)
    {
        for (int i = 0; i < studentsNumber; i++)
        {
            Console.WriteLine($"{i + 1}: firstName: {firstName[i]} lastName: {lastName[i]} NationalCode: {natinalCode[i]}");
        }
    }

    private static void Menu()
    {
        Console.WriteLine("please choose from menu");
        Console.WriteLine("1: Add new student");
        Console.WriteLine("2: List students");
        Console.WriteLine("4: search student");
        Console.WriteLine("5: show specific student");
        Console.WriteLine("3: exit");
    }

    private static int AddStudent(string[] firstName, string[] lastName, string[] natinalCode, int studentsNumber)
    {
        Console.WriteLine("please enter fristName");
        var tempFristName = Console.ReadLine();
        firstName[studentsNumber] = tempFristName;

        Console.WriteLine("please enter lastName");
        var tempLastName = Console.ReadLine();
        lastName[studentsNumber] = tempLastName;

        Console.WriteLine("please enter nationalCode");
        var tempNationalCode = Console.ReadLine();
        natinalCode[studentsNumber] = tempNationalCode;

        studentsNumber++;
        return studentsNumber;
    }
}