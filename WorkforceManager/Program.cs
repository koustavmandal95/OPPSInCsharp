// See https://aka.ms/new-console-template for more information

using System;
using WorkforceManager.HR;

namespace WorkforceManager
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);
            george.DisplayEmployeeDetails();

            bethany.DisplayEmployeeDetails();
            bethany.PerformWork(8);
            bethany.PerformWork();
            bethany.PerformWork(3);
            bethany.ReceiveWage();

            Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);


            mary.DisplayEmployeeDetails();
            mary.PerformWork(25);
            mary.PerformWork();
            mary.ReceiveWage();
            mary.AttendManagementMeeting();
            
        }       
    }
}


