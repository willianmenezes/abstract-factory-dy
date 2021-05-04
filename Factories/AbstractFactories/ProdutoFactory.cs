using AbstractFactory.Domain.Entities.Base;

namespace AbstractFactory.Factories.AbstractFactories
{
    public abstract class ProdutoFactory
    {
        public abstract Alimento CriarAlimento();
        public abstract Embalagem CriarEmbalagem();
    }
}
