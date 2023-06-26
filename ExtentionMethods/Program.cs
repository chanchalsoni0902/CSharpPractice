public class Program
{
    public static void Main()
    {
        "Chanachal".DisplayLegth();

        5.Factotorial();
    }
}

public static class Extentions
{
    public static void DisplayLegth(this string str)
    {
        Console.WriteLine($"Length of {str} is {str.Length}");
    }
    
    public static void Factotorial(this int num)
    {
        if (num < 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"Factorial of {num}: {fact}");
        }
    }
}