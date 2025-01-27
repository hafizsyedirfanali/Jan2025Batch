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
        s1.Age = 10;
        int age = s1.Age;
        s1.Name = "Abcd";
        s1.Gender = "M";
        s1.RollNo = 1;
        s1.MobileNo = "3324324";

        Student s2 = new Student();
        s2.Age = 10;
        s2.Name = "Abcd";
        s2.Gender = "M";
        s2.RollNo = 1;
        s2.MobileNo = "3324324";

        //new keyword is used to create an object/instance of a class
        //it request OS for memory allocation
        //in return it brings starting address of the memory

        //here s1 and s2 are objects of Student class,
        //they are called as instances of Student class
        //or reference variables : they are used to store the address of the memory
        //or pointers : they are used to point to the memory location
        //Instantiation : creating an object/instance of a class

        Chair chair = new Chair();
        chair.Height = 25;
        chair.Width = 20;
        chair.Type = "Rolling";
        chair.BrandName = "ABCD";
        chair.Cost = 1000;
        Console.WriteLine($"Height: {chair.Height} and Width:{chair.Width}");
        //create class for Mobile, Laptop, Car, etc. Add properties to them.
        //Create their objects. Assign values and print them

    }
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
    }
    public class Chair
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string Type { get; set; }
        public string BrandName { get; set; }
        public int Cost { get; set; }
    }
}
