using System;
using System.Collections.Generic;
namespace ConjuntosHasheSorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (string s in set)
            {
                Console.WriteLine(s);
            }
        }
    }
}