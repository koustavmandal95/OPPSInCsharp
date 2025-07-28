using System;

namespace OppsConcept.Abstraction
{
    abstract class Vehicle
{
    protected string Brand;

    public Vehicle(string brand)
    {
        Brand = brand;
    }
    public abstract void Start(); 
    public void DisplayBrand()
    {
        Console.WriteLine("Brand: " + Brand);
    }
}
    class Car : Vehicle {
        public Car(string brand) : base(brand) {}
        
        public override void Start() {
            Console.WriteLine("Car is starting...");
        }
    }

    class Driver 
    {
        static void Main() {
            Vehicle myCar = new Car("Toyota");
            myCar.DisplayBrand();
            myCar.Start();
        }
    }
}

