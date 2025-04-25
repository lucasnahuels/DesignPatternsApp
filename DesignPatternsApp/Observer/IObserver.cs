namespace DesignPatternsApp.Observer
{
    /*
    The Observer design pattern is a software design pattern that allows 
    objects to be notified of changes to other objects without having a 
    direct reference to one another.
    */
    public interface IObserver
    {
        void Update(decimal amount, string product);
    }
}
