namespace DesignPatternsApp.Observer
{
    public interface IObserver
    {
        void Update(decimal amount, string product);
    }
}
