using AbstractFactory.Domain.Entities.Base;
using System.Collections.Generic;

namespace AbstractFactory.Factories.AbstractFactories
{
    public abstract class ProdutoFactory
    {
        public abstract List<Alimento> BuscarAlimentos();
        public abstract List<Embalagem> BuscarEmbalagens();
    }
}
