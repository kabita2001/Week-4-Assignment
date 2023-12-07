using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_02
{
    internal class Bankaccount
    {
        private string Accountnumber;
        private decimal Balance;

        public Bankaccount(string accountnumber, decimal balance) 
        { 
         Accountnumber = accountnumber;
         Balance = balance;
        }

        public void Deposit(decimal amount) 
        {
            Balance = amount + Balance;
        }

        public void Withdraw(decimal amount) 
        { 
         Balance = Balance - amount;
        }

        public void Output() 
        {
            Console.WriteLine($"The final balance is {Balance}");
        }
    }
}
