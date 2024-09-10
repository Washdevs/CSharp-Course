using ClassesAbstratas.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
//AL 12 - Classes Abstratas
namespace ClassesAbstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>
            {
                new SavingsAccount(1001, "Marcia", 500.0, 0.01),
                new BusinessAccount(1002, "Manuel", 500.0, 400.0),
                new SavingsAccount(1003, "Bruna", 500.0, 0.01),
                new SavingsAccount(1004, "Claudio", 500.0, 0.01)
            };
            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine("Total Balance: " + sum.ToString("f2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }
            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                + acc.Number
                + ": "
                + acc.Balance.ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}