using System;
using System.IO;
class FileDetails
{
    static void Main(string[] args)
    {
        string fileName = args[0];
        try
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            int size = (int)stream.Length;
            char[] contents = new char[size];
            for (int i = 0; i < size; i++)
            {
                contents[i] = (char)reader.Read();
            }
            reader.Close();

            Summarize(contents);
        }


        catch (FileNotFoundException)
        {
            Console.WriteLine($"Файл '{fileName}' не найден.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Произошла ошибка при работе с файлом: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    static void Summarize(char[] contents)
    {
        int vowelCount = 0;
        int consonantCount = 0;
        int lineCount = 1;

        foreach (char myCharacter in contents)
        {
            if (Char.IsLetter(myCharacter))
            {
                if ("AEIOUaeiou".IndexOf(myCharacter) != -1)
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
            else if (myCharacter == '\n')
            {
                lineCount++;
            }
        }

        Console.WriteLine("Общее количество символов: " + contents.Length);
        Console.WriteLine("Количество гласных букв: " + vowelCount);
        Console.WriteLine("Количество согласных букв: " + consonantCount);
        Console.WriteLine("Число строк в файле: " + lineCount);
    }
}

