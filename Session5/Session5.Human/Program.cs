public class Program
{
    static int a = 5;
    public static void Main()
    {
        Student[] students =
        {
            new Student
            {
                name = "arash",
                lastName = "chenari"
            },
            new Student {
                name = "mehdi",
                lastName = "mohammadi"
            } 
        };

        for (int i = 0; i < 2; i++)
        {
            students[i].Introduce();
        }
    }

}

public class Student
{
    public Student()
    {
    }

    public int hieght;
    public int weight;
    public int birthYear;
    public string name;
    public string lastName;

    public void Introduce()
    {
        Console.WriteLine($"Hellow im {name} {lastName} ");
    }
}






