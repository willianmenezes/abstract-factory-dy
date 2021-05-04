using AbstractFactory.Domain.Entities.Base;
using AbstractFactory.Domain.ValueObj;
using System.Collections.Generic;

namespace AbstractFactory.Domain.Entities
{
    public class EmbalagemOrganica: Embalagem
    {
        public EmbalagemOrganica() : base(TipoProduto.Organico) { }

        public override List<Embalagem> BuscarEmbalagens()
        {
            return new List<Embalagem>()
            {
                new EmbalagemOrganica(){ Nome = "Embalagem organica 01" },
                new EmbalagemOrganica(){ Nome = "Embalagem organica 02" },
                new EmbalagemOrganica(){ Nome = "Embalagem organica 03" },
            };
        }
    }
}
