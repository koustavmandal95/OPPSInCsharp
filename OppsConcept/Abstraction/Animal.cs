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

    static class AnimalDowncastingDemo
    {
        public static void DemonstrateDowncasting()
        {
            // Create animals using interface reference
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();

            Console.WriteLine("=== Downcasting Demonstration ===");

            // Method 1: Direct casting (unsafe)
            Console.WriteLine("\n1. Direct Casting:");
            try
            {
                Dog directDog = (Dog)dog;
                directDog.Fetch();
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Direct cast failed: {ex.Message}");
            }

            // Method 2: Using 'as' operator (safe)
            Console.WriteLine("\n2. Using 'as' operator:");
            Dog? safeDog = dog as Dog;
            if (safeDog != null)
            {
                safeDog.Fetch();
            }
            else
            {
                Console.WriteLine("Cast to Dog failed");
            }

            Cat? safeCat = dog as Cat;  // This will be null
            if (safeCat != null)
            {
                safeCat.Scratch();
            }
            else
            {
                Console.WriteLine("Cannot cast Dog to Cat");
            }

            // Method 3: Pattern matching with 'is' (C# 7.0+)
            Console.WriteLine("\n3. Pattern matching with 'is':");
            if (dog is Dog patternDog)
            {
                patternDog.Fetch();
            }

            if (cat is Cat patternCat)
            {
                patternCat.Scratch();
            }

            // Method 4: Modern pattern matching (recommended)
            Console.WriteLine("\n4. Modern pattern matching:");
            if (dog is Dog modernDog)
            {
                modernDog.Fetch();
            }

            // Demonstrate polymorphism vs downcasting
            Console.WriteLine("\n=== Polymorphism vs Downcasting ===");
            IAnimal[] animals = { new Dog(), new Cat() };
            
            foreach (IAnimal animal in animals)
            {
                animal.Makesound();  // Polymorphism - works without casting
                
                // Downcasting to access specific methods
                switch (animal)
                {
                    case Dog d:
                        d.Fetch();
                        break;
                    case Cat c:
                        c.Scratch();
                        break;
                }
            }
        }
    }
}