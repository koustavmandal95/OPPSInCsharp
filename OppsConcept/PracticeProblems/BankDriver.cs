using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OppsConcept.PracticeProblems.M1;

namespace OppsConcept.PracticeProblems
{
    internal class BankDriver
    {
        static void Main(string[] args)
        {
           BankCustomer customer1 = new BankCustomer();
           BankCustomer customer2 = new BankCustomer("Tim", "Smith");

            string firstName = "Sandy";
            string lastName = "Zoeng";
            string customerIdNumber = "2020202020";
            BankCustomer customer3 = new BankCustomer(firstName, lastName, customerIdNumber);

            // Create accounts for customers
            BankAccount account1 = new BankAccount(customer1.CustomerId);
            BankAccount account2 = new BankAccount(customer2.CustomerId, 1500, "Checking");
            BankAccount account3 = new BankAccount(customer3.CustomerId, 2500, "Checking");

            Console.WriteLine($"Account 1: Account # {account1.AccountNumber}, type {account1.AccountType}, balance {account1.Balance}, rate {BankAccount.InterestRate}, customer ID {account1.CustomerId}");
            Console.WriteLine($"Account 2: Account # {account2.AccountNumber}, type {account2.AccountType}, balance {account2.Balance}, rate {BankAccount.InterestRate}, customer ID {account2.CustomerId}");
            Console.WriteLine($"Account 3: Account # {account3.AccountNumber}, type {account3.AccountType}, balance {account3.Balance}, rate {BankAccount.InterestRate}, customer ID {account3.CustomerId}");


        }
    }
}
