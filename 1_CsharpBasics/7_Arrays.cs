namespace _1_CsharpBasics;

public class _7_Arrays
{
    public static void Test()
    {
        ThreeDimensionalArray();
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
        
        //printing the rollNos using for loop
        for (int i = 0; i < rollNos.Length; i++)
        {
            Console.WriteLine(rollNos[i]);
        }
        //Another example of storing chapter numbers
        int[] chapters = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        //printing the chapters using for loop
        for (int i = 0; i < chapters.Length; i++)
        {
            Console.WriteLine(chapters[i]);
        }
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
        ///    ARRAY
        ///    secondary index   0 1 
        ///    primary index  0  1 2
        ///                   1  3 4
        ///                   2  5 6
        ///                   3  7 8
        ///                   4  9 10
        ///                   


        //accessing values
        int topic0Ch0 = topics[0, 0];//reading value of array
        int topic1Ch0 = topics[0, 1];
        int topic1Ch1 = topics[1, 1];
        int topic0Ch1 = topics[1, 0];

        //printing the topics using for loop
        for (int ch = 0; ch < topics.GetLength(0); ch++)//5 times
        {
            for (int topic = 0; topic < topics.GetLength(1); topic++)//2 times
            {
                Console.Write(topics[ch, topic]+"   ");
            }
            Console.WriteLine();
        }
    }
    public static void ThreeDimensionalArray()
    {
        string[,,] topics = new string[5, 2, 3];
        //assigning values
        topics[0, 0, 0] = "CH0-T0-SubT0";
        topics[0, 0, 1] = "CH0-T0-SubT1";
        topics[0, 0, 2] = "CH0-T0-SubT2";
        topics[0, 1, 0] = "CH0-T1-SubT0";
        topics[0, 1, 1] = "CH0-T1-SubT1";
        topics[0, 1, 2] = "CH0-T1-SubT2";
        topics[1, 0, 0] = "CH1-T0-SubT0";
        topics[1, 0, 1] = "CH1-T0-SubT1";
        topics[1, 0, 2] = "CH1-T0-SubT2";
        topics[1, 1, 0] = "CH1-T1-SubT0";
        topics[1, 1, 1] = "CH1-T1-SubT1";
        topics[1, 1, 2] = "CH1-T1-SubT2";
        //and so on...
        //accessing values
        //to access "CH0-T0-SubT2"
        string topic0Ch0SubT2 = topics[0, 0, 2];
        //to access "CH1-T0-SubT0"
        string topic1Ch0SubT0 = topics[1, 0, 0];

        //printing the topics using for loop
        for (int ch = 0; ch < topics.GetLength(0); ch++)//5 times
        {
            for (int topic = 0; topic < topics.GetLength(1); topic++)//2 times
            {
                for (int subTopic = 0; subTopic < topics.GetLength(2); subTopic++)//3 times
                {
                    Console.Write(topics[ch, topic, subTopic] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------");
        }
    }
    public static void FourDimensionalArray()
    {
        int[,,,] topics = new int[5, 2, 3, 4];
        //assigning values
        topics[0, 0, 0, 0] = 1;
        topics[0, 0, 0, 1] = 2;
        topics[0, 0, 0, 2] = 3;
        topics[0, 0, 0, 3] = 4;
        topics[0, 0, 1, 0] = 5;
        topics[0, 0, 1, 1] = 6;
        topics[0, 0, 1, 2] = 7;
        topics[0, 0, 1, 3] = 8;
        topics[0, 0, 2, 0] = 9;
        topics[0, 0, 2, 1] = 10;
        topics[0, 0, 2, 2] = 11;
        topics[0, 0, 2, 3] = 12;
        topics[0, 1, 0, 0] = 13;
        topics[0, 1, 0, 1] = 14;
        topics[0, 1, 0, 2] = 15;
        topics[0, 1, 0, 3] = 16;
        topics[0, 1, 1, 0] = 17;
        topics[0, 1, 1, 1] = 18;
        topics[0, 1, 1, 2] = 19;
        topics[0, 1, 1, 3] = 20;
        topics[0, 1, 2, 0] = 21;
        topics[0, 1, 2, 1] = 22;
        topics[0, 1, 2, 2] = 23;
        topics[0, 1, 2, 3] = 24;
        topics[1, 0, 0, 0] = 25;
        topics[1, 0, 0, 1] = 26;
        //and so on...
        //accessing values
        //to access 24
        int topic0Ch1SubT2SubSubT3 = topics[0, 1, 2, 3];
    }
}
    