using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OppsConcept.Composition
{
    public class CompositionDriver
    {
        static void Main()
        {
            Engine engine = new Engine(150);
            Wheel wheel = new Wheel(4);
            Transmission transmission = new Transmission("Automatic");

            Car car = new Car(engine, wheel, transmission);
            car.Drive();
        
        System.Console.WriteLine("--- Using Interface Composition ---");

        CAR petrolCar = new CAR(new PetrolEngine());
        petrolCar.Drive();

        CAR dieselCar = new CAR(new DieselEngine());
        dieselCar.Drive();
       }
    }
}