using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class BankAccount
    {
        private decimal balance;
        public BankAccount(decimal initialBalance) {
            this.balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }

        public decimal GetBalance() { return balance; }
    }

    class Banks
    {
        public static void Bank()
        {
            BankAccount myAccount = new BankAccount(1000);

            myAccount.Deposit(100);
            Console.WriteLine("Balance is: " + myAccount.GetBalance());

            myAccount.Withdraw(1000);
            Console.WriteLine("Balance is: " + myAccount.GetBalance());

            myAccount.Withdraw(2000);
            Console.WriteLine("Balance is: " + myAccount.GetBalance());


        }
    }
}
