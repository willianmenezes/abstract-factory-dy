using AbstractFactory.Domain.Entities;
using AbstractFactory.Domain.Entities.Base;
using AbstractFactory.Factories.AbstractFactories;
using System.Collections.Generic;

namespace AbstractFactory.Factories
{
    public class ProdutoOrganicoFactory : ProdutoFactory
    {
        public override List<Alimento> BuscarAlimentos()
        {
            return new List<Alimento>()
            {
                new AlimentoOrganico("Alimento organico 01"),
                new AlimentoOrganico("Alimento organico 02"),
                new AlimentoOrganico("Alimento organico 03"),
            };
        }

        public override List<Embalagem> BuscarEmbalagens()
        {
            return new List<Embalagem>()
            {
                new EmbalagemOrganica("Embalagem organica 01"),
                new EmbalagemOrganica("Embalagem organica 02"),
                new EmbalagemOrganica("Embalagem organica 03"),
            };
        }
    }
}
