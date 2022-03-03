using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceRealationship.cs
{
    class BankAccount
    {
        public string AccountNo { get; set; }
        public string CoustomerName { get; set; }
        public double Balance { get; set; }

        public string Deposite(double amount)
        {
            Balance +=amount;
            return "Deposited";
        }
        public string Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return "Withdrawn";
            }
            else
            {
                return "Insufficient Balance";
            }
        }
    }
}
