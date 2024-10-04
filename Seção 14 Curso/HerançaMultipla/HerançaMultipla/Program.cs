using HerançaMultipla.Entities;
using System;
namespace HerançaMultipla
{
    internal class Program
    {
        static void Main()
        {
            // Abaixo apenas um código para testar LINQ 

            //var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }; 
            //var pares = numeros.Where(n => n % 2 == 0).ToList(); 
            //Console.WriteLine(numeros.Average());
            //Console.WriteLine(pares.Average()); 

            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2080 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3080 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());

        }
    }
}