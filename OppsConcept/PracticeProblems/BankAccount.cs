using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.PracticeProblems
{
    internal class BankAccount
    {
        private static int s_nextAccountNumber;
        public static double InterestRate;
        public readonly string CustomerId;
        public readonly int AccountNumber;

        public double Balance = 0;
        public string AccountType = "Checking";

        static BankAccount()
        {
            Random random = new Random();
            s_nextAccountNumber = random.Next(1000000, 999999999);
            InterestRate = 0.00;
        }
        public BankAccount(string customerId)
        {
            this.CustomerId = customerId;
            this.AccountNumber = s_nextAccountNumber++;
        }

        public BankAccount(string customerIdNumber, double balance, string accountType)
        {
            this.AccountNumber = s_nextAccountNumber++;
            this.CustomerId = customerIdNumber;
            this.Balance = balance;
            this.AccountType = accountType;
        }

    }
}
