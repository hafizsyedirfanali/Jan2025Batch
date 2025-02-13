using _2_ObjectOrientedProgramming;

namespace _1_CsharpBasics;

public class _7_Encapsulation2
{
    public void Test()
    {
        _12_Encapsulation obj = new _12_Encapsulation();
        obj.PublicProperty = 1;//Writing (SET)
        Console.WriteLine(obj.PublicProperty);//Reading (GET)


        //obj.InternalProperty = 1;//inaccessible
        //Console.WriteLine(obj.InternalProperty);

        //obj.ProtectedInternal = 1;//inaccessible
        //Console.WriteLine(obj.ProtectedInternal);
    }
}

public class EncapsulationChildClass : _12_Encapsulation
{
    public void Test()
    {
        _12_Encapsulation obj = new _12_Encapsulation();
        //obj.ProtectedInternal = 1;
        //Console.WriteLine(obj.ProtectedInternal);

        ProtectedInternal = 1;
        Console.WriteLine(ProtectedInternal);

        //PrivateProtected = 1;//inaccessible
        //Console.WriteLine(PrivateProtected);
    }
}
