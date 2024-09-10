using System;
using System.Collections.Generic;
using ExercicioProposto.Entities;

namespace ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Digite o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Dados do produto #{i + 1}:");

                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char type = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine());

                if (type == 'c')
                {
                    products.Add(new Product(name, price));
                }
                else if (type == 'i')
                {
                    Console.Write("Taxa de alfândega: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (type == 'u')
                {
                    Console.Write("Data de fabricação (DD/MM/AAAA): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
            }

            Console.WriteLine("\nETIQUETAS DE PREÇO:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
