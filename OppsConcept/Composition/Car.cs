using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OppsConcept.Composition
{
    public class Engine
    {
        private int horsePower;

        public Engine(int horsePower)
        {
            this.horsePower = horsePower;
        }

        public void Start()
        {
            Console.WriteLine("Engine started with " + horsePower + " HP.");
        }
    }
    public class Wheel
    {
        private int size;

        public Wheel(int size)
        {
            this.size = size;
        }

        public void Rotate()
        {
            Console.WriteLine("Wheel of size " + size + " is rotating.");
        }
    }
    public class Transmission
    {
        private string type;

        public Transmission(string type)
        {
            this.type = type;
        }

        public void Shift()
        {
            Console.WriteLine("Transmission shifted to " + type + " mode.");
        }
    }
    public class Car
    {
        private Engine engine;
        private Wheel wheel;
        private Transmission transmission;

        public Car(Engine engine, Wheel wheel, Transmission transmission)
        {
            this.engine = engine;
            this.wheel = wheel;
            this.transmission = transmission;
        }
        public void Drive()
        {
            engine.Start();
            wheel.Rotate();
            transmission.Shift();
            Console.WriteLine("Car is now driving.");
        }
    }

}