namespace DesignPatternsApp.Strategy
{
    /*
    The Strategy pattern allows you to define a family of algorithms, 
    encapsulate each one as a separate class, and make them interchangeable 
    at runtime. This enables you to change the behavior of an object without changing its class.
     */
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
