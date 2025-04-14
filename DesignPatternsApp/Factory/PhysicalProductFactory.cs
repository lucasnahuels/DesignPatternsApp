namespace DesignPatternsApp.Factory
{
    public class PhysicalProductFactory : ProductFactory
    {
        public override Product CreateProduct()
        {
            return new PhysicalProduct();
        }
    }
}
