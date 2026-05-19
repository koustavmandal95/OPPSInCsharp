using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.PracticeProblems.M1
{
    internal class BankCustomer
    {
        private static int s_nextCustomerId;
        public string FirstName = "Tim";
        public string LastName = "Shao";
        public readonly string CustomerId;

        /*
        static BankCustomer()
        {
            Random random = new Random();
            s_nextCustomerId = random.Next(1000000, 999999999);
        }
        */

        // private access modifier by default
        public BankCustomer()     
        {
            this.CustomerId = (s_nextCustomerId++).ToString("D10");
            s_nextCustomerId = 88;
            Console.WriteLine(s_nextCustomerId);
        }
        public BankCustomer(string firstName,string lastName)
        {
            this.CustomerId = (s_nextCustomerId++).ToString("D10");
        }

        public BankCustomer(string firstName, string lastName, string customerIdNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            CustomerId = customerIdNumber;
        }


    }
}
