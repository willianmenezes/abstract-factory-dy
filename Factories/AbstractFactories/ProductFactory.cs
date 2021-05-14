
using AbstractFactory.Domain.Base;

namespace AbstractFactory.Factories.AbstractFactories
{
    public abstract class ProductFactory
    {
        public abstract Food CreateFood();
        public abstract Packing CreatePacking();
    }
}
