namespace OppsConcept.Abstraction
{
    interface IAnimal
    {
        // on instatiation of the IAnimal interface with Dog or cat only those methods will be available
        // which are defined in the IAnimal interface.
        // If you want to use the methods defined in Dog or Cat class, you need to cast the IAnimal interface to Dog or Cat class.
        // This is an example of abstraction where the interface defines a contract
        // and the concrete classes implement that contract.
        // This allows for polymorphism, where you can use the IAnimal type to refer to
        // any animal that implements the IAnimal interface.
        void Makesound();
        
    }
    class Dog : IAnimal
    {
        public void Makesound()
        {
            Console.WriteLine("Dog barks");
        }
        public void Fetch()
        {
            Console.WriteLine("Dog is fetching the ball");
        }
    }
    class Cat : IAnimal
    {
        public void Makesound()
        {
            Console.WriteLine("Cat meows");
        }
        public void Scratch()
        {
            Console.WriteLine("Cat is scratching the furniture");
        }
    }
}