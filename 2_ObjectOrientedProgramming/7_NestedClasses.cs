namespace _2_ObjectOrientedProgramming;

public class _7_NestedClasses
{
    public void Test()
    {
        PrimaryClass p = new PrimaryClass();

        PrimaryClass.SecondaryClass s =
            new PrimaryClass.SecondaryClass();

        PrimaryClass.SecondaryClass.TertiaryClass t =
            new PrimaryClass.SecondaryClass.TertiaryClass();
    }   
    public class PrimaryClass
    {
        public class SecondaryClass
        {
            public class TertiaryClass
            {
            }
        }
    }

}
