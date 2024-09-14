using System;
using System.IO;
namespace diretory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\myfolder";

            try
            {
                var folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                // usamos var para facilitar e não precisar IEnumerable<string> que é o tipo desta operação
                Console.WriteLine("Folders: ");
                foreach (string item in folder)
                {
                    Console.WriteLine(item);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                var arq = Directory.CreateDirectory(path + "\\newFolder");// pode também @"C:\Windows\Temp\myfolder\newFolder"
            }
            catch (Exception e)
            {
                Console.WriteLine("Um erro foi encontrado: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}