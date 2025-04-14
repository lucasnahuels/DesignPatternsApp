using DesignPatternsApp.Observer;
using DesignPatternsApp.Strategy;
using System;

namespace DesignPatternsApp
{
    public class PaymentProcessor // (Subject)
    {
        private IPaymentStrategy _paymentStrategy;
        private readonly List<IObserver> _observers = new();

        // Set the strategy at runtime
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("No payment strategy set.");
                return;
            }

            _paymentStrategy.Pay(amount);
            NotifyObservers(amount);
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyObservers(decimal amount)
        {
            foreach (var observer in _observers)
            {
                observer.Update(amount);
            }
        }
    }
}
