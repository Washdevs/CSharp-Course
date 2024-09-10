using herança.Entities;
using herança.Entities.NewFolder1;
using System;
namespace herança  // Aula - Herança // Aula - Upcasting e Downcasting // Aula - Sobreposição, palavras virtual, override e base //
{ 
    internal class Program
    { 
        static void Main(string[] args)
        { 
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0); // deve ser igual à ordem das prop nos construtores //
             Console.WriteLine(account.LoanLimit);
             
            // account.Balance = 200.0; //Erro por ser protected

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bcc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING //

            Account acc1 = bcc;
            Account acc2 = new BusinessAccount(1003, "bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1001, "Anna", 0.0, 0.01);

            // DOWNCASTING //

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.loan(100.0);
            // acc2.loan(100.0); ERRO! * não funciona pois ela já esta no escopo global - acc2 * //
      
            if (acc3 is BusinessAccount) {
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.loan(200.0);
                Console.WriteLine("Loan");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }
        }
    }
} 