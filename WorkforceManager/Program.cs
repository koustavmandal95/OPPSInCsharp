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

            JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
            bobJunior.ResearchNewPieTastes(5);
            bobJunior.ResearchNewPieTastes(5);

            //DEMO 4
            Employee jake = new Employee("Jake", "Nicols", "jake@snowball.be", new DateTime(1995, 8, 16), 25, "New street", "123", "123456", "Pie Ville");
            string streetName = jake.Address.Street;
            Console.WriteLine($"{jake.FirstName} lives on {jake.Address.Street}");

            //Address newAddress = new Address("Another street", "444", "999999", "Donut town");
            //jake.Address = newAddress;
            //Console.WriteLine($"{jake.FirstName} moved to {jake.Address.Street} in {jake.Address.City}");
            
        }       
    }
}


