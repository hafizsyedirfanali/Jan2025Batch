namespace _1_CsharpBasics;

public class _7_Arrays
{
    public static void Test()
    {

    }
    public static void BasicArray()
    {
        //                0  1  2  3  4
        int[] rollNos = [ 1, 2, 3, 4, 5 ];
        //accessing array elements
        Console.WriteLine(rollNos[0]);//1
        Console.WriteLine(rollNos[1]);//2

        //changing array elements
        rollNos[1] = 20;
        Console.WriteLine(rollNos[1]);//20

        // doubling the value and storing in the same place
        for (int i = 0; i < rollNos.Length; i++)
        {
            rollNos[i] *= 2;
        }

        // printing the updated array
        foreach (var rollNo in rollNos)
        {
            Console.WriteLine(rollNo);
        }
        //NOTE: use for loop when you need to change the elements of the array
        //use foreach when you need to read the elements of the array
    }
    public static void OneDimensionalArray()
    {
        //1D array
        //datatype[] arrayName = new datatype[size];
        int[] rollNos = [1, 2, 3, 4, 5];
        //OR
        int[] rollNos2 = { 1, 2, 3, 4, 5 };//object notation
        //OR
        int[] rollNos3 = new int[5];
        //assigning values
        rollNos3[0] = 1;
        rollNos3[1] = 2;
        rollNos3[2] = 3;
        rollNos3[3] = 4;
        rollNos3[4] = 5;
        //OR
        int[] rollNos4 = new int[5] { 1, 2, 3, 4, 5 };
        //OR
        int[] rollNos5;//label declaration
        rollNos5 = new int[5];//memory allocation
        rollNos5[0] = 1;//assigning values
        rollNos5[1] = 2;
        //Another example of storing chapter numbers
        int[] chapters = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    }
    public static void TwoDimensionalArray()
    {
        int[,] topics = new int[5, 2];
        //this means there are 5 chapters and two topics in each chapter
        //assigning values
        topics[0, 0] = 1;
        topics[0, 1] = 2;
        topics[1, 0] = 3;
        topics[1, 1] = 4;
        topics[2, 0] = 5;
        topics[2, 1] = 6;
        topics[3, 0] = 7;
        topics[3, 1] = 8;
        topics[4, 0] = 9;
        topics[4, 1] = 10;

    }
}
    