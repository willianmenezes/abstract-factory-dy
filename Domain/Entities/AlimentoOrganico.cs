using AbstractFactory.Domain.Entities.Base;
using AbstractFactory.Domain.ValueObj;
using System.Collections.Generic;

namespace AbstractFactory.Domain.Entities
{
    public class AlimentoOrganico : Alimento
    {
        public AlimentoOrganico() : base(TipoProduto.Organico) { }

        public override List<Alimento> BuscarAlimentos()
        {
            throw new System.NotImplementedException();
        }
    }
}
