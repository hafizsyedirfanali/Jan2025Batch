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
        ReferenceUsingRefCallerMethod();
    }
    public void TestCalling()
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
        //11. Calling Divide method
        (int quotient, int remainder) = Divide(10, 3);
        Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");
        //12. Calling Add method
        value = Add(10, 20);//Calling Add method with two parameters
        value = Add(10, 20, 30);//Calling Add method with three parameters
        value = Add(10, 20, 30, 40);//Calling Add method with four parameters
        //13. Calling Concatenate method
        str = Concatenate("Hello", "World");
        str = Concatenate(10, "World");
        str = Concatenate("Hello", 10);
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
    public (int Quotient, int Remainder) Divide(int dividend, int divisor)
    {
        return (dividend / divisor, dividend % divisor);
    }

    //Method Overloading
    //Method overloading is a feature that allows a class to have
    //more than one method having the same name,
    //if their parameter lists (parameter type and sequence) are different.
    //It is similar to constructor overloading in C#.
    //Method overloading is also known as compile-time polymorphism.
    //Method overloading is a type of static polymorphism.
    //Static polymorphism is achieved through method overloading and operator overloading.
    public int Add(int a, int b)//A version of Add method
    {
        return a + b;
    }
    public int Add(int a, int b, int c)//Another version of Add method
    {
        return a + b + c;
    }
    public int Add(int a, int b, int c, int d)//Another version of Add method
    {
        return a + b + c + d;
    }
    //Add methods has three overloaded versions
    //Now write overloaded versions of Concatenation method
    //First version takes two strings and returns a string
    public string Concatenate(string s1, string s2)
    {
        return s1 + s2;
    }
    //Second version takes an int and a string and returns a string
    public string Concatenate(int n, string s)
    {
        return n + s;
    }
    //Third version takes a string and an int and returns a string
    public string Concatenate(string s, int n)
    {
        return s + n;
    }

    //METHOD CALLING
    //There are two types of method calling 1. Call by Value & 2. Call by Reference

    //1. Call by Value
    public void TestCallByValue()
    {
        int x = 5;
        CallByValue(x);
    }
    public void CallByValue(int y)
    {
        y = y + 1;
    }

    //2. Call by Reference
    //We have three keywords to achieve call by reference.
    //they are in, out and ref
    //in keyword : it is used to specify that the variable can only read (input) the value
    //out keyword: it is used to specify that the variable will be returning the value
    //or that the function/method will be writing (output) into that variable
    //ref keyword: it is used to specify that the function can read or write into that variable

    //Call by Reference using in keyword
    public void ReferenceUsingInCallerMethod()
    {
        int x = 10;//Initialization is mandatory.
        ReferenceUsingInCalledMethod(in x);
    }
    public void ReferenceUsingInCalledMethod(in int y)
    {
        //y = y + 1; //Error: Cannot assign to 'in int' because it is a readonly variable
    }
    //Call by Reference using out keyword
    public void ReferenceUsingOutCallerMethod()
    {
        int x;//Initialization is not mandatory.
        ReferenceUsingOutCalledMethod(out x);
        Console.WriteLine(x);
    }
    public void ReferenceUsingOutCalledMethod(out int y)
    {
        y = 10;//Assignment is mandatory.
    }
    //Call by Reference using ref keyword
    public void ReferenceUsingRefCallerMethod()
    {
        int x = 10;//Initialization is mandatory.
        ReferenceUsingRefCalledMethod(ref x);
        Console.WriteLine(x);
    }
    public void ReferenceUsingRefCalledMethod(ref int y)
    {
        y = y + 1;//writing is not mandatory.
    }
    //Write a method that takes a string and an out int parameter
    //Its name is MyParseByte
    public void MyParseByte(string s, out int value)
    {
        value = int.Parse(s);
    }
}
