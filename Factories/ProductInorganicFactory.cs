

using AbstractFactory.Domain;
using AbstractFactory.Domain.Base;
using AbstractFactory.Factories.AbstractFactories;

namespace AbstractFactory.Factories
{
    public class ProductInorganicFactory : ProductFactory
    {
        public override Food CreateFood()
        {
            return new FoodInorganic();
        }

        public override Packing CreatePacking()
        {
            return new PackingInorganic();
        }
    }
}
