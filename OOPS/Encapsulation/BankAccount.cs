using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Encapsulation
{
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        public string AccountNumber
        {
            get { return accountNumber;  }
            set { accountNumber = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if(amount <= balance)
            {
                balance -= amount;
            }
        }
    }
}
