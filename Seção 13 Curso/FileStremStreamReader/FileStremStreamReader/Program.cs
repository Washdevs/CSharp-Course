using System;
using System.IO;
namespace FileStremStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\file1.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) // E !sr.EndOfStream vai mostrar as linhas
                                        //enquanto sr não tiver terminado
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ocorrido: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}