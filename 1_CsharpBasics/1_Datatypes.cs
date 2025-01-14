namespace _1_CsharpBasics
{
    /// <summary>
    /// Memory are basically classified in two types
    /// 1. Stack - Limited
    /// 2. Heap - Unlimited (upto RAM capacity)
    /// Datatypes are of two types:
    /// 1. Valued - integer, fractional, boolean, character
    ///     they are stored in stack
    ///     these are disposed/deleted at the end of scope
    ///     Life starts where it is declared and ends at the end of scope
    /// 2. Referenced (pointers) - string, ...
    ///     they are stored in heap
    ///     when the labels are deleted at the end of scope,
    ///     their values are now called as garbage/unreferenced data.
    ///     these are disposed/deleted by the GC
    /// 3. Nullables in Valued 
    /// 4. Nullables in Referenced (Version Gap)
    /// </summary>
    public class _1_Datatypes
    {
        public static void Test()
        {
            IntegerDatatype();
        }
        public static void NullableReferenceType()
        {
            string? s = null;
            //more types
        }
        public static void NullableValuedType()
        {
            //Nullabe types are decorated with Question Mark '?'
            byte? b = null;
            short? s = null;
            int? i = null;
            long? l = null;
            Int128? big = null;

            float? fl = null;
            double? d = null;
            decimal? dm = null;

            bool? bl = null;

            char? ch = null;

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
            /// 3. Int 4 Bytes - 32bits (2147483647 [ 0 to 2147483646]
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
            UInt128 unsignedI = 10;
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
        public static void BooleanDatatype()
        {
            bool b = true;
            b = false;
        }
        public static void CharacterDatatype()
        {
            char c = 's';
        }
        public static void StringDatatype()
        {
            string s = "Hello";
            s = "world";
        }
    }
}
