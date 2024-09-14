using System;
using System.IO;
namespace filepath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\myfolder\file1.txt";
            Console.WriteLine("Char separador: " + Path.DirectorySeparatorChar);
            Console.WriteLine("Separador do Diretório: " + Path.PathSeparator);
            Console.WriteLine("Nome do diretório: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetInvalidFileNameChars: " + Path.GetInvalidFileNameChars());
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}