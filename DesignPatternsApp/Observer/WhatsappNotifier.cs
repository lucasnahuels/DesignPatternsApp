namespace DesignPatternsApp.Observer
{
    public class WhatsappNotifier : IObserver
    {
        public void Update(decimal amount)
        {
            Console.WriteLine($"WP Notification: A payment of {amount:C} was processed.");
        }
    }
}
