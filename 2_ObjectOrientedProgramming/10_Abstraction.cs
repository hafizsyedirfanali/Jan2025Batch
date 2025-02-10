namespace _2_ObjectOrientedProgramming;
/// <summary>
/// Abstraction is the concept of hiding the complex implementation details 
/// and showing only the necessary features of the object.
/// In other words, it is hiding the implementation and showing the definition.
/// we can achieve this with abstract classes and interfaces.
/// </summary>
public class _10_Abstraction
{
    public void Test()
    {

    }
    ///Using Abstract Class : It shows only defination of the method and hides the implementation.
    ///
    public abstract class Shape
    {
        public abstract int MyProperty { get; set; }
        public abstract void Draw();//Abstract method: It has no implementation
    }
    public class Circle : Shape //Contract: Circle class must implement all abstract members
    {
        private int _myVar;
        public override int MyProperty { get
            {
                return _myVar;
            }
            set
            {
                _myVar = value;
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}

