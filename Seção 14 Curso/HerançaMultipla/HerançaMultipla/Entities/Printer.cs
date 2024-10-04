using System;
namespace HerançaMultipla.Entities
{
    internal class Printer : Device, IPrinter
    {
        // Implementação do Device
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer Processing: " + document);
        }
        // Implementação da Interface
        public void Print(string document)
        {
            Console.WriteLine("Printer Print " + document);
        }
    }
}