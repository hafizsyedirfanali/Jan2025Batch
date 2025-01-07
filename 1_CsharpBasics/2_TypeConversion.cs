namespace _1_CsharpBasics;
/// <summary>
/// 1. Implicit - automatic (usually where there is no loss of information/data)
/// 2. Explicit - manual (usually where there is loss of data)
/// </summary>
public class _2_TypeConversion
{
    public static void Test()
    {
        Explicit();
    }

    public static void Implicit()
    {
        ///between integers
        byte b = 10;
        short s = b;
        int i = s;
        long l = i;
        Int128 bi = l;

        //fractional numbers
        float f = i;
        double d = i;
        decimal c = i;

        //character
        char ch = 'A';
        i = ch;//ch is of byte size and can be stored in int

        //boolean
        bool bl = true;
        //i = bl;invalid
    }

    public static void Explicit()
    {
        ///between integers
        Int128 bi = 300;
        long l = (long)bi;
        ///00000000000000000000000000000000000000000000000000000000000111 -long
        ///                               0000000000000000000000000000111 -int
        ///                                               000000000000111 -short
        ///                                                       0000111 -byte
        int i = (int)l;
        short s = (short)i;
        byte b = (byte)s;

        ///floating numbers
        float f = 10.5f;
        i = (int)f;//loss of .5
        Console.WriteLine(i);//value is 10

        //character 
        b = 41;
        char ch = (char)b;//A is 41

        //boolean
        //bool bl = (bool)b;invalid conversion see following example
        ///00000011 -3
        ///       1 -true
    }
}
