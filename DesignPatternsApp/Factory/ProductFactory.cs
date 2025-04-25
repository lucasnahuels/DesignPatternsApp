namespace DesignPatternsApp.Factory
{
    /*
    The Factory Method design pattern is a creational pattern that provides an
    interface for creating objects without specifying the exact class of object 
    that will be created.
     */
    public abstract class ProductFactory
    {
        public abstract Product CreateProduct();
    }
}
