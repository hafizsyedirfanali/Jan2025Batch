namespace _2_ObjectOrientedProgramming;
/// <summary>
/// Inheritance is a mechanism in which 
/// one class acquires the properties and 
/// behavior of another class.
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
}
