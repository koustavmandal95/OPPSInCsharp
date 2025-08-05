// See https://aka.ms/new-console-template for more information

using System;
using WorkforceManager.HR;

namespace WorkforceManager
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
            Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
            george.DisplayEmployeeDetails();
        }       
    }
}


