using HerançaMultipla.Entities;
using System;
namespace HerançaMultipla 
{
    internal class Program 
    {
        static void Main(string[] args) 
        { 
            Printer p = new Printer() { SerialNumber = 1080 }; 
            p.processDoc("My letter");
            p.print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2080 };
            s.processDoc("My Email");
            Console.WriteLine(s.Scan());
        } 
    }
} 