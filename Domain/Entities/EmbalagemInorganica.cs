using AbstractFactory.Domain.Entities.Base;
using AbstractFactory.Domain.ValueObj;

namespace AbstractFactory.Domain.Entities
{
    public class EmbalagemInorganica : Embalagem
    {
        public EmbalagemInorganica(string nome) : base(nome, TipoProduto.Inorganico) { }
    }
}
