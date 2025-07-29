namespace OppsConcept.Abstraction
{
    class Driver 
    {
        static void Main() 
        {
            Car myCar = new Car("Toyota");
            myCar.DisplayBrand();
            myCar.Start();

            Console.WriteLine(new string('X', 20));
            IAnimal dog = new Dog();
            dog.Makesound();

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

        }
    }
}