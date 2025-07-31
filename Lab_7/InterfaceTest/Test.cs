namespace Utils
{
    using System;
    public class Test
    {
        public static void Main()
        {
            int i = 0;
            ulong ul = 0;
            string s = "Test";
            string message;
            Console.WriteLine(Utils.IsItFormattable(i));
            Console.WriteLine(Utils.IsItFormattable(ul));
            Console.WriteLine(Utils.IsItFormattable(s));
        }
    }
}

