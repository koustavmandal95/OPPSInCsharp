using System;

namespace OppsConcept.Abstraction
{
    abstract class Vehicle
    {
        protected string Brand;

        protected Vehicle(string brand)
        {
            Brand = brand;
        }
        public abstract void Start();
        public void DisplayBrand()
        {
            Console.WriteLine("Brand: " + Brand);
        }
        public virtual void Stop()
        {
            Console.WriteLine("Vehicle is stopping...");
        }
}
    class Car : Vehicle
    {
        public Car(string brand) : base(brand) { }

        public override void Start()
        {
            Console.WriteLine("Car is starting...");
        }
        
        /*
        if this method is not overridden, it will use the base class implementation
        but if you want to provide a specific implementation for Car, you can uncomment this method
        and it will override the base class Stop method.
        public override void Stop()
     {
            Console.WriteLine("Car is stopping...");
        }
        */
    }
}

