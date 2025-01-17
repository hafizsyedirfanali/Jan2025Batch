namespace _1_CsharpBasics;
/// <summary>
/// Loops are of four types in c#
/// 1. While loop
/// 2. do while loop
/// 3. for loop
/// 4. foreach loop
/// //Console.WriteLine("AAA");
//Console.WriteLine("bbb");
//Console.WriteLine("ccc");
//this is code repetition going against DRY Principle (Don't Repeat Yourself)
/// </summary>
public class _6_Loops
{
    public static void Test()
    {
        ForEach();
    }
    public static void AnArray()
    {
        int i = 10;
        int[] rollNos = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        string s = "Aaa";
        string[] names = ["Aaa", "bbb", "ccc", "ddd", "eee"];
    }
    public static void WhileLoop()
    {
        //repeat the block of code while the condition is true
        //it checks the condition and then if condition is true, it executes the block of code.
        //Print the hello world 10 times
        int i = 0;
        while (i<10)
        {
            Console.WriteLine("Hello world");
            i++;
        }
        //print the roll nos 
        int[] rollNos = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int j = 0;//initialization of loop variable (iterator)
        while (j < rollNos.Length)//condition check
        {
            Console.WriteLine($"Roll No {rollNos[j]}");
            j++;//Increment of iterator (MUST BE LAST STATEMENT)
        }
    }

    public static void DoWhileLoop()
    {
        //it will do the repetition while the condition is true.
        //it executes the block of code one time even if the condition is false
        //it executes first then checks the condition
        //print the roll nos
        int[] rollNos = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int i = 0;
        do
        {
            Console.WriteLine(rollNos[i]);
            i++;
        } while (i < rollNos.Length);
    }
    public static void ForLoop()
    {
        int[] rollNos = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        for (int i = 0; i < rollNos.Length; i++)
        {
            Console.WriteLine(rollNos[i]);
        }
    }
    public static void ForEach()
    {
        //Do repetition for each item in items
        //do following repetition for each roll no in the collection of roll nos.
        int[] rollNos = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        foreach (var rollNo in rollNos)
        {
            Console.WriteLine(rollNo);
        }
    }
}
