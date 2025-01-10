namespace _1_CsharpBasics;
/// <summary>
/// The operators may be either unary or binary
/// unary operator requires a single operand
/// binary operator requires two operands
/// a + b (in this + is operator and a is left operand and b is right operand)
/// There are several types of operators
/// 1. Arithmatical [done]
/// 2. Logical
/// 3. Relational [done]
/// 4. Conditional
/// 5. Bitwise
/// 6. Increment/Decrement
/// 7. Assignment [done]
/// </summary>
public class _3_Operators
{
    public static void Test()
    {

    }
    public static void Relational()
    {
        int a = 10, b = 20; bool result;
        //equal to 
        result = a == b; //is a and b equal? if equal => true or if not equal => false
        //not equal to
        result = a != b; //is a and b unequal? if not equal => true or if equal => false
        //greater than
        result = a > b; //is a greater than b?
        //greater than and equal to
        result = a >= b; // is a greater or equal to b?
        //less than
        result = a < b; //is a less than b?
        //less than and equal to
        result = a <= b; //is a less or equal to b?
    }
    public static void Assignment()
    {
        // = 
        int a = 10;

        //with addition
        a = a + 1;
        a += 1;//same as a = a + 1 
        //with subtraction
        a = a - 1;
        a -= 1;

        //with multiplication
        a *= 2;

        //with div (quotient)
        a = a / 2;//if a = 11 => a/2 => 5 => a = 5
        a /= 2;
        //with div (remainder)
        a = a % 2;//if a = 11 => a%2 => 1 => a = 1
        a %= 2;
    }
    public static void Arithmatic()
    {
        int result, a, b;
        a = 10; b = 20;
        //addition
        result = a + b;

        //subtraction
        result = a - b;

        //multiply
        result = a * b;

        //division for quotient
        result = a / b;

        //division for remainder
        result = a % b;

    }
}
