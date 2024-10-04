using Generics.Services;
using System;
namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            try
            {
                Console.WriteLine("Quantos numero deseja de 1 a 10?");
                int n = int.Parse(Console.ReadLine());

                if (n < 1 || n > 10)
                {
                    Console.WriteLine("Por favor, insira um número entre 1 e 10.");
                    return;
                }

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Digite o valor {i + 1}:");
                    int value = int.Parse(Console.ReadLine());
                    printService.AddValue(value);
                }
                printService.Print();
                Console.WriteLine("First value: " + printService.First());
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro Ocorrido: " + e.Message);
            }
        }
    }
}