using AbstractFactory.Domain.Entities;
using AbstractFactory.Domain.Entities.Base;
using AbstractFactory.Factories.AbstractFactories;
using System.Collections.Generic;

namespace AbstractFactory.Factories
{
    public class ProdutoOrganicoFactory : ProdutoFactory
    {
        public override Alimento CriarAlimento()
        {
            return new AlimentoOrganico();
        }

        public override Embalagem CriarEmbalagem()
        {
            return new EmbalagemOrganica();
        }
    }
}
