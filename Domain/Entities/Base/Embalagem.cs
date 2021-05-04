using AbstractFactory.Domain.ValueObj;

namespace AbstractFactory.Domain.Entities.Base
{
    public abstract class Embalagem
    {
        protected Embalagem(string nome, TipoProduto tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }

        public string Nome { get; set; }
        public TipoProduto Tipo { get; set; }
    }
}
