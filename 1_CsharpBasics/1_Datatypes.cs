using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1_CsharpBasics
{
    public class _1_Datatypes
    {
        public static void Test()
        {
            IntegerDatatype();
        }

        public static void IntegerDatatype()
        {
            ///0  00
            ///1  01
            ///2  10
            ///3  11
            ///4  100
            ///5  101
            ///6  110
            ///7  111
            ///8  1000
            /// Formula 2 ^ n

            /// 1. Byte 1 Byte - 8bits (256 [ 0 to 255] )
            /// 2. Short 2 Bytes - 16bits (65536 [ 0 to 65535] )
            /// 3. Int 4 Bytes - 32bits (18,446,744,073,709,551,61618,446,744,073,709,551,616 [ 0 to 18,446,744,073,709,551,61618,446,744,073,709,551,615]
            /// 4. Long 8 Bytes - 64bits (
            /// 5. BigInt 16 Bytes - 128Bits (
            /// 
            byte b = 255;// 0 to 255
            sbyte sb = 127;//-128 to 127
            short ss = 32767; //32767 to 32768
            ushort us = 65535;//0 to 65535
            int si = 2147483647; //-2147483648 to 2147483647
            uint ui = 4294967295;//0 to 4294967295
            long sl = 10;//??
            ulong ul = 0;//??
            Int128 bi = 10;//Big int
        }

        public static void FractionalDatatype()
        {
            //3.142
            //float (4 byte),
            //double (8bytes),
            //decimal (16bytes) Most accurate (algorithm designed for precision)
            float f = 1.1f;
            double d = 1.1d;
            decimal dm = 1.1m;
        }
        //boolean, char, string
    }
}
