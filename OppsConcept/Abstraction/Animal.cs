namespace OppsConcept.Abstraction
{
    interface IAnimal
    {
        void Makesound();
    }
    class Dog : IAnimal
    {
        public void Makesound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    class Cat : IAnimal
    {
        public void Makesound()
        {
            Console.WriteLine("Cat meows");
        }
    }
}