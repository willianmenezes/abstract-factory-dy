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
            return new List<Alimento>()
            {
                new AlimentoInorganico() { Nome = "Alimento inorganico 01" },
                new AlimentoInorganico() { Nome = "Alimento inorganico 02" },
                new AlimentoInorganico() { Nome = "Alimento inorganico 03" },
            };
        }
    }
}
