using System;
using System.IO;

namespace ReadFileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "asdf.txt";

            try
            {
                string fileContent = File.ReadAllText(fileName);
                Console.WriteLine(fileContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
