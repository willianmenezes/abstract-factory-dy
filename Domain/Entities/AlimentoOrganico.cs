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
            return new List<Alimento>()
            {
                new AlimentoOrganico() { Nome = "Alimento organico 01" },
                new AlimentoOrganico() { Nome = "Alimento organico 02" },
                new AlimentoOrganico() { Nome = "Alimento organico 03" },
            };
        }
    }
}
