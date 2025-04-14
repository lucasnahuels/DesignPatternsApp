namespace DesignPatternsApp.Strategy
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using PayPal.");
        }
    }
}
