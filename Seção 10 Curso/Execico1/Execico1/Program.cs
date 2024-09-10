using System;
using System.Collections.Generic;
using Execico1.Entities;

// Exercício - Parte 1

namespace Execico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Digite o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nFuncionário #{i + 1} dados:");
                Console.Write("É terceirizado (s/n)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (ch == 's')
                {
                    Console.Write("Despesa adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("\nPagamentos:");
            foreach (Employee emp in employees)
            {
                // Exibe corretamente o nome e pagamento
                Console.WriteLine($"{emp.Name} - R$ {emp.Payment():F2}");
            }
        }
    }
}
