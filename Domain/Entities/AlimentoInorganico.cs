using AbstractFactory.Domain.Entities.Base;
using AbstractFactory.Domain.ValueObj;
using System.Collections.Generic;

namespace AbstractFactory.Domain.Entities
{
    public class AlimentoInorganico : Alimento
    {
        public AlimentoInorganico() : base(TipoProduto.Inorganico) { }

        public override List<Alimento> BuscarAlimentos()
        {
            throw new System.NotImplementedException();
        }
    }
}
