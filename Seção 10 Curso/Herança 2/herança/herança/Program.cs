﻿using herança.Entities;
using herança.Entities.NewFolder1;
using System;
namespace herança  // Aula - Herança // Aula - Upcasting e Downcasting // Aula - Sobreposição, palavras virtual, override e base //
    // Polimorfismo //
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }   
}