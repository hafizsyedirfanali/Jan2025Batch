namespace _1_CsharpBasics;

public class _4_StringManipulation
{
    public static void Test()
    {
        Indexing();
    }
    public static void Indexing()
    {
        string str = "This is a book.";
        int index = str.IndexOf('o');//gets the index of first specified char
        index = str.LastIndexOf('o');//gets the index of last specified char
        Console.WriteLine(index);
    }
    public static void Splitting()
    {
        string str = "This is a book.";
        string[] fragments = str.Split(' ');
        string para = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
        string[] sentenceArray = para.Split('.');
    }
    public static void Concatenation()
    {
        //adding two or more sub strings to make a complete string
        //this is unsafe method
        string s1 = "This";
        string s2 = "is";
        string s3 = "a";
        string s4 = "book";

        string completeString = s1 + " " + s2 + " " + s3 + " " + s4 + ".";
        Console.WriteLine(completeString);
    }
    public static void PlaceholderMethod()
    {
        string s1 = "This";
        string s2 = "is";
        string s3 = "a";
        string s4 = "book";
        Console.WriteLine("{0} {1} {2} {3}.",s1,s2,s3,s4);
    }
    public static void Interpolation()
    {
        string s1 = "This";
        string s2 = "is";
        string s3 = "a";
        string s4 = "book";
        Console.WriteLine($"{s1} {s2} {s3} {s4}");
        //Console.WriteLine(`${s1} ${s2} ${s3} ${s4}`);interpolation in js
    }
}
