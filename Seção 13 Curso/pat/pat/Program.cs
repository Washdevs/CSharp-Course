using System;
using System.IO;

namespace filepath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Windows\Temp\myfolder\file1.txt";
            Console.WriteLine(Path.GetDirectoryName(filePath));
        }
    }
}