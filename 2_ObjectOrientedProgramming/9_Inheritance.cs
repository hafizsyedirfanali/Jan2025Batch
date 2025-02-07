namespace _2_ObjectOrientedProgramming;
/// <summary>
/// Inheritance is a mechanism in which 
/// one class acquires the properties and 
/// behavior of another class.
/// Advantages of Inheritance:
/// 1. Code Reusability - We can reuse the fields and methods of the existing class.
/// 2. Method Overriding
/// 3. Code Maintenance easy - If we want to change the implementation of a method, we can change in the parent class and it will be reflected in all the child classes.
/// 4. Polymorphism
/// 
/// Types of Inheritance:
/// 1. Single Inheritance - A class is derived from only one base class.
/// </summary>
public class _9_Inheritance
{
    public void Test()
    {
        ParentClass p = new ParentClass();
        p.Name = "Parent";
        p.Age = 10;
        p.Gender = "Male";
        ChildClass c = new ChildClass();
        c.Name = "Child";
        c.Age = 10;
        c.Gender = "Female";
    }
    public class ParentClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
    public class ChildClass : ParentClass
    {
    }
    //Single Inheritance
    public class SingleBaseClass//Parent class/Super class
    {

    }
    public class SingleDerivedClass : SingleBaseClass
    {
        //Child class/Sub class
    }

    //Multilevel Inheritance
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
    //Hierarchical Inheritance
    public class HierarchicalBaseClass
    {
        //Parent class
    }
    public class HierarchicalDerivedClass1 : HierarchicalBaseClass
    {
        //Child class
    }
    public class HierarchicalDerivedClass2 : HierarchicalBaseClass
    {
        //Child class
    }
    public class HierarchicalDerivedClass3 : HierarchicalBaseClass
    {
        //Child class
    }
    //Hybrid Inheritance: Combination of Hierarchical and Multilevel Inheritance
    public class HybridBaseClass
    {
        //Parent class
    }
    public class HybridDerivedClass1 : HybridBaseClass
    {
        //Child class
    }
    public class HybridDerivedClass2 : HybridBaseClass
    {
        //Child class
    }
    public class HybridDerivedClass3 : HybridDerivedClass1
    {
        //Child class
    }
    //Multiple Inheritance: C# does not support multiple inheritance
    public class MultipleBaseClass1
    {
        //Parent class
    }
    public class MultipleBaseClass2
    {
        //Parent class
    }
    //public class MultipleDerivedClass : MultipleBaseClass1, MultipleBaseClass2
    //{         //Child class
    //}

}
