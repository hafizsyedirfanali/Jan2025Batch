namespace _2_ObjectOrientedProgramming;
/// <summary>
/// Method is a collection/set of instruction or block of code
/// It has a meaningful name and is in UpperCamelCase.
/// A method accept parameters within its parenthesis ().
/// A method can return a value (response) or can return void.
/// We can call a method by writing its name and by passing the required parameters;
/// </summary>
public class _4_Methods
{
    public void Test()
    {
        //1. Calling Greet method
        Greet();
        //2. Calling GenerateRandomNumber method
        int value = GenerateRandomNumber();//Calling a method ends with semicolon
        Console.WriteLine(value);
        //3. Calling Increment method
        value = Increment(10);
        Console.WriteLine(value);
        //4. Calling Sum method
        value = Sum(10,20);
        Console.WriteLine(value);
        //5. Calling Concat method
        string str = Concat("Hello", "World");
        Console.WriteLine(str);
        PrintHello();
    }
    //Create a Method that does not take parameter and does not return any value
    public void Greet()
    {
        Console.WriteLine("Hello");
    }
    //create a method that prints Hello ten times
    public void PrintHello()
    {
        //following is block of code (currently it is meaning less)
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
    }

    //create a method that does not take any parameter and return int value.
    public int GenerateRandomNumber()
    {
        var random = new Random();
        return random.Next();//random.Next() gives an int and return keyword returns it.
    }
    //create a method that takes an int parameter and returns an int.
    public int Increment(int value)
    {
        return ++value;
    }
    //create a method that takes two int parameters and returns an int.
    public int Sum(int a, int b)
    {
        return a + b;
    }
    //create a method that takes two strings and concatenate them and return it
    public string Concat(string s1, string s2)
    {
        return s1 +" "+ s2;
    }
    
}
