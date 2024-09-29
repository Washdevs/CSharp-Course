using System;
namespace HerançaMultipla.Entities
{ 
    internal class Printer : Device
    { 
        public override void processDoc(string document)
        {
            Console.WriteLine($"Processando o documento: {document}");
        }

        public void print(string doc) { }
    }
}