using System;
namespace HerançaMultipla.Entities
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice Processing: " + document);
        }
        public string Scan()
        {
            return "ComboDevice Scan Result";
        }
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice Print: " + document);
        }
    }
}