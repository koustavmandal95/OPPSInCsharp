using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OppsConcept.Inheritance
{
    public class SimpleExamples
    {
        static void Main(string[] args)
        {
            VehicleDriver();

        }

        private static void VehicleDriver()
        {
            Vehicle myCar = new Car();
            // Vehicle instance type will onlu access Vehicle related class members
            // upcasting to Vehicle class
            Console.WriteLine(myCar.brand);

            // Downcasting of derived class
            Car downcastedCar = (Car)myCar;
            Console.WriteLine(downcastedCar.modelName);
            Console.WriteLine(downcastedCar.brand);

            // Normal Class creation
            Car myCarSecond = new Car();
            Console.WriteLine(myCarSecond.modelName);
        }
    }
}