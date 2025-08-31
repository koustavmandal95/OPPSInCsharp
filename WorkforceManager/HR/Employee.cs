using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WorkforceManager.HR
{
    internal class Employee
    {
        protected string firstName;
        protected string lastName;
        protected string email;

        private int numberOfHoursWorked;
        private double wage;
        protected double? hourlyRate;
        
        public DateTime birthDay;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value;  }
        }
        public string Email
        {
            get { return email; }
            private set { lastName = value;  }
        }
        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; }
            protected set { numberOfHoursWorked = value; }
        }

        public double Wage
        {
            get { return wage; }
            private set { wage = value; }
        }

        public double? HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (hourlyRate < 0)
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
            }
        }

        const int minimalHoursWorkedUnit = 1;

        public static double taxRate = 0.15;

        public Employee(string first, string last, string em, DateTime bd, double? rate)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDay = bd;
            hourlyRate = rate ?? 10;
        }

        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0)
        {
        }

        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
        }

        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;

            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s)!");
        }

        public int CalculateBonus(int bonus)
        {

            if (numberOfHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        //public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        //{

        //    if (numberOfHoursWorked > 10)
        //        bonus *= 2;

        //    if (bonus >= 200)
        //    {
        //        bonusTax = bonus / 10;
        //        bonus -= bonusTax;
        //    }

        //    Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
        //    return bonus;
        //}

        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (numberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
            return bonus;
        }


        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTax = 0.0;

            wageBeforeTax = numberOfHoursWorked * hourlyRate.Value * 1.25;
            wageBeforeTax = numberOfHoursWorked * hourlyRate.Value;
            double taxAmount = wageBeforeTax * taxRate;
            wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");

            if (resetHours)
                numberOfHoursWorked = 0;

            return wage;
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);

            return json;
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nBirthday: \t{birthDay.ToShortDateString()}\nTax rate: \t{taxRate}");
        }
    }
}