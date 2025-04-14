namespace DesignPatternsApp.Factory
{
    public class DigitalProductFactory : ProductFactory
    {
        public override Product CreateProduct()
        {
            return new DigitalProduct();
        }
    }
}
