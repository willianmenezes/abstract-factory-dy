using AbstractFactory.Domain.Entities.Base;
using AbstractFactory.Domain.ValueObj;

namespace AbstractFactory.Domain.Entities
{
    public class EmbalagemOrganica: Embalagem
    {
        public EmbalagemOrganica(string nome) : base(nome, TipoProduto.Organico) { }
    }
}
