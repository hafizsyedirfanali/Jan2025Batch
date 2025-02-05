namespace _2_ObjectOrientedProgramming;
/// <summary>
/// With every class there is a hidden default parameterless constructor
/// When we create our own constructor (parameterless or parameterized) then hidden constructor
/// is overridden
/// A class can have multiple constructors called constructor overloading
/// 
/// When we invoke the constructor using 
/// new keyword then the constructor creates the class instance
/// and after instantiation it immediately executes the 
/// instructions (block of code) within the curly braces
/// </summary>
public class _5_Constructors
{
    public void Test()
    {
        Student s = new Student();//We are specifying
        //to the new keyword that tell the constructor
        //to create class instance
        Student s1 = new Student(10);
        Student s2 = new Student(20,30);
        s2.Age = 10;
        s2.Name = "Abc";
        Student s3 = new Student(20,"Abc");
    }
    public class Student
    {
        //this is a class with 
        //three overloaded versions
        //of constructors
        public Student()
        {
            Console.WriteLine("Student object is created");
        }
        public Student(int a)
        {
            
        }
        public Student(int a, int b)
        {
            
        }
        public Student(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public int Age { get; set; }
        public string Name { get; set; }
    }  
    public class Teacher
    {
        public int A { get; set; }
        public int B { get; set; }

        //Here constructor is initially creates instance of the class
        //secondly it will execute the instructions A = a; B = b;
        public Teacher(int a, int b)
        {
            A = a; B = b;
        }
    }
}
