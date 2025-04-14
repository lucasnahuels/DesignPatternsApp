using DesignPatternsApp.Builder;

namespace DesignPatternsApp.Observer
{
    public class SmsNotifier : IObserver
    {
        private readonly User _user;

        public SmsNotifier(User user)
        {
            _user = user;
        }

        public void Update(decimal amount)
        {
            Console.WriteLine($"SMS Notification to {_user.PhoneNumber}: A payment of {amount:C} was processed.");
        }
    }
}
