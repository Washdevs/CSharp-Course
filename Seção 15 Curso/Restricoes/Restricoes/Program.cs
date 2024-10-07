using Restricoes.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Restricoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            CalculationService calculo = new CalculationService();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            try
            {
                if (n < 1 || n > 10)
                {
                    Console.WriteLine("Por favor, insira um número entre 1 e 10.");
                    return;
                }

                for (int i = 0; i < n; i++)
                {
                    string[] vect = Console.ReadLine().Split(',');
                    string name = vect[0];
                    double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                    Console.WriteLine($"Digite o Produto {i + 1}:");
                    list.Add(new Product(name, price));
                }

                Product max = calculo.Max(list);

                Console.WriteLine("Most expensive: ");
                Console.WriteLine(max);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro Ocorrido: " + e.Message);
            }
        }
    }
}