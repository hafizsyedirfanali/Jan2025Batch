namespace _2_ObjectOrientedProgramming;
/// <summary>
/// Fields in a class are variables that can store data.
/// Fields are generally kept private and are used locally.
/// Mostly they are used with dependency injection???.
/// fields are written with first letter small case (lower camel case)
/// or they are also written with underscore e.g. _name, _age
/// </summary>
public class _3_Fields
{
    public void Test()
    {
        TestField t = new TestField();
        t.Init();
        t.Add();
        //t.Sum = 20;//private set properties are readonly externally
        Console.WriteLine(t.Sum);
        t.FindArea();
        Console.WriteLine(t.Area);
    }
    public class TestField
    {
        private int _value;
        private int a;
        private int b;
        private int radius;
        private readonly float _PI = 3.14f;
        //public float PI { get; } = 3.14f;//use field to hide PI externally
        public int Sum { get; private set; }
        public float Area { get; private set; }
        public void Init()
        {
            a = 10;
            b = 20;
            radius = 2;
        }
        public void Add()
        {
            Sum = a + b;
        }
        public void FindArea()
        {
            //_PI = 33;//pi is a constant and should not be changed
            Area = _PI * radius * radius;
        }
    }
}
