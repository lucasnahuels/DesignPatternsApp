namespace DesignPatternsApp.Strategy
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
