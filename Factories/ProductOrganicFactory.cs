

using AbstractFactory.Domain;
using AbstractFactory.Domain.Base;
using AbstractFactory.Factories.AbstractFactories;

namespace AbstractFactory.Factories
{
    public class ProductOrganicFactory : ProductFactory
    {
        public override Food CreateFood()
        {
            return new FoodOrganic();
        }

        public override Packing CreatePacking()
        {
            return new PackingOrganic();
        }
    }
}
