namespace _1_CsharpBasics;
/// <summary>
/// 1. Implicit - automatic (usually where there is no loss of information/data)
/// 2. Explicit - manual (usually where there is loss of data)
/// </summary>
public class _2_TypeConversion
{
    public static void Test()
    {
        ReferencedToValuedTypeMethod2();
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

    /// <summary>
    /// Conversion between Valued and Referenced is Explicit
    /// </summary>
    public static void ValuedToReferencedDataType()
    {
        //Integer to string
        int i = 10;
        // a string is represented using double quotes
        // "Hello" is a string
        string str = i.ToString();
        //above command will convert 10 to "10"
        byte b = 10;
        str = b.ToString();

        short s = 10;
        str = s.ToString();

        long l = 10;
        str = l.ToString();

        Int128 big = 10;
        str = big.ToString();

        ///fractional numbers to string
        float f = 1.1f;
        str = f.ToString();//1.1 will be "1.1"

        double d = 1.1d;
        str = d.ToString();

        decimal dm = 1.1m;
        str = dm.ToString();

        //boolean type to string
        bool bl = true;
        str = bl.ToString();//true will be "true"

        //character type to string
        char ch = 'A';
        str = ch.ToString(); //'A' will be now "A"
    }
    /// <summary>
    /// Method 1 using Convert class
    /// </summary>
    public static void ReferencedToValuedTypeMethod1()
    {
        string str = "";
        //to integer
        str = "10";
        int i = Convert.ToInt32(str);

        //to byte
        byte b = Convert.ToByte(str);

        //to short 
        short s = Convert.ToInt16(str);

        //to long 
        long l = Convert.ToInt64(str);

        //to int128
        //Int128 i128 = Convert. NOT AVAILABLE

        //to float,double and decimal
        float f = Convert.ToSingle(str);
        double d = Convert.ToDouble(str);
        decimal dm = Convert.ToDecimal(str);

        //to boolean
        str = "true";
        bool bl = Convert.ToBoolean(str);

        //to char
        str = "AA";
        char ch = Convert.ToChar(str);
    }

    public static void ReferencedToValuedTypeMethod2()
    {
        string str = "10";
        //byte
        byte b = byte.Parse(str);//this will parse/convert string to byte

        //short 
        short s = short.Parse(str);

        //int
        int i = int.Parse(str);

        //long
        long l = long.Parse(str);

        //big int
        Int128 int128 = Int128.Parse(str);

        //float 
        float f = float.Parse(str);

        //double 
        double d = double.Parse(str);

        //decimal
        decimal dm = decimal.Parse(str);

        //boolean
        str = "true";
        bool bl = bool.Parse(str);

        //character
        str = "A";
        char ch = char.Parse(str);
    }
    public static void ReferencedToValuedTypeMethod3()
    { 
        //will study after conditional operators if else
    }
}
