namespace _2_ObjectOrientedProgramming;
/// <summary>
/// A class is a blueprint.
/// a class is a collection of class members
/// such as 
/// 1. Properties
/// 2. Fields
/// 3. Methods
/// 4. Constructors
/// 5. Destructor
/// 6. Classes
/// 7. Structures (structs)
/// </summary>
public class _1_Classes
{
    public static void Test()
    {
        //A class as a blueprint
        Student s1 = new Student();
        s1.age = 10;
        int age = s1.age;
        s1.name = "Abcd";
        s1.gender = "M";
        s1.rollNo = 1;
        s1.mobileNo = "3324324";

        Student s2 = new Student();
        s2.age = 10;
        s2.name = "Abcd";
        s2.gender = "M";
        s2.rollNo = 1;
        s2.mobileNo = "3324324";

        //new keyword is used to create an object of a class
        //it request OS for memory allocation
        //in return it brings starting address of the memory

        //here s1 and s2 are objects of Student class,
        //they are called as instances of Student class
        //or reference variables : they are used to store the address of the memory
        //or pointers : they are used to point to the memory location
        //Instantiation : creating an object/instance of a class



    }
    public class Student
    {
        public int rollNo;
        public string name;
        public int age;
        public string gender;
        public string mobileNo;
    }
}
