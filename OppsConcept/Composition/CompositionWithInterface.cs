using System;
namespace OppsConcept.Composition
{
    interface IEngine
    {
        void Start();
    }

    class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Petrol engine started.");
        }
    }
    class DieselEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Diesel engine started.");
        }
    }

    class CAR
    {
        private IEngine engine;

        public CAR(IEngine engine)
        {
            this.engine = engine;
        }

        public void Drive()
        {
            engine.Start();
            Console.WriteLine("Car is driving.");
        }
    }
}