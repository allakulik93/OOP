using System;
class Greeter
{
    static void Main(string[] args)
    {
        string MyName;
        Console.WriteLine("Please enter your name");
        MyName = Console.ReadLine();
        Console.WriteLine("Hello {0}", MyName);
    }

}
