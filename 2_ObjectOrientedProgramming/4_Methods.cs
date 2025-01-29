namespace _2_ObjectOrientedProgramming;
/// <summary>
/// Method is a collection/set of instruction or block of code
/// It has a meaningful name and is in UpperCamelCase.
/// A method accept parameters within its parenthesis ().
/// A method can return a value (response) or can return void.
/// We can call a method by writing its name and by passing the required parameters;
/// Method prevents code duplication and makes code reusable.
/// DRY principle = Don't Repeat Yourself
/// SOLID Principle =>
/// S => Single Responsibility Principle
/// A method should have only one responsibility.
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
        //6. Calling Concat1 method
        str = Concat1("Hello", 10, true);
        Console.WriteLine(str);
        //7. Calling Concat2 method
        str = Concat2("Hello", 10, 'A', true);
        Console.WriteLine(str);
        //8. Calling Concat3 method
        str = Concat3('A', 10);
        Console.WriteLine(str);
        //9. Calling SumAndDifference method
        (int sum, int diff) = SumAndDifference(10, 20);
        Console.WriteLine($"Sum: {sum}, Difference: {diff}");
        //10. Calling DifferenceAndSum method
        (int diff1, int sum1) = DifferenceAndSum(10, 20);
        Console.WriteLine($"Difference: {diff1}, Sum: {sum1}");

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
    //write a method that accepts a string, a number and a boolean
    //and return a string
    public string Concat1(string s, int n, bool b)
    {
        return s + n + b;
    }
    //write a method that accepts a string, a number, a character and a boolean
    //and return a string
    public string Concat2(string s, int n, char c, bool b)
    {
        return s + n + c + b;
    }
    //write a method that accepts a character and a number
    //and return a string
    public string Concat3(char c, int n)
    {
        return c + n.ToString();
    }
    //RETURNING MULTIPLE PARAMETERS
    //create a method that takes two int parameters
    //and returns both the sum and difference of the two numbers
    public (int Sum, int Difference) SumAndDifference(int a, int b)
    {
        return (a + b, a - b);
    }
    //create a method that takes two int parameters
    //and returns both the difference and sum of the two numbers
    public (int Difference, int Sum) DifferenceAndSum(int a, int b)
    {
        return (a - b, a + b);
    }
    //create a method "Divide" that takes two
    //int parameters a dividend and a divisor
    //and returns quotient and remainder
}
