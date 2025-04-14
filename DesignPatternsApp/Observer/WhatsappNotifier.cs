namespace DesignPatternsApp.Observer
{
    public class WhatsappNotifier : IObserver
    {
        public void Update(decimal amount, string product)
        {
            Console.WriteLine($"{product}: WP Notification: A payment of {amount:C} was processed.");
        }
    }
}
