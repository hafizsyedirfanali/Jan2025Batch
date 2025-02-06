
namespace _2_ObjectOrientedProgramming;
/// <summary>
/// Instance of struct is created in stack memory
/// whereas instance of class is created in heap memory
/// A structure is a blueprint.
/// a structure is a collection of structure members
/// such as 
/// 1. Properties
/// 2. Fields
/// 3. Methods
/// 4. Constructors
/// 5. Classes: Nested Classes
/// 6. Structures: Nested Structures
/// 7. DESTUCTORS are not available in struct
/// </summary>
public class _8_Structures
{
    public void Test()
    {
        int i = 10;
        Chair c = new Chair();//Class object - Heap memory
        Student s = new Student();//Struct object - Stack memory

    }
    public struct Student
    {
        //~Student()
        //{
        //    //Destructor are not required in struct and
        //    //they are not available in struct
        //}
    }
    public class Chair
    {
        ~Chair()
        {
            //Destructor
        }
    }
}
