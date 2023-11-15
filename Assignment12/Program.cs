using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Example of usage:
        // Create a new file
        CreateFile("example.txt", "Initial content");

        // Read the content of the file
        ReadFile("example.txt");

        // Append content to the file
        AppendToFile("example.txt", "\nAppended content");

        // Read the updated content
        ReadFile("example.txt");

        // Delete the file
        DeleteFile("example.txt");
    }

    static void CreateFile(string fileName, string content)
    {
        File.WriteAllText(fileName, content);
        Console.WriteLine($"File '{fileName}' created successfully.");
    }

    static void ReadFile(string fileName)
    {
        try
        {
            string content = File.ReadAllText(fileName);
            Console.WriteLine($"Content of '{fileName}':\n{content}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{fileName}' not found.");
        }
    }

    static void AppendToFile(string fileName, string contentToAppend)
    {
        try
        {
            File.AppendAllText(fileName, contentToAppend);
            Console.WriteLine($"Content appended to '{fileName}' successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{fileName}' not found.");
        }
    }

    static void DeleteFile(string fileName)
    {
        try
        {
            File.Delete(fileName);
            Console.WriteLine($"File '{fileName}' deleted successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{fileName}' not found.");
        }
    }
}