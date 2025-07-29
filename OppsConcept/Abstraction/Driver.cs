namespace OppsConcept.Abstraction
{
    class Driver 
    {
        static void Main() 
        {
            Vehicle myCar = new Car("Toyota");
            myCar.DisplayBrand();
            myCar.Start();
            myCar.Stop();

            Console.WriteLine(new string('X', 20));
            IAnimal dog = new Dog();
            dog.Makesound();
            // dog.Fetch();  Not allowed as Fetch is not part of IAnimal interface

            Dog specificDog = new Dog();
            specificDog.Makesound(); // Allowed as Makesound is part of IAnimal interface
            specificDog.Fetch(); // Allowed as Fetch is part of Dog class

            IAnimal cat = new Cat();
            cat.Makesound();

            Console.WriteLine(new string('X', 20));
            Payment payment;
            
            payment = new CreditCardPayment(150.75);
            payment.ProcessPayment();
            
            payment = new PayPalPayment(200.50);
            payment.ProcessPayment();

            /*
            Brand: Toyota
            Car is starting...
            XXXXXXXXXXXXXXXXXXXX
            Dog barks
            Cat meows
            XXXXXXXXXXXXXXXXXXXX
            Processing credit card payment of 150.75 units.
            Processing PayPal payment of 200.5 units.
            */

            // Demonstrate downcasting with animals
            Console.WriteLine("\n" + new string('=', 50));
            AnimalDowncastingDemo.DemonstrateDowncasting();

        }
    }
}