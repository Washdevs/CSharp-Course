using System;
using System.IO;

namespace Streamwriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Windows\Temp\file1.txt";
            string targetPath = @"C:\Windows\Temp\file3.txt"; 
               
            try 
            {
                string[] line = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string lines in line)
                    {
                        sw.WriteLine(lines.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.Write("Um Erro Ocorreu: ");
                Console.WriteLine(e.Message);
            }
        } 
    } 
} 