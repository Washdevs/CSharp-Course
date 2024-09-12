using System;
using System.IO;
namespace usingblock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Windows\Temp\file1.txt";
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.Write("Erro: ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}