namespace _2_ObjectOrientedProgramming;
/// <summary>
/// Encapsulation is the mechanism that binds together the code and the data it manipulates, 
/// and keeps both safe from outside interference and misuse.
/// In simple words, encapsulation is defined as the wrapping up of data under a single unit.
/// We use access modifiers to achieve encapsulation.
/// public: Code in any assembly can access this type or member. 
/// private: Only code declared in the same class or struct can access this member.
/// protected: Only code in the same class or in a derived class can access this type or member.
/// internal: Only code in the same assembly can access this type or member.
/// protected internal: Only code in the same assembly or in a derived class in another assembly can access this type or member.
/// private protected: Only code in the same assembly and in the same class or a derived class can access the type or member.
/// </summary>
public class _12_Encapsulation
{
    public void Test()
    {
        PrivateProperty = 1;
        Console.WriteLine(PrivateProperty);

        PrivateProtected = 1;
        Console.WriteLine(PrivateProtected);
    }
    public int PublicProperty { get; set; }
    private int PrivateProperty { get; set; }
    protected int ProtectedProperty { get; set; }
    internal int InternalProperty { get; set; }
    protected internal int ProtectedInternal { get; set; }
    private protected int PrivateProtected { get; set; }
}
public class EncapsulationOuterClass
{
    public void Test()
    {
        _12_Encapsulation obj = new _12_Encapsulation();
        obj.PublicProperty = 1;
        Console.WriteLine(obj.PublicProperty);

        //obj.PrivateProperty = 1;//private is inaccessible

        //obj.ProtectedProperty = 1;//protected is inaccessible
        //Console.WriteLine(obj.ProtectedProperty);
        //ProtectedProperty = 1;

        obj.InternalProperty = 1;
        Console.WriteLine(obj.InternalProperty);

        obj.ProtectedInternal = 1;
        Console.WriteLine(obj.ProtectedInternal);

        //PrivateProtected = 1;
        //Console.WriteLine(PrivateProtected);
    }
}
public class EncapsulationChildClass : _12_Encapsulation
{
    protected void Test()
    {
        ProtectedProperty = 1;
        Console.WriteLine(ProtectedProperty);

        _12_Encapsulation obj = new _12_Encapsulation();
        //obj.ProtectedProperty = 1;
        //Console.WriteLine(obj.ProtectedProperty);

        obj.InternalProperty = 1;
        Console.WriteLine(obj.InternalProperty);

        obj.ProtectedInternal = 1;
        Console.WriteLine(obj.ProtectedInternal);

        PrivateProtected = 1;
        Console.WriteLine(PrivateProtected);
    }
}