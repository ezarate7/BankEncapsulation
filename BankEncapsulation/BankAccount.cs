using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double balance = 0;
        
        public void Deposit(double deposit)
        {
            balance += deposit;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Withdraw(double withdraw)
        {
            balance -= withdraw;
        }

        public void WorkCheck(double thatMoney)
        {
            for (int i = 0; i < 365; i += 14)
            {
                Deposit(thatMoney);
                Console.WriteLine(GetBalance());
            }

        }

    }
}
        
        

            



