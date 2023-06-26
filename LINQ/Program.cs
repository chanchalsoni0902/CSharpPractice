
using LINQ;

public class Program
{
    static List<Student> students = new List<Student>();
    public static void Main()
    {
        // Adding students
        AddStudents();

        // Single
        Console.WriteLine("\nSingle -> ");
        Student st = students.Single(item => item.Id == 5);
        DisplayStudent(st);

        // SingleOrDefault
        Console.WriteLine("\nSingleOrDefault -> ");
        Student stud = students.SingleOrDefault(item => item.Id == 5);
        if (stud != null)
        {
            DisplayStudent(stud);
        }
        else
        {
            Console.WriteLine("\nNot Found!!");
        }

        // First
        Console.WriteLine("\nFirst -> ");
        Student st1 = students.First(item => item.Id == 1);
        DisplayStudent(st1);
       

        // FirstOrDefault
        Console.WriteLine("\nFirstOrDefault -> ");
        Student stud1 = students.FirstOrDefault(item => item.Id == 2);
        if (stud != null)
        {
            DisplayStudent(stud1);
        }
        else
        {
            Console.WriteLine("\nNot Found!!");
        }

        // Select
        List<string> names  = students.Select(item => item.Name).ToList();
        Console.WriteLine("\nSelect -> ");
        names.ForEach(item => Console.WriteLine(item));

        // Distinct
        List<string> distinctNames = students.Select(item => item.Name).Distinct().ToList();
        Console.WriteLine("\nDistinct -> ");
        distinctNames.ForEach(item => Console.WriteLine(item));

        // DistinctBy
        List<Student> distinctStudents = students.DistinctBy(item => item.Id).ToList();
        Console.WriteLine("\nDistinctBy");
        DisplayStudents(distinctStudents);

        // Where
        List<Student> studs = students.DistinctBy(item => item.Id < 3).ToList();
        Console.WriteLine("\nWhere");
        DisplayStudents(studs);

        // Find
        Student result = students.Find(item => item.Id < 3);
        Console.WriteLine("\nFind");
        DisplayStudent(result);

        // FindAll
        List<Student> data = students.FindAll(item => item.Id < 3).ToList();
        Console.WriteLine("\nFindAll");
        DisplayStudents(data);
    }

    public static void AddStudents()
    {
        Student student1 = new Student(1, "Chanchal");
        students.Add(student1);

        Student student2 = new Student(2, "Sailaja");
        students.Add(student2);

        Student student3 = new Student(3, "Amyra");
        students.Add(student3);

        Student student4 = new Student(4, "Ishita");
        students.Add(student4);

        Student student5 = new Student(5, "Kirti");
        students.Add(student5);
    }

    public static void DisplayStudents(List<Student> students)
    {
        students.ForEach(student =>
        {
            DisplayStudent(student);
        });
    }

    public static void DisplayStudent(Student student)
    {
        Console.WriteLine($"{student.Id} -> {student.Name}");
    }
}