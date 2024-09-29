using System;
namespace HerançaMultipla.Entities
{
    internal class Scanner : Device
    {
        public override void processDoc(string document)
        {
            Console.WriteLine($"Processando o documento: {document}");
        }

        public string Scan()
        {
            return "Scanner Scan Result";
        }
    }
}