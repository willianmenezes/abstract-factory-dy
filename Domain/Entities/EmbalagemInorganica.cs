using AbstractFactory.Domain.Entities.Base;
using AbstractFactory.Domain.ValueObj;
using System.Collections.Generic;

namespace AbstractFactory.Domain.Entities
{
    public class EmbalagemInorganica : Embalagem
    {
        public EmbalagemInorganica() : base(TipoProduto.Inorganico) { }

        public override List<Embalagem> BuscarEmbalagens()
        {
            return new List<Embalagem>()
            {
                new EmbalagemInorganica(){ Nome = "Embalagem inorganica 01" },
                new EmbalagemInorganica(){ Nome = "Embalagem inorganica 02" },
                new EmbalagemInorganica(){ Nome = "Embalagem inorganica 03" },
            };
        }
    }
}
