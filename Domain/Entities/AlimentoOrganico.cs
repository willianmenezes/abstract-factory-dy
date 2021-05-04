using AbstractFactory.Domain.Entities.Base;
using AbstractFactory.Domain.ValueObj;

namespace AbstractFactory.Domain.Entities
{
    public class AlimentoOrganico : Alimento
    {
        public AlimentoOrganico(string nome) : base(nome, TipoProduto.Organico) { }
    }
}
