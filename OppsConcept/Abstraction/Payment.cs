namespace OppsConcept.Abstraction
{
    public abstract class Payment
    {
        protected double amount;
        public Payment(double amount)
        {
            this.amount = amount;
        }
        public abstract void ProcessPayment();
    }
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(double amount) : base(amount) { }

        public override void ProcessPayment()
        {
            // Logic to process credit card payment
            Console.WriteLine($"Processing credit card payment of {amount} units.");
        }
    }
    public class PayPalPayment : Payment
    {
        public PayPalPayment(double amount) : base(amount) { }

        public override void ProcessPayment()
        {
            // Logic to process PayPal payment
            Console.WriteLine($"Processing PayPal payment of {amount} units.");
        }
    }
}