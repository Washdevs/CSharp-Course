using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herança.Entities.NewFolder1
{ 
     class SavingsAccount : Account
    {
        public double InterestRsate { get; set; }

        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRsate = interestRate;
        }

        public void UpdateBalance ()
        {
            Balance += Balance * InterestRsate;
        }

        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
} 