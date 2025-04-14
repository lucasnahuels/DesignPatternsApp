namespace DesignPatternsApp.Strategy
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using Credit Card.");
        }
    }
}
