using System;
    class DivideIt
    {
        static void Main(string[] args)
        {
        try
        {
            int i, j, k;
            string temp;
            Console.WriteLine("Enter first number");
            temp = Console.ReadLine();
            i = Int32.Parse(temp);
            Console.WriteLine("Enter second number");
            temp = Console.ReadLine();
            j = Int32.Parse(temp);
            k = i / j;
            Console.WriteLine(k);
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine("Division by zero error!");
        }
        catch(Exception e)
        {
            Console.WriteLine("Invalid value entered");
        }
    }
}
