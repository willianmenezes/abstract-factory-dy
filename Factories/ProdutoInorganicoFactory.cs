using AbstractFactory.Domain.Entities;
using AbstractFactory.Domain.Entities.Base;
using AbstractFactory.Factories.AbstractFactories;
using System.Collections.Generic;

namespace AbstractFactory.Factories
{
    public class ProdutoInorganicoFactory : ProdutoFactory
    {
        public override List<Alimento> BuscarAlimentos()
        {
            return new List<Alimento>()
            {
                new AlimentoInorganico("Alimento inorganico 01"),
                new AlimentoInorganico("Alimento inorganico 02"),
                new AlimentoInorganico("Alimento inorganico 03"),
            };
        }

        public override List<Embalagem> BuscarEmbalagens()
        {
            return new List<Embalagem>()
            {
                new EmbalagemInorganica("Embalagem inorganica 01"),
                new EmbalagemInorganica("Embalagem inorganica 02"),
                new EmbalagemInorganica("Embalagem inorganica 03"),
            };
        }
    }
}
