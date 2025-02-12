namespace _2_ObjectOrientedProgramming;
/// <summary>
/// Abstraction is the concept of hiding the complex implementation details 
/// and showing only the necessary features of the object.
/// In other words, it is hiding the implementation and showing the definition.
/// we can achieve this with abstract classes and interfaces.
/// </summary>
public class _11_Abstraction
{
    public void Test()
    {
        Shape s = new Circle();//Shape class is not capable of performing actions 
        //therefore we call Circle class because it implements the Shape class
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
        public override int MyProperty { 
            get
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
    //Using Interface - It shows only defination of the method and hides the implementation.
    public interface IShape
    {
        public int MyProperty { get; set; }
        public void Draw();
    }
    public class Triangle : IShape //Its a contract that Triange class will implement IShape interface
    {
        private int _myVar;
        public int MyProperty
        {
            get
            {
                return _myVar;
            }
            set
            {
                _myVar = value;
            }
        }
        public void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}

