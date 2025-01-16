namespace _1_CsharpBasics;

public class _5_ConditionalStatements
{
    public static void Test()
    {
        SwitchCase();
    }
    public static void SwitchCase()
    {
        Console.Write("Enter Roll No.: ");
        int rollNo = Convert.ToInt32(Console.ReadLine());
        switch (rollNo)
        {
            case 1: Console.WriteLine("ONE");break;
            case 2: Console.WriteLine("TWO");break;
            case 3: Console.WriteLine("THREE");break;
            case 4: Console.WriteLine("FOUR");break;
            case 5: Console.WriteLine("FIVE");break;
            case 6: Console.WriteLine("SIX");break;
            default: Console.WriteLine("INVALID");break;

        }
    }
    public static void IfElseStatement()
    {
        //if temp is > 30 then turn the fan ON otherwise turn OFF
        string userInput = Console.ReadLine();
        int temp = Convert.ToInt32(userInput);
        if(temp > 30)//If block will be executed when the condition is true
        {
            Console.WriteLine("FAN IS ON");
        }
        else //else block will be executed when the condition is false
        {
            Console.WriteLine("FAN IS OFF");
        }
    }
    public static void IfElseLadder()
    {
        Console.Write("Enter percentage:");
        string userInput = Console.ReadLine();
        int percentage = Convert.ToInt32(userInput);
        if(percentage < 0)
        {
            Console.WriteLine("Invalid percentage");
        }
        else if (percentage < 31)
        {
            Console.WriteLine("FAIL");
        }
        else if (percentage < 51)
        {
            Console.WriteLine("PASS: THIRD CLASS");
        }
        else if (percentage < 61)
        {
            Console.WriteLine("PASS: SECOND CLASS");
        }
        else if (percentage < 75)
        {
            Console.WriteLine("PASS: FIRST CLASS");
        }
        else if (percentage <= 100)
        {
            Console.WriteLine("PASS: DISTINCTION");
        }
        else
        {
            Console.WriteLine("INVALID PERCENTAGE");
        }
    }
    public static void NestedIfElse()
    {
        Console.WriteLine("Enter Chapter No.");
        int chapterNo = Convert.ToInt32(Console.ReadLine());
        if(chapterNo == 1)
        {
            Console.WriteLine("Enter Topic of Ch.1: ");
            int topicNo = Convert.ToInt32(Console.ReadLine());
            if(topicNo == 1)
            {
                Console.WriteLine("This is topic 1 content.");
            }
            else
            {
                Console.WriteLine("This is remaining content");
            }

        }
        else
        {
            Console.WriteLine("This is remaining content of the book");
        }
    }
}
