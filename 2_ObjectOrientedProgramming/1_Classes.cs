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
