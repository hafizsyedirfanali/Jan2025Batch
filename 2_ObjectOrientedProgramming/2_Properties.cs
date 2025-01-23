namespace _2_ObjectOrientedProgramming;
/// <summary>
/// A property is a type of variable 
/// that can be customised for getting and setting
/// get - is used to get or read the value of property
/// set - is used to set or add/update/write the value into the property
/// the methods responsible for getting is called getter and similarly
/// the methods responsible for setting is called setter
/// A property is a member of a class
/// A property is not accessible directly. 
/// we can access it using getter and setter methods only.
/// </summary>
public class _2_Properties
{
    public static void Test()
    {
        //read operation
        int i = 10;
        int j = i;//read operation. reading value of i
        i = j; //writing operation. writing value into i

        TestClass t = new TestClass();
        t.ASimpleProperty = 10;//this assigning task is done by setter method

        int value = t.ASimpleProperty;//getter method will copy the value from property and returns that value
    }
    public class TestClass
    {
        //simple property
        public int ASimpleProperty { get; set; }
    }
}
