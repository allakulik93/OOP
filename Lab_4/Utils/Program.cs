using System;
using System.Globalization;
namespace Utils
{
    internal class Utils
    {
        //*public static int Greater(int a, int b)
       // {
         //   return (a > b) ? a : b;
        //}
        //class Test
        //{
        //}

        //public static void Swap(ref int a, ref int b)
        //{
          //  int temp;
            //temp = a;
            //a = b;
            //b = temp;
        //}
       // public static bool Factorial(int n, out int answer)
        //{
          //  if (n < 0)
            //{
              //  throw new ArgumentException("Factorial is not defined for negative numbers");
            //}
            //answer = 1;
            //for (int i = 1; i <= n; i++)
            //{
              //  answer *= i;
            //}
            //return true; 
        //}
        public static int RecursiveFactorial(int n)
        {
            if (n ==1)
            {
                return 1;
            }
            else
            {
                return n * RecursiveFactorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rec:");
            string Rec;
            Rec = Console.ReadLine();
            int Num;
            Num = int.Parse(Rec);
            Console.WriteLine(RecursiveFactorial(Num));
            //Console.WriteLine("Please enter x ");
            //string x = Console.ReadLine();
            //int IntX = int.Parse(x);
            //int result;
            //if (Factorial(IntX, out result)) 
            //{
            //  Console.WriteLine(result);
            //}
            //else
            //{
            //  Console.WriteLine("Factorial calculation error");
            //}
        }
    }
}
