namespace _2_ObjectOrientedProgramming;
/// <summary>
/// Polymorphism is a Greek word that means "many-shaped" and it has two types:
/// 1. Compile Time Polymorphism - Method Overloading
/// 2. Run Time Polymorphism - Method Overriding
/// </summary>
public class _10_Polymorphism
{
    public void Test()
    {

    }
    //Compile Time Polymorphism
    public class CompileTimePolymorphism
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
    }
    //Run Time Polymorphism
    public class RunTimePolymorphism
    {
        //Parent class when marks a method as virtual then it means that 
        //parent class is allowing the child class to override this method.
        public virtual void Display()
        {
            Console.WriteLine("Parent Class");
        }
    }
    public class ChildClass : RunTimePolymorphism
    {
        public override void Display()
        {
            Console.WriteLine("Child Class");
        }
    }
    //Hiding an inherited member using the new keyword
    public class HidingInheritedMember
    {
        public int Age { get; set; }
        public void Display()
        {
            Console.WriteLine("Parent Class");
        }
    }
    public class HidingChildClass : HidingInheritedMember
    {
        public new int Age { get; set; }
        public new void Display()
        {
            Console.WriteLine("Child Class");
        }
    }

    public void TestMultilevelPolyMorphism()
    {
        MultilevelBaseClass multilevelBaseClass = new MultilevelBaseClass();
        MultilevelBaseClass multilevelDerivedClass1 = new MultilevelDerivedClass1();
        MultilevelBaseClass multilevelDerivedClass2 = new MultilevelDerivedClass2();
    }
    //Multilevel Inheritance uses polymorphism
    public class MultilevelBaseClass
    {
        //Grand Parent class
    }
    public class MultilevelDerivedClass1 : MultilevelBaseClass
    {
        //Parent class
    }
    public class MultilevelDerivedClass2 : MultilevelDerivedClass1
    {
        //Child class
    }
}
