using System;
using System.IO;
public class CopyFileUpper
{
    public static void Main()
    {
        string sFrom;
        string sTo;
        StreamReader srFrom;
        StreamWriter swTo;
        Console.WriteLine("Enter a file input name: ");
        sFrom = Console.ReadLine();
        Console.WriteLine("Enter a file output name: ");
        sTo = Console.ReadLine();

        try
        {

            srFrom = new StreamReader(sFrom);
            swTo = new StreamWriter(sTo);

            while (srFrom.Peek() != -1)
            {
                string Sbuffer = srFrom.ReadLine();
                Sbuffer = Sbuffer.ToUpper();
                swTo.WriteLine(Sbuffer);

            }
            swTo.Close();
            srFrom.Close();
        }

        catch (FileNotFoundException e)
        {
            Console.WriteLine("File does not exist");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error");
            Console.WriteLine(e.ToString());
        }
    }
}

