using System;
namespace HerançaMultipla.Entities
{
    internal class Scanner : Device, IScanner
    {
        // Implementeação do Device
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scaner Processing: " + document);
        }

        // Implementação da Interface
        public string Scan()
        {
            return "Scanner Scan Result";
        }
    }
}