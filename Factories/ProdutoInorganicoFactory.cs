using AbstractFactory.Domain.Entities;
using AbstractFactory.Domain.Entities.Base;
using AbstractFactory.Domain.ValueObj;
using AbstractFactory.Factories.AbstractFactories;
using System.Collections.Generic;

namespace AbstractFactory.Factories
{
    public class ProdutoInorganicoFactory : ProdutoFactory
    {
        public override Alimento CriarAlimento()
        {
            return new AlimentoInorganico();
        }

        public override Embalagem CriarEmbalagem()
        {
            return new EmbalagemInorganica();
        }
    }
}
