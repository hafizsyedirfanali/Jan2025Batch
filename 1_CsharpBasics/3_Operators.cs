namespace _1_CsharpBasics;
/// <summary>
/// The operators may be either unary or binary
/// unary operator requires a single operand
/// binary operator requires two operands
/// a + b (in this + is operator and a is left operand and b is right operand)
/// There are several types of operators
/// 1. Arithmatical [done]
/// 2. Logical [done]
/// 3. Relational [done]
/// 4. Conditional (Ternary,...)
/// 5. Bitwise [done]
/// 6. Increment/Decrement [done]
/// 7. Assignment [done]
/// </summary>
public class _3_Operators
{
    public static void Test()
    {
        IncrementDecrement();
    }
    public static void Conditional()
    {
        //Ternary operator ? :
        //example 1
        int i = 100, j;
        j = i > 15 ? 10 : i;

        //example 2
        int marks = 15;
        string result = marks >= 40 ? "PASS" : "FAIL";
        //if marks = 15
        //     result =   15 >=  40 ? "PASS" : "FAIL";
        //     result =   false     ? "PASS" : "FAIL";
        //     result =   "FAIL";
        //  OR
        //if marks = 50
        //     result =   50 >=  40 ? "PASS" : "FAIL";
        //     result =   true     ? "PASS" : "FAIL";
        //     result =   "PASS";

        //example 3
        int a;
        byte b = 10;
        a = b > 10 ? 10 : b;
        //= logical expr/relational expr ? (if true) : (if false); 
    }
    public static void IncrementDecrement()
    {
        // ++ and -- are increment and decrement operators
        //both are unary.
        //each has two sub types
        //1. Preincrement and post increment
        //2. Predecrement and post decrement

        int i = 10;
        //increment
        i++;
        ++i;
        //decrement
        i--;
        --i;
        //Preincrement
        Console.WriteLine(++i);
        //Post increment
        Console.WriteLine(i++);
        //Predecrement
        Console.WriteLine(--i);
        //Post decrement
        Console.WriteLine(i--);

        Console.WriteLine("----------------------");
        i = 10;
        int j = --i + i++;
        //in above equation, initially --i will be executed
        //i will become 9;
        //equation will become j = 9 + 9(post incr)
        //j = 18 will be assigned to j and then i will increment to 10
        i = 10;
        j = i++ + ++i;//a+b+c
        i = 10;
        j = --i + --i;
        //= --10 + --10;
        //=    9 + --9;
        //=    9 +   8;
        //=    17
        Console.WriteLine(j);
        Console.WriteLine(i);
    }
    public static void Bitwise()
    {
        //Bitwise ANDing
        //decimal   binary
        //   7        111
        //   4        100
        //  7&4       100
        int i = 7, j = 4, result;
        
        result = i & j;

        //Bitwise ORing
        //decimal   binary
        //   7        111
        //   4        100
        //  7|4       111
        result = i | j;

        //Bitwise shift operators
        //decimal   binary
        //   7        111
        // right      011
        result = i >> 1;//right shift by one bit
        result = i >> 2;//right shift by two bits
        //decimal   binary
        //   7        111
        // left      1110
        result = i << 1;//left shift by one bit
        result = i << 2;//left shift by two bits
        Console.WriteLine(result);
        ///0000 - 0
        ///0001 - 1
        ///so on
        ///1100 - 12
        ///1101 - 13
        ///1110 - 14
        ///1111 - 15


    }
    public static void Logical()
    {
        //ANDing, ORing, and NOT
        bool student1 = true, student2=true, student3=true;
        bool lecture;
        //ANDing - && (Binary)
        //If both the operands (Left and right) are true then result is true, else false.
        lecture = student1 && student2 && student3;

        //ORing - || (Binary)
        //If any one operand (Left or right) is true then result is true, else false. 
        lecture = student1 || student2 || student3;

        //NOT - ! (Unary)
        //If operand is true then result is false and vice versa
        lecture = !student1;
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

        //bitwise shift and assign
        a = 3;//11
        a <<= 1;//left shift by one bit = result = 110
        a >>= 1;//right shift by one bit = result=  11
        a >>= 1;//right shift by one bit = result=   1
        //bitwise ANDing ORing and assign
        a = 3;//11
        a &= 2;//11 and 10 => result = 10

        a = 3;//11
        a |= 2;//11 or 10 => result = 11

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
