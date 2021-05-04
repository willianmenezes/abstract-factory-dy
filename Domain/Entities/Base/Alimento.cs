using AbstractFactory.Domain.ValueObj;
using System.Collections.Generic;

namespace AbstractFactory.Domain.Entities.Base
{
    public abstract class Alimento
    {
        protected Alimento(TipoProduto tipo)
        {
            Tipo = tipo;
        }

        public string Nome { get; set; }
        public TipoProduto Tipo { get; set; }

        public abstract List<Alimento> BuscarAlimentos();
    }
}
