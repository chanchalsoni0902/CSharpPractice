using static MyDelegates;

public class Program
{
    public static void Main()
    {
        // generics

        bool res = MyGenerics.AreEqual<int>(11, 11);
        Console.WriteLine(res);

        res = MyGenerics.AreEqual<int>(12, 24);
        Console.WriteLine(res);

        res = MyGenerics.AreEqual<string>("123", "123");
        Console.WriteLine(res);

        res = MyGenerics.AreEqual<string>("Abc", "Bcd");
        Console.WriteLine(res);


        // delegates
        HelloFunctionDelegate myDelegate = new HelloFunctionDelegate(Hello);
        myDelegate("Chanchal");
    }

    public static void Hello(string name)
    {
        Console.WriteLine($"Hello, {name}!!");
    }
}

public static class MyGenerics
{
    public static bool AreEqual<T>(T param1, T param2)
    {
        return param1.Equals(param2);
    }

}

public class MyDelegates
{
    // A delegate type safe function pointer
    // delegate can pint to any function that has simlar return type and paramter
    // delegate should match the signature of function
    // Delegates can be used to define callback methods
    public delegate void HelloFunctionDelegate(string name);
}