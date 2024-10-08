﻿using System;
using System.IO;
namespace FileInfoeIOException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Windows\Temp\file1.txt";
            string targetPath = @"C:\Windows\Temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu " + e.Message);
            }
        }
    }
}